using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using DirectShowLib;

namespace BallTracker
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Objeto que captura los frames entregados por la cámara
        /// </summary>
        VideoCapture videoCapture;
        /// <summary>
        /// Bandera para indicar si se estan opteniendo imágenes
        /// o la cámara está detenida
        /// </summary>
        Boolean blnCapturingInProcess = false;
        /// <summary>
        /// Fotograma inmediatamente anterior para detectar movimiento
        /// </summary>
        Mat matAnterior;
        /// <summary>
        /// Indica si el fotograma anterior para el nálisis de movimiento est´pa en escala de grises
        /// </summary>
        bool esAnteriorGris = false;
        /// <summary>
        /// Variable para definir cual frame se procesa (1 de cada 3, por ejemplo)
        /// </summary>
        int iCapturar = 0;
        /// <summary>
        /// Indica cual es la cámara seleccionada
        /// </summary>
        int iFuente = 0;
        /// <summary>
        /// Varible para guardar el circulo anteriormente detectado 
        /// </summary>
        CircleF[] circulosAnterior;
        public Form1()
        {
            InitializeComponent();
           
            DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            for (int i = 0; i < _SystemCamereas.Length; i++)
            {
                cmbFuenteWebCam.Items.Add(_SystemCamereas[i].Name);
            }

            this.cmbGrises.SelectedIndex = 0;
            this.cmbMovimiento.SelectedIndex = 2;
            this.cmbBordes.SelectedIndex = 3;
            this.cmbContraste.SelectedIndex = 0;

            //this.cmbFuenteWebCam.SelectedIndex = 0;

            cmbFuenteWebCam.Visible = rdbFuenteCam.Checked;
            grbFuenteRuta.Visible = rdbFuenteVideo.Checked;

            Run();
        }

        /// <summary>
        /// Función que inicia el proceso de captura y análisis de las imágenes
        /// </summary>
        private void Run()
        {
            try
            {
                // Instancia el objeto e incia la captura
                videoCapture = new VideoCapture();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            // Agrega el evento que se dispara tras cada captura del un frame
            Application.Idle += ProcessFrame;
            // Indica que se inció la captura
            blnCapturingInProcess = true;
        }


        private static byte SaturateCast(double value)
        {
            var rounded = Math.Round(value, 0);

            if (rounded < byte.MinValue)
            {
                return byte.MinValue;
            }

            if (rounded > byte.MaxValue)
            {
                return byte.MaxValue;
            }

            return (byte)rounded;
        }

        /// <summary>
        /// Evento que se invoca en cada frame/imagen capturado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessFrame(object sender, EventArgs e)
        {
            DateTime dtIni = DateTime.Now;

            // Crea una matriz con los datos del frame capturado imagen en formato Bgr
            Mat matOriginal = videoCapture.QuerySmallFrame();

            // Valida que se haya capturado alguna imagen
            if (matOriginal == null)
            {
                if (rdbFuenteVideo.Checked)
                {
                    btnFuenteVideoPlay_Click(null, null);
                    return;
                }
                else if (rdbFuenteFolder.Checked)
                {
                    matOriginal = new Mat(sender.ToString());
                }
                else
                {
                    MessageBox.Show("No se encuentra web cam");
                    Start_Click(null, null);
                    //Environment.Exit(0);
                    return;
                }
            }

            // =========== Proceso de análisis de la imagen =================

            ImgOriginal.Image = matOriginal;
            /**
             * Condisiones para determinar la cantidad de frames que serán procesados 
             * */
            iCapturar++;
            if (iCapturar > numRetraso.Value)
            {
                iCapturar = 0;
            }

            if (iCapturar != numRetraso.Value)
            {
                return;
            }

            // Máscara: Crea una matriz de 3x3, para usarla luego como máscara para la dilatación y eroción
            Mat matStructuringElement = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
            // Matriz para almacenar los umbrales a procesar
            Mat matUmbralesSumados = new Mat(matOriginal.Size, DepthType.Cv8U, 1);

            #region Pre procesamientos


            #region HSV
            // Crea una matriz de 3 canales del tamaño de la imagen para 
            // luego optener una de HSV (matiz, saturación, brillo)
            Mat matHSV = new Mat(matOriginal.Size, DepthType.Cv8U, 3);
            CvInvoke.CvtColor(matOriginal, matHSV, ColorConversion.Bgr2Hsv);
            imgHSV.Image = matHSV;
            #endregion HSV

            #region Contraste y Brillo
            // Se configura el contraste y brillo de la imagen
            Mat matContraste = new Mat(matOriginal.Size, DepthType.Cv8U, 3);

            if (cmbContraste.SelectedItem.ToString() == "Original")
                matOriginal.ConvertTo(matContraste, DepthType.Cv8U,
                                     ((double)numericContrast.Value) / 100, ((double)numericBrillo.Value));
            else if (cmbContraste.SelectedItem.ToString() == "HSV")
                matHSV.ConvertTo(matContraste, DepthType.Cv8U,
                                     ((double)numericContrast.Value) / 100, ((double)numericBrillo.Value));
            imgContraste.Image = matContraste;
            #endregion

            #region Grises
            // Generar la matriz en escala de grises a partir del Bgr original
            Mat matGrises = new Mat(matOriginal.Size, DepthType.Cv8U, 1);
            if (cmbGrises.SelectedItem.ToString() == "Original")
                CvInvoke.CvtColor(matOriginal, matGrises, ColorConversion.Bgr2Gray);
            else if (cmbGrises.SelectedItem.ToString() == "HSV")
                CvInvoke.CvtColor(matHSV, matGrises, ColorConversion.Bgr2Gray);
            else if (cmbGrises.SelectedItem.ToString() == "Contraste y brillo")
                CvInvoke.CvtColor(matContraste, matGrises, ColorConversion.Bgr2Gray);

            imgGrises.Image = matGrises;
            #endregion Grises

            #region Movimiento
            // Detección de movimiento
            Mat matTracking = new Mat(matOriginal.Size, DepthType.Cv8U, 3);
            if (matAnterior != null &&
                (
                    (esAnteriorGris && cmbMovimiento.SelectedItem.ToString() == "Grises") ||
                    (!esAnteriorGris && cmbMovimiento.SelectedItem.ToString() != "Grises")
                ) &&
                matTracking.Size.Equals(matAnterior.Size)
               )
            {
                if (cmbMovimiento.SelectedItem.ToString() == "Original")
                    CvInvoke.AbsDiff(matAnterior, matOriginal, matTracking);
                else if (cmbMovimiento.SelectedItem.ToString() == "HSV")
                    CvInvoke.AbsDiff(matAnterior, matHSV, matTracking);
                else if (cmbMovimiento.SelectedItem.ToString() == "Grises")
                    CvInvoke.AbsDiff(matAnterior, matGrises, matTracking);
                else if (cmbMovimiento.SelectedItem.ToString() == "Contraste y brillo")
                    CvInvoke.AbsDiff(matAnterior, matContraste, matTracking);


                imgMovimiento.Image = matTracking;
            }
            esAnteriorGris = false;
            if (cmbMovimiento.SelectedItem.ToString() == "Original")
                matAnterior = matOriginal;
            else if (cmbMovimiento.SelectedItem.ToString() == "HSV")
                matAnterior = matHSV;
            else if (cmbMovimiento.SelectedItem.ToString() == "Grises")
            { matAnterior = matGrises; esAnteriorGris = true; }
            else if (cmbMovimiento.SelectedItem.ToString() == "Contraste y brillo")
                matAnterior = matContraste;

            //CvInvoke.GaussianBlur(matTracking, matTracking, new Size(3, 3), 0);
            ////Se dilata la imagen
            //CvInvoke.Dilate(matTracking, matTracking, matStructuringElement, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0, 0, 0));
            ////Se erosiona la imagen
            //CvInvoke.Erode(matTracking, matTracking, matStructuringElement, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0, 0, 0));
            //CvInvoke.Erode(matTracking, matTracking, matStructuringElement, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0, 0, 0));

            #endregion Movimiento

            #region Bordes
            // Genera una imagen de bordes
            Mat matBordes = new Mat(matOriginal.Size, DepthType.Cv8U, 3);
            if (cmbBordes.SelectedItem.ToString() == "Original")
                CvInvoke.Canny(matOriginal, matBordes, (double)numBordInf.Value, (double)numBordSup.Value);
            else if (cmbBordes.SelectedItem.ToString() == "HSV")
                CvInvoke.Canny(matHSV, matBordes, (double)numBordInf.Value, (double)numBordSup.Value);
            else if (cmbBordes.SelectedItem.ToString() == "Grises")
                CvInvoke.Canny(matGrises, matBordes, (double)numBordInf.Value, (double)numBordSup.Value);
            else if (cmbBordes.SelectedItem.ToString() == "Movimiento")
                CvInvoke.Canny(matTracking, matBordes, (double)numBordInf.Value, (double)numBordSup.Value);
            else if (cmbBordes.SelectedItem.ToString() == "Contraste y brillo")
                CvInvoke.Canny(matContraste, matBordes, (double)numBordInf.Value, (double)numBordSup.Value);
            imgBordes.Image = matBordes;
            #endregion Bordes   



            #endregion Pre procesamientos

            #region Umbrales para los pixeles para identificar los circulos
            // Crear matrices de un canal del tamaño de la imagen,
            // para luego calcular los umbrales superior e inferior,
            // es decir, buscar los pixeles que estén en el rango buscado,
            // si el pixel está en el rango se pondrá en uno (1) de lo contrario será cero (0)
            Mat matThreshLow = new Mat(matOriginal.Size, DepthType.Cv8U, 1);
            Mat matThreshHigh = new Mat(matOriginal.Size, DepthType.Cv8U, 1);

            // Una vez pre-procesadas las imágenes se buscan los umbrales
            // para sacar los circulos
            // Aquí se debe poner los valores entre los que puede estar el valor buscado
            Mat matUsar = matOriginal;
            if (this.rdbHSV.Checked) matUsar = matHSV;
            else if (this.rdbBordes.Checked) matUsar = matBordes;
            else if (this.rdbTracking.Checked) matUsar = matTracking;

            CvInvoke.InRange(matUsar,
                new ScalarArray(new MCvScalar((double)numUIB1.Value, (double)numUIG1.Value, (double)numUIR1.Value)),
                new ScalarArray(new MCvScalar((double)numUIB2.Value, (double)numUIG2.Value, (double)numUIR2.Value)), matThreshLow);
            CvInvoke.InRange(matUsar,
                new ScalarArray(new MCvScalar((double)numUSB1.Value, (double)numUSG1.Value, (double)numUSR1.Value)),
                new ScalarArray(new MCvScalar((double)numUSB2.Value, (double)numUSG2.Value, (double)numUSR2.Value)), matThreshHigh);
            imgThreshLow.Image = matThreshLow;
            imgThreshHigh.Image = matThreshHigh;
            #endregion Umbrales para los pixeles para identificar los circulos

            #region Unir umbrales
            // Une los puntos/pixeles de la imagen que están dentro de los rangos
            // Se genera una matriz con el resultado fusionado de los rangos 
            // superior e inferior (matUmbralesSumados)
            CvInvoke.Add(matThreshLow, matThreshHigh, matUmbralesSumados);
            //CvInvoke.BitwiseXor(matThresh, matBordes, matThresh);
            imgSumados.Image = matUmbralesSumados;
            #endregion Unir umbrales

            #region Pre-procesar la imagen final antes de buscar los circulos
            // Se aplica un filtro de ruido gaussiano, dilatación y eroción 
            // a la matriz resultado de la fusión, el resultado se almacena 
            // en la misma matriz, es decir reemplaza su valor original
            CvInvoke.GaussianBlur(matUmbralesSumados, matUmbralesSumados, new Size(3, 3), 0);
            //Se dilata la imagen
            CvInvoke.Dilate(matUmbralesSumados, matUmbralesSumados, matStructuringElement, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0, 0, 0));
            //Se erosiona la imagen
            CvInvoke.Erode(matUmbralesSumados, matUmbralesSumados, matStructuringElement, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0, 0, 0));

            imgSumados.Image = matUmbralesSumados;
            #endregion Pre-procesar la imagen final antes de buscar los circulos

            #region Proceso final algoritmo de Hough busqueda circulos
            // En la martiz resultado de la fusión se buscan los circulos
            CircleF[] circles = CvInvoke.HoughCircles(matUmbralesSumados,
                HoughType.Gradient, 2.0, matUmbralesSumados.Rows / 4, 100, 50, (int)numRMin.Value, (int)numRMax.Value);
            #endregion Proceso final algoritmo de Hough busqueda circulos

            TimeSpan tsDuracion = DateTime.Now - dtIni;

            // =========== Presentación de resultados =================

            Mat matResultado = new Mat(matOriginal.Size, DepthType.Cv8U, 3);
            matOriginal.CopyTo(matResultado);
            Mat matResultadoSolo = new Mat(matOriginal.Size, DepthType.Cv8U, 3);
            matBordes.CopyTo(matResultadoSolo);
            CvInvoke.Erode(matResultadoSolo, matResultadoSolo, matStructuringElement, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0, 0, 0));
            CvInvoke.Erode(matResultadoSolo, matResultadoSolo, matStructuringElement, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0, 0, 0));

           
            /**
             * Se recorre la matriz en la cual  se encuentran almacenados los circulos detectados 
             **/

            foreach (CircleF circle in circles)
            {
                if (txtResultados.Text != "")
                {
                    txtResultados.AppendText(Environment.NewLine);
                }

                //agrego la posición en X y en Y además en definir el radio de circulo 
                txtResultados.AppendText("X = " + circle.Center.X.ToString().PadLeft(4) +
                    ", y = " + circle.Center.Y.ToString().PadLeft(4) +
                    ", r = " + circle.Radius.ToString("###.000").PadLeft(7));

                txtResultados.ScrollToCaret();//función para poder hacer scroll

                //dibujamos un circulo al objeto detectado                
                CvInvoke.Circle(matResultado, new Point((int)circle.Center.X,
                    (int)circle.Center.Y), (int)circle.Radius, new MCvScalar(0, 0, 255), 2);
                CvInvoke.Circle(matResultado,
                    new Point((int)circle.Center.X, (int)circle.Center.Y), 3, new MCvScalar(0, 0, 255), -1);

                //CvInvoke.Circle(matResultadoSolo, new Point((int)circle.Center.X,
                //    (int)circle.Center.Y), (int)circle.Radius, new MCvScalar(255, 255, 255), 2);
                //CvInvoke.Circle(matResultadoSolo,
                //    new Point((int)circle.Center.X, (int)circle.Center.Y), 3, new MCvScalar(255, 255, 255), (int)circle.Radius);
               
                foreach (CircleF antCirculo in circulosAnterior)
                {
                    int pocisionX = 0;
                    int pocisionY = 0;
                    int restaX = (int)circle.Center.X - (int)antCirculo.Center.X;
                    int restaY = (int)circle.Center.Y - (int)antCirculo.Center.Y;
                    
                    if (Math.Abs(restaX) <= numVelSeguimiento.Value && Math.Abs(restaY) <= numVelSeguimiento.Value)
                    {
                        CvInvoke.Circle(matResultado, new Point((int)antCirculo.Center.X,
                            (int)antCirculo.Center.Y), (int)antCirculo.Radius, new MCvScalar(0, 255, 0), 2);
                        CvInvoke.Circle(matResultado,
                            new Point((int)antCirculo.Center.X, (int)antCirculo.Center.Y), 3, new MCvScalar(0, 255, 0), -1);

                        CvInvoke.Circle(matResultadoSolo, new Point((int)circle.Center.X,
                    (int)circle.Center.Y), (int)circle.Radius, new MCvScalar(255, 255, 255), 2);
                        CvInvoke.Circle(matResultadoSolo,
                            new Point((int)circle.Center.X, (int)circle.Center.Y), 3, new MCvScalar(255, 255, 255), (int)circle.Radius);
                    }
                    
                    CvInvoke.Line(matResultado, new Point((int)antCirculo.Radius), new Point((int)antCirculo.Radius + 80), new MCvScalar(0, 0, 255), 8);

                    /**
                     * Se determina la dirección en la que el balón se está moviendo
                    **/

                    if (restaX > pocisionX && (int)circle.Center.X > restaX && restaY < pocisionY && (int)circle.Center.Y > restaY)
                        CvInvoke.PutText(matResultado, "Note-Oriente", new Point(0, 50), FontFace.HersheyComplexSmall, 1, new MCvScalar(0, 255, 255));
                    else if (restaX < pocisionX && (int)circle.Center.X > restaX && restaY < pocisionY && (int)circle.Center.Y > restaY)
                        CvInvoke.PutText(matResultado, "Norte-Occidente", new Point(0, 50), FontFace.HersheyComplexSmall, 1, new MCvScalar(0, 255, 255));
                    else if (restaX > pocisionX && (int)circle.Center.X > restaX && restaY > pocisionY && (int)circle.Center.Y > restaY)
                        CvInvoke.PutText(matResultado, "Sur-Oriente", new Point(0, 50), FontFace.HersheyComplexSmall, 1, new MCvScalar(0, 255, 255));
                    else if (restaX < pocisionX && (int)circle.Center.X > restaX && restaY > pocisionY && (int)circle.Center.Y > restaY)
                        CvInvoke.PutText(matResultado, "Sur-Occidente", new Point(0, 50), FontFace.HersheyComplexSmall, 1, new MCvScalar(0, 255, 255));
                    
                    /**
                     * Se almacenan los valores obtenidos de resta entre el frame actual y el anterior  
                     **/
                    pocisionX = restaX;
                    pocisionY = restaY;
                    CvInvoke.PutText(matResultado, "dx: "+ pocisionX +"  "+ "dy: " + pocisionY, new Point(0, 210), 
                                     FontFace.HersheyComplexSmall, 0.65, new MCvScalar(0, 255, 255));
                }
               
            }

            txtResultados.AppendText(Environment.NewLine);
            txtResultados.AppendText("Tiempo: " + tsDuracion.TotalMilliseconds);
            txtResultados.ScrollToCaret(); //función para poder hacer scroll

            imgResultado.Image = matResultado;
            imgResultadoSolo.Image = matResultadoSolo;
            circulosAnterior = circles;
            iCapturar = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (blnCapturingInProcess == true)
            {
                Application.Idle -= ProcessFrame;
                blnCapturingInProcess = false;
                Start.Text = " Resume ";
            }
            else
            {
                Application.Idle += ProcessFrame;
                blnCapturingInProcess = true;
                Start.Text = " Pause ";
            }
        }

        private void cmbFuenteWebCam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (iFuente == cmbFuenteWebCam.SelectedIndex)
                return;

            iFuente = cmbFuenteWebCam.SelectedIndex;

            videoCapture.Stop();

            Application.Idle -= ProcessFrame;
            blnCapturingInProcess = false;
            Start.Text = " Resume ";
            videoCapture = new VideoCapture(cmbFuenteWebCam.SelectedIndex);
            Application.Idle += ProcessFrame;
            blnCapturingInProcess = true;
            Start.Text = " Pause ";
        }

        private void rdfFuente_CheckedChanged(object sender, EventArgs e)
        {
            cmbFuenteWebCam.Visible = rdbFuenteCam.Checked;
            grbFuenteRuta.Visible = rdbFuenteVideo.Checked || rdbFuenteFolder.Checked;

            if (rdbFuenteCam.Checked)
            {
                iFuente = -1;
                cmbFuenteWebCam_SelectedIndexChanged(null, null);
            }
            esAnteriorGris = false;
        }

        private void btnFuenteVideo_Click(object sender, EventArgs e)
        {
            if (rdbFuenteVideo.Checked && ofdFuenteVideo.ShowDialog() == DialogResult.OK)
            {
                this.txtFuenteVideo.Text = ofdFuenteVideo.FileName;
            }
            if (rdbFuenteFolder.Checked && fbdFuenteFolder.ShowDialog() == DialogResult.OK)
            {
                this.txtFuenteVideo.Text = fbdFuenteFolder.SelectedPath;
            }
        }

        private void btnFuenteVideoPlay_Click(object sender, EventArgs e)
        {
            if (rdbFuenteVideo.Checked && !System.IO.File.Exists(txtFuenteVideo.Text))
                return;
            if (rdbFuenteFolder.Checked && !System.IO.Directory.Exists(txtFuenteVideo.Text))
                return;

            videoCapture.Stop();

            Application.Idle -= ProcessFrame;
            blnCapturingInProcess = false;
            Start.Text = " Resume ";

            if (rdbFuenteVideo.Checked)
                videoCapture = new VideoCapture(txtFuenteVideo.Text);
            if (rdbFuenteFolder.Checked)
            {
                videoCapture = new VideoCapture(CaptureType.Images);
                string[] imgs = System.IO.Directory.GetFiles(txtFuenteVideo.Text, "*.jpg");

                foreach (string item in imgs)
                {
                    ProcessFrame(item, null);
                    this.Refresh();
                    //System.Threading.Thread.Sleep(2);
                }
                return;
            }
            //Image.FromFile

            Application.Idle += ProcessFrame;
            blnCapturingInProcess = true;
            Start.Text = " Pause ";


        }

        private void linkMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkMail.LinkVisited = true;
            System.Diagnostics.Process.Start("mailto:turing.ia.ihc@gmail.com");
        }
    }
}
