namespace BallTracker
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ImgOriginal = new Emgu.CV.UI.ImageBox();
            this.Start = new System.Windows.Forms.Button();
            this.imgResultado = new Emgu.CV.UI.ImageBox();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgHSV = new Emgu.CV.UI.ImageBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imgThreshLow = new Emgu.CV.UI.ImageBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.imgThreshHigh = new Emgu.CV.UI.ImageBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.imgSumados = new Emgu.CV.UI.ImageBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.imgGrises = new Emgu.CV.UI.ImageBox();
            this.cmbGrises = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.imgResultadoSolo = new Emgu.CV.UI.ImageBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.imgContraste = new Emgu.CV.UI.ImageBox();
            this.cmbContraste = new System.Windows.Forms.ComboBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.imgMovimiento = new Emgu.CV.UI.ImageBox();
            this.cmbMovimiento = new System.Windows.Forms.ComboBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.imgBordes = new Emgu.CV.UI.ImageBox();
            this.cmbBordes = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.grbFuenteRuta = new System.Windows.Forms.GroupBox();
            this.btnFuenteVideoPlay = new System.Windows.Forms.Button();
            this.txtFuenteVideo = new System.Windows.Forms.TextBox();
            this.btnFuenteVideo = new System.Windows.Forms.Button();
            this.cmbFuenteWebCam = new System.Windows.Forms.ComboBox();
            this.rdbFuenteFolder = new System.Windows.Forms.RadioButton();
            this.rdbFuenteVideo = new System.Windows.Forms.RadioButton();
            this.rdbFuenteCam = new System.Windows.Forms.RadioButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numUIB2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numUIG2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numUIR2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numUIB1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numUIG1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numUIR1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numUSB2 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numUSG2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numUSR2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numUSB1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numUSG1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numUSR1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.rdbTracking = new System.Windows.Forms.RadioButton();
            this.rdbBordes = new System.Windows.Forms.RadioButton();
            this.rdbHSV = new System.Windows.Forms.RadioButton();
            this.rdbOriginal = new System.Windows.Forms.RadioButton();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numRMax = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.numRMin = new System.Windows.Forms.NumericUpDown();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numRetraso = new System.Windows.Forms.NumericUpDown();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numBordSup = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numBordInf = new System.Windows.Forms.NumericUpDown();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.numVelSeguimiento = new System.Windows.Forms.NumericUpDown();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.numericBrillo = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.numericContrast = new System.Windows.Forms.NumericUpDown();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.ofdFuenteVideo = new System.Windows.Forms.OpenFileDialog();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.fbdFuenteFolder = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ImgOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgResultado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHSV)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgThreshLow)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgThreshHigh)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSumados)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGrises)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgResultadoSolo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgContraste)).BeginInit();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMovimiento)).BeginInit();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBordes)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.grbFuenteRuta.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUIB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUIG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUIR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUIB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUIG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUIR1)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUSB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUSG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUSR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUSB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUSG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUSR1)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRMin)).BeginInit();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRetraso)).BeginInit();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBordSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBordInf)).BeginInit();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVelSeguimiento)).BeginInit();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBrillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericContrast)).BeginInit();
            this.groupBox22.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgOriginal
            // 
            this.ImgOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgOriginal.Location = new System.Drawing.Point(3, 16);
            this.ImgOriginal.Name = "ImgOriginal";
            this.ImgOriginal.Size = new System.Drawing.Size(244, 231);
            this.ImgOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgOriginal.TabIndex = 2;
            this.ImgOriginal.TabStop = false;
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(685, 18);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Pause";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // imgResultado
            // 
            this.imgResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgResultado.Location = new System.Drawing.Point(3, 16);
            this.imgResultado.Name = "imgResultado";
            this.imgResultado.Size = new System.Drawing.Size(406, 0);
            this.imgResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgResultado.TabIndex = 2;
            this.imgResultado.TabStop = false;
            // 
            // txtResultados
            // 
            this.txtResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultados.Location = new System.Drawing.Point(12, 20);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultados.Size = new System.Drawing.Size(667, 64);
            this.txtResultados.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImgOriginal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgHSV);
            this.groupBox2.Location = new System.Drawing.Point(259, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 250);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HSV:";
            // 
            // imgHSV
            // 
            this.imgHSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgHSV.Location = new System.Drawing.Point(3, 16);
            this.imgHSV.Name = "imgHSV";
            this.imgHSV.Size = new System.Drawing.Size(244, 231);
            this.imgHSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHSV.TabIndex = 13;
            this.imgHSV.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.imgThreshLow);
            this.groupBox3.Location = new System.Drawing.Point(3, 515);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 250);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ThreshLow:";
            // 
            // imgThreshLow
            // 
            this.imgThreshLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgThreshLow.Location = new System.Drawing.Point(3, 16);
            this.imgThreshLow.Name = "imgThreshLow";
            this.imgThreshLow.Size = new System.Drawing.Size(244, 231);
            this.imgThreshLow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgThreshLow.TabIndex = 14;
            this.imgThreshLow.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.imgThreshHigh);
            this.groupBox4.Location = new System.Drawing.Point(259, 515);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 250);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ThreshHigh:";
            // 
            // imgThreshHigh
            // 
            this.imgThreshHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgThreshHigh.Location = new System.Drawing.Point(3, 16);
            this.imgThreshHigh.Name = "imgThreshHigh";
            this.imgThreshHigh.Size = new System.Drawing.Size(244, 231);
            this.imgThreshHigh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgThreshHigh.TabIndex = 14;
            this.imgThreshHigh.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.imgSumados);
            this.groupBox5.Location = new System.Drawing.Point(515, 515);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 250);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sumados:";
            // 
            // imgSumados
            // 
            this.imgSumados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgSumados.Location = new System.Drawing.Point(3, 16);
            this.imgSumados.Name = "imgSumados";
            this.imgSumados.Size = new System.Drawing.Size(244, 231);
            this.imgSumados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSumados.TabIndex = 14;
            this.imgSumados.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.imgGrises);
            this.groupBox6.Controls.Add(this.cmbGrises);
            this.groupBox6.Location = new System.Drawing.Point(3, 259);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(250, 250);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Grises:";
            // 
            // imgGrises
            // 
            this.imgGrises.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgGrises.Location = new System.Drawing.Point(3, 16);
            this.imgGrises.Name = "imgGrises";
            this.imgGrises.Size = new System.Drawing.Size(244, 210);
            this.imgGrises.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgGrises.TabIndex = 14;
            this.imgGrises.TabStop = false;
            // 
            // cmbGrises
            // 
            this.cmbGrises.DisplayMember = "Original";
            this.cmbGrises.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbGrises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrises.FormattingEnabled = true;
            this.cmbGrises.Items.AddRange(new object[] {
            "Original",
            "HSV",
            "Contraste y brillo"});
            this.cmbGrises.Location = new System.Drawing.Point(3, 226);
            this.cmbGrises.Name = "cmbGrises";
            this.cmbGrises.Size = new System.Drawing.Size(244, 21);
            this.cmbGrises.TabIndex = 15;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.splitter1);
            this.groupBox7.Controls.Add(this.imgResultado);
            this.groupBox7.Controls.Add(this.imgResultadoSolo);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(0, 517);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(772, 0);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resultado:";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(404, 16);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 0);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // imgResultadoSolo
            // 
            this.imgResultadoSolo.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgResultadoSolo.Location = new System.Drawing.Point(409, 16);
            this.imgResultadoSolo.Name = "imgResultadoSolo";
            this.imgResultadoSolo.Size = new System.Drawing.Size(360, 0);
            this.imgResultadoSolo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgResultadoSolo.TabIndex = 3;
            this.imgResultadoSolo.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox20);
            this.flowLayoutPanel1.Controls.Add(this.groupBox6);
            this.flowLayoutPanel1.Controls.Add(this.groupBox15);
            this.flowLayoutPanel1.Controls.Add(this.groupBox13);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(772, 512);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.imgContraste);
            this.groupBox20.Controls.Add(this.cmbContraste);
            this.groupBox20.Location = new System.Drawing.Point(515, 3);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(250, 250);
            this.groupBox20.TabIndex = 13;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Contraste :";
            // 
            // imgContraste
            // 
            this.imgContraste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgContraste.Location = new System.Drawing.Point(3, 16);
            this.imgContraste.Name = "imgContraste";
            this.imgContraste.Size = new System.Drawing.Size(244, 210);
            this.imgContraste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgContraste.TabIndex = 14;
            this.imgContraste.TabStop = false;
            // 
            // cmbContraste
            // 
            this.cmbContraste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbContraste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContraste.FormattingEnabled = true;
            this.cmbContraste.Items.AddRange(new object[] {
            "Original",
            "HSV"});
            this.cmbContraste.Location = new System.Drawing.Point(3, 226);
            this.cmbContraste.Name = "cmbContraste";
            this.cmbContraste.Size = new System.Drawing.Size(244, 21);
            this.cmbContraste.TabIndex = 16;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.imgMovimiento);
            this.groupBox15.Controls.Add(this.cmbMovimiento);
            this.groupBox15.Location = new System.Drawing.Point(259, 259);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(250, 250);
            this.groupBox15.TabIndex = 12;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Movimiento:";
            // 
            // imgMovimiento
            // 
            this.imgMovimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgMovimiento.Location = new System.Drawing.Point(3, 16);
            this.imgMovimiento.Name = "imgMovimiento";
            this.imgMovimiento.Size = new System.Drawing.Size(244, 210);
            this.imgMovimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMovimiento.TabIndex = 14;
            this.imgMovimiento.TabStop = false;
            // 
            // cmbMovimiento
            // 
            this.cmbMovimiento.DisplayMember = "Original";
            this.cmbMovimiento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovimiento.FormattingEnabled = true;
            this.cmbMovimiento.Items.AddRange(new object[] {
            "Original",
            "HSV",
            "Grises",
            "Contraste y brillo"});
            this.cmbMovimiento.Location = new System.Drawing.Point(3, 226);
            this.cmbMovimiento.Name = "cmbMovimiento";
            this.cmbMovimiento.Size = new System.Drawing.Size(244, 21);
            this.cmbMovimiento.TabIndex = 16;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.imgBordes);
            this.groupBox13.Controls.Add(this.cmbBordes);
            this.groupBox13.Location = new System.Drawing.Point(515, 259);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(250, 250);
            this.groupBox13.TabIndex = 11;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Bordes:";
            // 
            // imgBordes
            // 
            this.imgBordes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBordes.Location = new System.Drawing.Point(3, 16);
            this.imgBordes.Name = "imgBordes";
            this.imgBordes.Size = new System.Drawing.Size(244, 210);
            this.imgBordes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBordes.TabIndex = 14;
            this.imgBordes.TabStop = false;
            // 
            // cmbBordes
            // 
            this.cmbBordes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbBordes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBordes.FormattingEnabled = true;
            this.cmbBordes.Items.AddRange(new object[] {
            "Original",
            "HSV",
            "Grises",
            "Movimiento",
            "Contraste y brillo"});
            this.cmbBordes.Location = new System.Drawing.Point(3, 226);
            this.cmbBordes.Name = "cmbBordes";
            this.cmbBordes.Size = new System.Drawing.Size(244, 21);
            this.cmbBordes.TabIndex = 16;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtResultados);
            this.groupBox8.Controls.Add(this.Start);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox8.Location = new System.Drawing.Point(0, 507);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(772, 96);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.flowLayoutPanel2);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox9.Location = new System.Drawing.Point(772, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(516, 603);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Párametros";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.groupBox18);
            this.flowLayoutPanel2.Controls.Add(this.groupBox10);
            this.flowLayoutPanel2.Controls.Add(this.groupBox11);
            this.flowLayoutPanel2.Controls.Add(this.groupBox12);
            this.flowLayoutPanel2.Controls.Add(this.groupBox17);
            this.flowLayoutPanel2.Controls.Add(this.groupBox16);
            this.flowLayoutPanel2.Controls.Add(this.groupBox14);
            this.flowLayoutPanel2.Controls.Add(this.groupBox19);
            this.flowLayoutPanel2.Controls.Add(this.groupBox21);
            this.flowLayoutPanel2.Controls.Add(this.groupBox22);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(510, 584);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.grbFuenteRuta);
            this.groupBox18.Controls.Add(this.cmbFuenteWebCam);
            this.groupBox18.Controls.Add(this.rdbFuenteFolder);
            this.groupBox18.Controls.Add(this.rdbFuenteVideo);
            this.groupBox18.Controls.Add(this.rdbFuenteCam);
            this.groupBox18.Location = new System.Drawing.Point(3, 3);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(220, 80);
            this.groupBox18.TabIndex = 14;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Fuente del vídeo";
            // 
            // grbFuenteRuta
            // 
            this.grbFuenteRuta.Controls.Add(this.btnFuenteVideoPlay);
            this.grbFuenteRuta.Controls.Add(this.txtFuenteVideo);
            this.grbFuenteRuta.Controls.Add(this.btnFuenteVideo);
            this.grbFuenteRuta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbFuenteRuta.Location = new System.Drawing.Point(3, 16);
            this.grbFuenteRuta.Name = "grbFuenteRuta";
            this.grbFuenteRuta.Size = new System.Drawing.Size(214, 40);
            this.grbFuenteRuta.TabIndex = 18;
            this.grbFuenteRuta.TabStop = false;
            this.grbFuenteRuta.Text = "Ruta";
            // 
            // btnFuenteVideoPlay
            // 
            this.btnFuenteVideoPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFuenteVideoPlay.Location = new System.Drawing.Point(194, 16);
            this.btnFuenteVideoPlay.Name = "btnFuenteVideoPlay";
            this.btnFuenteVideoPlay.Size = new System.Drawing.Size(17, 23);
            this.btnFuenteVideoPlay.TabIndex = 2;
            this.btnFuenteVideoPlay.Text = "&>";
            this.btnFuenteVideoPlay.UseVisualStyleBackColor = true;
            this.btnFuenteVideoPlay.Click += new System.EventHandler(this.btnFuenteVideoPlay_Click);
            // 
            // txtFuenteVideo
            // 
            this.txtFuenteVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFuenteVideo.Location = new System.Drawing.Point(7, 18);
            this.txtFuenteVideo.Name = "txtFuenteVideo";
            this.txtFuenteVideo.Size = new System.Drawing.Size(123, 20);
            this.txtFuenteVideo.TabIndex = 0;
            // 
            // btnFuenteVideo
            // 
            this.btnFuenteVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFuenteVideo.Location = new System.Drawing.Point(131, 16);
            this.btnFuenteVideo.Name = "btnFuenteVideo";
            this.btnFuenteVideo.Size = new System.Drawing.Size(64, 23);
            this.btnFuenteVideo.TabIndex = 1;
            this.btnFuenteVideo.Text = "&Sel";
            this.btnFuenteVideo.UseVisualStyleBackColor = true;
            this.btnFuenteVideo.Click += new System.EventHandler(this.btnFuenteVideo_Click);
            // 
            // cmbFuenteWebCam
            // 
            this.cmbFuenteWebCam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbFuenteWebCam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuenteWebCam.FormattingEnabled = true;
            this.cmbFuenteWebCam.Location = new System.Drawing.Point(3, 56);
            this.cmbFuenteWebCam.Name = "cmbFuenteWebCam";
            this.cmbFuenteWebCam.Size = new System.Drawing.Size(214, 21);
            this.cmbFuenteWebCam.TabIndex = 17;
            this.cmbFuenteWebCam.SelectedIndexChanged += new System.EventHandler(this.cmbFuenteWebCam_SelectedIndexChanged);
            // 
            // rdbFuenteFolder
            // 
            this.rdbFuenteFolder.AutoSize = true;
            this.rdbFuenteFolder.Location = new System.Drawing.Point(135, 19);
            this.rdbFuenteFolder.Name = "rdbFuenteFolder";
            this.rdbFuenteFolder.Size = new System.Drawing.Size(79, 17);
            this.rdbFuenteFolder.TabIndex = 4;
            this.rdbFuenteFolder.Text = "Folder Imgs";
            this.rdbFuenteFolder.UseVisualStyleBackColor = true;
            this.rdbFuenteFolder.CheckedChanged += new System.EventHandler(this.rdfFuente_CheckedChanged);
            // 
            // rdbFuenteVideo
            // 
            this.rdbFuenteVideo.AutoSize = true;
            this.rdbFuenteVideo.Location = new System.Drawing.Point(78, 20);
            this.rdbFuenteVideo.Name = "rdbFuenteVideo";
            this.rdbFuenteVideo.Size = new System.Drawing.Size(54, 17);
            this.rdbFuenteVideo.TabIndex = 3;
            this.rdbFuenteVideo.Text = "Vídeo";
            this.rdbFuenteVideo.UseVisualStyleBackColor = true;
            this.rdbFuenteVideo.CheckedChanged += new System.EventHandler(this.rdfFuente_CheckedChanged);
            // 
            // rdbFuenteCam
            // 
            this.rdbFuenteCam.AutoSize = true;
            this.rdbFuenteCam.Checked = true;
            this.rdbFuenteCam.Location = new System.Drawing.Point(9, 20);
            this.rdbFuenteCam.Name = "rdbFuenteCam";
            this.rdbFuenteCam.Size = new System.Drawing.Size(69, 17);
            this.rdbFuenteCam.TabIndex = 0;
            this.rdbFuenteCam.TabStop = true;
            this.rdbFuenteCam.Text = "WebCam";
            this.rdbFuenteCam.UseVisualStyleBackColor = true;
            this.rdbFuenteCam.CheckedChanged += new System.EventHandler(this.rdfFuente_CheckedChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.numUIB2);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Controls.Add(this.numUIG2);
            this.groupBox10.Controls.Add(this.label9);
            this.groupBox10.Controls.Add(this.numUIR2);
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.numUIB1);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.numUIG1);
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.numUIR1);
            this.groupBox10.Location = new System.Drawing.Point(229, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(221, 80);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Umbral Inferior";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "B:";
            // 
            // numUIB2
            // 
            this.numUIB2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUIB2.Location = new System.Drawing.Point(163, 45);
            this.numUIB2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUIB2.Name = "numUIB2";
            this.numUIB2.Size = new System.Drawing.Size(41, 20);
            this.numUIB2.TabIndex = 5;
            this.numUIB2.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "G:";
            // 
            // numUIG2
            // 
            this.numUIG2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUIG2.Location = new System.Drawing.Point(95, 45);
            this.numUIG2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUIG2.Name = "numUIG2";
            this.numUIG2.Size = new System.Drawing.Size(41, 20);
            this.numUIG2.TabIndex = 4;
            this.numUIG2.Value = new decimal(new int[] {
            105,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "R:";
            // 
            // numUIR2
            // 
            this.numUIR2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUIR2.Location = new System.Drawing.Point(27, 45);
            this.numUIR2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUIR2.Name = "numUIR2";
            this.numUIR2.Size = new System.Drawing.Size(41, 20);
            this.numUIR2.TabIndex = 3;
            this.numUIR2.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "B:";
            // 
            // numUIB1
            // 
            this.numUIB1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUIB1.Location = new System.Drawing.Point(163, 19);
            this.numUIB1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUIB1.Name = "numUIB1";
            this.numUIB1.Size = new System.Drawing.Size(41, 20);
            this.numUIB1.TabIndex = 2;
            this.numUIB1.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "G:";
            // 
            // numUIG1
            // 
            this.numUIG1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUIG1.Location = new System.Drawing.Point(95, 19);
            this.numUIG1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUIG1.Name = "numUIG1";
            this.numUIG1.Size = new System.Drawing.Size(41, 20);
            this.numUIG1.TabIndex = 1;
            this.numUIG1.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "R:";
            // 
            // numUIR1
            // 
            this.numUIR1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUIR1.Location = new System.Drawing.Point(27, 19);
            this.numUIR1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUIR1.Name = "numUIR1";
            this.numUIR1.Size = new System.Drawing.Size(41, 20);
            this.numUIR1.TabIndex = 0;
            this.numUIR1.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.label10);
            this.groupBox11.Controls.Add(this.numUSB2);
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Controls.Add(this.numUSG2);
            this.groupBox11.Controls.Add(this.label12);
            this.groupBox11.Controls.Add(this.numUSR2);
            this.groupBox11.Controls.Add(this.label4);
            this.groupBox11.Controls.Add(this.numUSB1);
            this.groupBox11.Controls.Add(this.label5);
            this.groupBox11.Controls.Add(this.numUSG1);
            this.groupBox11.Controls.Add(this.label6);
            this.groupBox11.Controls.Add(this.numUSR1);
            this.groupBox11.Location = new System.Drawing.Point(3, 89);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(221, 80);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Umbral Superior";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "B:";
            // 
            // numUSB2
            // 
            this.numUSB2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUSB2.Location = new System.Drawing.Point(163, 45);
            this.numUSB2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUSB2.Name = "numUSB2";
            this.numUSB2.Size = new System.Drawing.Size(41, 20);
            this.numUSB2.TabIndex = 5;
            this.numUSB2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "G:";
            // 
            // numUSG2
            // 
            this.numUSG2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUSG2.Location = new System.Drawing.Point(95, 45);
            this.numUSG2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUSG2.Name = "numUSG2";
            this.numUSG2.Size = new System.Drawing.Size(41, 20);
            this.numUSG2.TabIndex = 4;
            this.numUSG2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "R:";
            // 
            // numUSR2
            // 
            this.numUSR2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUSR2.Location = new System.Drawing.Point(27, 45);
            this.numUSR2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUSR2.Name = "numUSR2";
            this.numUSR2.Size = new System.Drawing.Size(41, 20);
            this.numUSR2.TabIndex = 3;
            this.numUSR2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "B:";
            // 
            // numUSB1
            // 
            this.numUSB1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUSB1.Location = new System.Drawing.Point(163, 19);
            this.numUSB1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUSB1.Name = "numUSB1";
            this.numUSB1.Size = new System.Drawing.Size(41, 20);
            this.numUSB1.TabIndex = 2;
            this.numUSB1.Value = new decimal(new int[] {
            230,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "G:";
            // 
            // numUSG1
            // 
            this.numUSG1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUSG1.Location = new System.Drawing.Point(95, 19);
            this.numUSG1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUSG1.Name = "numUSG1";
            this.numUSG1.Size = new System.Drawing.Size(41, 20);
            this.numUSG1.TabIndex = 1;
            this.numUSG1.Value = new decimal(new int[] {
            175,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "R:";
            // 
            // numUSR1
            // 
            this.numUSR1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUSR1.Location = new System.Drawing.Point(27, 19);
            this.numUSR1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUSR1.Name = "numUSR1";
            this.numUSR1.Size = new System.Drawing.Size(41, 20);
            this.numUSR1.TabIndex = 0;
            this.numUSR1.Value = new decimal(new int[] {
            190,
            0,
            0,
            0});
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.rdbTracking);
            this.groupBox12.Controls.Add(this.rdbBordes);
            this.groupBox12.Controls.Add(this.rdbHSV);
            this.groupBox12.Controls.Add(this.rdbOriginal);
            this.groupBox12.Location = new System.Drawing.Point(230, 89);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(220, 80);
            this.groupBox12.TabIndex = 13;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Fuente para detección";
            // 
            // rdbTracking
            // 
            this.rdbTracking.AutoSize = true;
            this.rdbTracking.Location = new System.Drawing.Point(75, 20);
            this.rdbTracking.Name = "rdbTracking";
            this.rdbTracking.Size = new System.Drawing.Size(67, 17);
            this.rdbTracking.TabIndex = 3;
            this.rdbTracking.Text = "Tracking";
            this.rdbTracking.UseVisualStyleBackColor = true;
            // 
            // rdbBordes
            // 
            this.rdbBordes.AutoSize = true;
            this.rdbBordes.Checked = true;
            this.rdbBordes.Location = new System.Drawing.Point(75, 43);
            this.rdbBordes.Name = "rdbBordes";
            this.rdbBordes.Size = new System.Drawing.Size(58, 17);
            this.rdbBordes.TabIndex = 2;
            this.rdbBordes.TabStop = true;
            this.rdbBordes.Text = "Bordes";
            this.rdbBordes.UseVisualStyleBackColor = true;
            // 
            // rdbHSV
            // 
            this.rdbHSV.AutoSize = true;
            this.rdbHSV.Location = new System.Drawing.Point(9, 43);
            this.rdbHSV.Name = "rdbHSV";
            this.rdbHSV.Size = new System.Drawing.Size(47, 17);
            this.rdbHSV.TabIndex = 1;
            this.rdbHSV.Text = "HSV";
            this.rdbHSV.UseVisualStyleBackColor = true;
            // 
            // rdbOriginal
            // 
            this.rdbOriginal.AutoSize = true;
            this.rdbOriginal.Location = new System.Drawing.Point(9, 20);
            this.rdbOriginal.Name = "rdbOriginal";
            this.rdbOriginal.Size = new System.Drawing.Size(60, 17);
            this.rdbOriginal.TabIndex = 0;
            this.rdbOriginal.Text = "Original";
            this.rdbOriginal.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.label15);
            this.groupBox17.Controls.Add(this.numRMax);
            this.groupBox17.Controls.Add(this.label17);
            this.groupBox17.Controls.Add(this.numRMin);
            this.groupBox17.Location = new System.Drawing.Point(3, 175);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(221, 80);
            this.groupBox17.TabIndex = 15;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Párametros circunferencia";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(119, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "R Max:";
            // 
            // numRMax
            // 
            this.numRMax.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRMax.Location = new System.Drawing.Point(163, 19);
            this.numRMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRMax.Name = "numRMax";
            this.numRMax.Size = new System.Drawing.Size(41, 20);
            this.numRMax.TabIndex = 5;
            this.numRMax.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "R Min:";
            // 
            // numRMin
            // 
            this.numRMin.Location = new System.Drawing.Point(49, 19);
            this.numRMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRMin.Name = "numRMin";
            this.numRMin.Size = new System.Drawing.Size(43, 20);
            this.numRMin.TabIndex = 4;
            this.numRMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label16);
            this.groupBox16.Controls.Add(this.numRetraso);
            this.groupBox16.Location = new System.Drawing.Point(230, 175);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(221, 80);
            this.groupBox16.TabIndex = 15;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "FPS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Retraso:";
            // 
            // numRetraso
            // 
            this.numRetraso.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numRetraso.Location = new System.Drawing.Point(72, 19);
            this.numRetraso.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRetraso.Name = "numRetraso";
            this.numRetraso.Size = new System.Drawing.Size(64, 20);
            this.numRetraso.TabIndex = 4;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label13);
            this.groupBox14.Controls.Add(this.numBordSup);
            this.groupBox14.Controls.Add(this.label14);
            this.groupBox14.Controls.Add(this.numBordInf);
            this.groupBox14.Location = new System.Drawing.Point(3, 261);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(221, 80);
            this.groupBox14.TabIndex = 14;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Bordes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(119, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "S:";
            // 
            // numBordSup
            // 
            this.numBordSup.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBordSup.Location = new System.Drawing.Point(145, 19);
            this.numBordSup.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBordSup.Name = "numBordSup";
            this.numBordSup.Size = new System.Drawing.Size(59, 20);
            this.numBordSup.TabIndex = 5;
            this.numBordSup.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "I:";
            // 
            // numBordInf
            // 
            this.numBordInf.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBordInf.Location = new System.Drawing.Point(28, 19);
            this.numBordInf.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBordInf.Name = "numBordInf";
            this.numBordInf.Size = new System.Drawing.Size(64, 20);
            this.numBordInf.TabIndex = 4;
            this.numBordInf.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.label19);
            this.groupBox19.Controls.Add(this.numVelSeguimiento);
            this.groupBox19.Location = new System.Drawing.Point(230, 261);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(221, 80);
            this.groupBox19.TabIndex = 16;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Velocidad seguimiento";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "Distancia pixeles:";
            // 
            // numVelSeguimiento
            // 
            this.numVelSeguimiento.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numVelSeguimiento.Location = new System.Drawing.Point(139, 21);
            this.numVelSeguimiento.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numVelSeguimiento.Name = "numVelSeguimiento";
            this.numVelSeguimiento.Size = new System.Drawing.Size(64, 20);
            this.numVelSeguimiento.TabIndex = 4;
            this.numVelSeguimiento.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.label18);
            this.groupBox21.Controls.Add(this.numericBrillo);
            this.groupBox21.Controls.Add(this.label20);
            this.groupBox21.Controls.Add(this.numericContrast);
            this.groupBox21.Location = new System.Drawing.Point(3, 347);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(221, 80);
            this.groupBox21.TabIndex = 17;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Contraste";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Brillo:";
            // 
            // numericBrillo
            // 
            this.numericBrillo.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericBrillo.Location = new System.Drawing.Point(68, 45);
            this.numericBrillo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericBrillo.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericBrillo.Name = "numericBrillo";
            this.numericBrillo.Size = new System.Drawing.Size(64, 20);
            this.numericBrillo.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Contraste:";
            // 
            // numericContrast
            // 
            this.numericContrast.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericContrast.Location = new System.Drawing.Point(68, 19);
            this.numericContrast.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericContrast.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericContrast.Name = "numericContrast";
            this.numericContrast.Size = new System.Drawing.Size(64, 20);
            this.numericContrast.TabIndex = 4;
            this.numericContrast.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.label26);
            this.groupBox22.Controls.Add(this.label25);
            this.groupBox22.Controls.Add(this.label24);
            this.groupBox22.Controls.Add(this.label23);
            this.groupBox22.Controls.Add(this.label21);
            this.groupBox22.Controls.Add(this.label22);
            this.groupBox22.Location = new System.Drawing.Point(230, 347);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(221, 80);
            this.groupBox22.TabIndex = 18;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "HSV";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(29, 63);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(145, 13);
            this.label26.TabIndex = 11;
            this.label26.Text = "Brightness (Brillo) Color (Rojo)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(29, 42);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(176, 13);
            this.label25.TabIndex = 10;
            this.label25.Text = "Saturation (Saturación) Color(Verde)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(29, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(117, 13);
            this.label24.TabIndex = 9;
            this.label24.Text = "Hue (Matiz) Color (Azul)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 63);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "V:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 42);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "S:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "H:";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 512);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(772, 5);
            this.splitter2.TabIndex = 15;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter3.Location = new System.Drawing.Point(767, 517);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(5, 0);
            this.splitter3.TabIndex = 18;
            this.splitter3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 603);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgResultado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHSV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgThreshLow)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgThreshHigh)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSumados)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgGrises)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgResultadoSolo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgContraste)).EndInit();
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgMovimiento)).EndInit();
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBordes)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.grbFuenteRuta.ResumeLayout(false);
            this.grbFuenteRuta.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUIB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUIG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUIR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUIB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUIG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUIR1)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUSB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUSG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUSR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUSB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUSG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUSR1)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRMin)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRetraso)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBordSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBordInf)).EndInit();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVelSeguimiento)).EndInit();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBrillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericContrast)).EndInit();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox ImgOriginal;
        private System.Windows.Forms.Button Start;
        private Emgu.CV.UI.ImageBox imgResultado;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Emgu.CV.UI.ImageBox imgHSV;
        private Emgu.CV.UI.ImageBox imgThreshLow;
        private Emgu.CV.UI.ImageBox imgThreshHigh;
        private Emgu.CV.UI.ImageBox imgSumados;
        private Emgu.CV.UI.ImageBox imgGrises;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.NumericUpDown numUIR1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUIB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUIG1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUSB1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numUSG1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numUSR1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numUIB2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numUIG2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numUIR2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numUSB2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numUSG2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numUSR2;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.RadioButton rdbHSV;
        private System.Windows.Forms.RadioButton rdbOriginal;
        private System.Windows.Forms.GroupBox groupBox13;
        private Emgu.CV.UI.ImageBox imgBordes;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numBordSup;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numBordInf;
        private System.Windows.Forms.RadioButton rdbBordes;
        private System.Windows.Forms.GroupBox groupBox15;
        private Emgu.CV.UI.ImageBox imgMovimiento;
        private System.Windows.Forms.RadioButton rdbTracking;
        private System.Windows.Forms.ComboBox cmbGrises;
        private System.Windows.Forms.ComboBox cmbBordes;
        private System.Windows.Forms.ComboBox cmbMovimiento;
        private Emgu.CV.UI.ImageBox imgResultadoSolo;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numRetraso;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numRMax;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numRMin;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.RadioButton rdbFuenteFolder;
        private System.Windows.Forms.RadioButton rdbFuenteVideo;
        private System.Windows.Forms.RadioButton rdbFuenteCam;
        private System.Windows.Forms.ComboBox cmbFuenteWebCam;
        private System.Windows.Forms.GroupBox grbFuenteRuta;
        private System.Windows.Forms.Button btnFuenteVideo;
        private System.Windows.Forms.TextBox txtFuenteVideo;
        private System.Windows.Forms.OpenFileDialog ofdFuenteVideo;
        private System.Windows.Forms.Button btnFuenteVideoPlay;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.FolderBrowserDialog fbdFuenteFolder;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numVelSeguimiento;
        private System.Windows.Forms.GroupBox groupBox20;
        private Emgu.CV.UI.ImageBox imgContraste;
        private System.Windows.Forms.ComboBox cmbContraste;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numericBrillo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown numericContrast;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
    }
}

