namespace LedMatrixDemoInterfaceNamespace
{
    partial class DisplayForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayForm));
            this.pbtDisplayCtrl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbtResetposTx1 = new System.Windows.Forms.Button();
            this.nudXposTx1 = new System.Windows.Forms.NumericUpDown();
            this.nudYposTx1 = new System.Windows.Forms.NumericUpDown();
            this.tbxTx1 = new System.Windows.Forms.TextBox();
            this.cbxSpeedTx1 = new System.Windows.Forms.ComboBox();
            this.cbxDirectionTx1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.nudLedSize = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxDisplayLedStyle = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudDisplayNbRow = new System.Windows.Forms.NumericUpDown();
            this.nudDisplayNbLine = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDisplayPeriod = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pbtDisplayLedOff = new System.Windows.Forms.Button();
            this.pbtDisplayLedOn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Label();
            this.pbtHide = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pbtResetposTx2 = new System.Windows.Forms.Button();
            this.nudXposTx2 = new System.Windows.Forms.NumericUpDown();
            this.nudYposTx2 = new System.Windows.Forms.NumericUpDown();
            this.tbxTx2 = new System.Windows.Forms.TextBox();
            this.cbxSpeedTx2 = new System.Windows.Forms.ComboBox();
            this.cbxDirectionTx2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ledMatrixControl = new LedMatrixControlNamespace.LedMatrixControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXposTx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYposTx1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLedSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDisplayNbRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDisplayNbLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDisplayPeriod)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXposTx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYposTx2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbtDisplayCtrl
            // 
            this.pbtDisplayCtrl.Location = new System.Drawing.Point(85, 13);
            this.pbtDisplayCtrl.Name = "pbtDisplayCtrl";
            this.pbtDisplayCtrl.Size = new System.Drawing.Size(75, 23);
            this.pbtDisplayCtrl.TabIndex = 1;
            this.pbtDisplayCtrl.Text = "button1";
            this.pbtDisplayCtrl.UseVisualStyleBackColor = true;
            this.pbtDisplayCtrl.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pbtResetposTx1);
            this.groupBox1.Controls.Add(this.nudXposTx1);
            this.groupBox1.Controls.Add(this.nudYposTx1);
            this.groupBox1.Controls.Add(this.tbxTx1);
            this.groupBox1.Controls.Add(this.cbxSpeedTx1);
            this.groupBox1.Controls.Add(this.cbxDirectionTx1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(358, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Texto 01";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Pos Y :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Pos X :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pbtResetposTx1
            // 
            this.pbtResetposTx1.Location = new System.Drawing.Point(166, 66);
            this.pbtResetposTx1.Name = "pbtResetposTx1";
            this.pbtResetposTx1.Size = new System.Drawing.Size(106, 43);
            this.pbtResetposTx1.TabIndex = 8;
            this.pbtResetposTx1.Text = "Reset";
            this.pbtResetposTx1.UseVisualStyleBackColor = true;
            this.pbtResetposTx1.Click += new System.EventHandler(this.pbtResetposTx1_Click);
            // 
            // nudXposTx1
            // 
            this.nudXposTx1.Location = new System.Drawing.Point(70, 66);
            this.nudXposTx1.Name = "nudXposTx1";
            this.nudXposTx1.Size = new System.Drawing.Size(72, 20);
            this.nudXposTx1.TabIndex = 7;
            // 
            // nudYposTx1
            // 
            this.nudYposTx1.Location = new System.Drawing.Point(70, 89);
            this.nudYposTx1.Name = "nudYposTx1";
            this.nudYposTx1.Size = new System.Drawing.Size(72, 20);
            this.nudYposTx1.TabIndex = 6;
            // 
            // tbxTx1
            // 
            this.tbxTx1.Location = new System.Drawing.Point(70, 13);
            this.tbxTx1.Name = "tbxTx1";
            this.tbxTx1.Size = new System.Drawing.Size(202, 20);
            this.tbxTx1.TabIndex = 5;
            this.tbxTx1.Text = "SEU TEXTO AQUI";
            this.tbxTx1.TextChanged += new System.EventHandler(this.tbxTx1_TextChanged);
            // 
            // cbxSpeedTx1
            // 
            this.cbxSpeedTx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSpeedTx1.FormattingEnabled = true;
            this.cbxSpeedTx1.Items.AddRange(new object[] {
            "Lento",
            "Normal",
            "Rapido"});
            this.cbxSpeedTx1.Location = new System.Drawing.Point(207, 39);
            this.cbxSpeedTx1.Name = "cbxSpeedTx1";
            this.cbxSpeedTx1.Size = new System.Drawing.Size(65, 21);
            this.cbxSpeedTx1.TabIndex = 4;
            this.cbxSpeedTx1.SelectedIndexChanged += new System.EventHandler(this.cbxSpeedTx1_SelectedIndexChanged);
            // 
            // cbxDirectionTx1
            // 
            this.cbxDirectionTx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDirectionTx1.FormattingEnabled = true;
            this.cbxDirectionTx1.Items.AddRange(new object[] {
            "Direita",
            "Esquerda",
            "Cima",
            "Baixo"});
            this.cbxDirectionTx1.Location = new System.Drawing.Point(70, 39);
            this.cbxDirectionTx1.Name = "cbxDirectionTx1";
            this.cbxDirectionTx1.Size = new System.Drawing.Size(72, 21);
            this.cbxDirectionTx1.TabIndex = 3;
            this.cbxDirectionTx1.SelectedIndexChanged += new System.EventHandler(this.cbxDirectionTx1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Veloc. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direção : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.nudLedSize);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbxDisplayLedStyle);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nudDisplayNbRow);
            this.groupBox2.Controls.Add(this.nudDisplayNbLine);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudDisplayPeriod);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pbtDisplayCtrl);
            this.groupBox2.Controls.Add(this.pbtDisplayLedOff);
            this.groupBox2.Controls.Add(this.pbtDisplayLedOn);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(173, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Led size coeff :";
            // 
            // nudLedSize
            // 
            this.nudLedSize.DecimalPlaces = 2;
            this.nudLedSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudLedSize.Location = new System.Drawing.Point(258, 97);
            this.nudLedSize.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLedSize.Name = "nudLedSize";
            this.nudLedSize.Size = new System.Drawing.Size(75, 20);
            this.nudLedSize.TabIndex = 14;
            this.nudLedSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLedSize.ValueChanged += new System.EventHandler(this.nudLedSize_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Led estilo :";
            // 
            // cbxDisplayLedStyle
            // 
            this.cbxDisplayLedStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDisplayLedStyle.FormattingEnabled = true;
            this.cbxDisplayLedStyle.Items.AddRange(new object[] {
            "Circular",
            "Quadrado"});
            this.cbxDisplayLedStyle.Location = new System.Drawing.Point(88, 97);
            this.cbxDisplayLedStyle.Name = "cbxDisplayLedStyle";
            this.cbxDisplayLedStyle.Size = new System.Drawing.Size(72, 21);
            this.cbxDisplayLedStyle.TabIndex = 12;
            this.cbxDisplayLedStyle.SelectedIndexChanged += new System.EventHandler(this.cbxDisplayLedStyle_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "N° Colunas :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "N° linhas :";
            // 
            // nudDisplayNbRow
            // 
            this.nudDisplayNbRow.Location = new System.Drawing.Point(258, 71);
            this.nudDisplayNbRow.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDisplayNbRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDisplayNbRow.Name = "nudDisplayNbRow";
            this.nudDisplayNbRow.Size = new System.Drawing.Size(75, 20);
            this.nudDisplayNbRow.TabIndex = 9;
            this.nudDisplayNbRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDisplayNbRow.ValueChanged += new System.EventHandler(this.nudDisplayNbRow_ValueChanged);
            // 
            // nudDisplayNbLine
            // 
            this.nudDisplayNbLine.Location = new System.Drawing.Point(88, 71);
            this.nudDisplayNbLine.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDisplayNbLine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDisplayNbLine.Name = "nudDisplayNbLine";
            this.nudDisplayNbLine.Size = new System.Drawing.Size(72, 20);
            this.nudDisplayNbLine.TabIndex = 8;
            this.nudDisplayNbLine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDisplayNbLine.ValueChanged += new System.EventHandler(this.nudDisplayNbLine_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Controle : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Led Off cor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Led On cor :";
            // 
            // nudDisplayPeriod
            // 
            this.nudDisplayPeriod.Location = new System.Drawing.Point(258, 16);
            this.nudDisplayPeriod.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDisplayPeriod.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudDisplayPeriod.Name = "nudDisplayPeriod";
            this.nudDisplayPeriod.Size = new System.Drawing.Size(75, 20);
            this.nudDisplayPeriod.TabIndex = 0;
            this.nudDisplayPeriod.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tempo :";
            // 
            // pbtDisplayLedOff
            // 
            this.pbtDisplayLedOff.Location = new System.Drawing.Point(258, 42);
            this.pbtDisplayLedOff.Name = "pbtDisplayLedOff";
            this.pbtDisplayLedOff.Size = new System.Drawing.Size(75, 23);
            this.pbtDisplayLedOff.TabIndex = 2;
            this.pbtDisplayLedOff.UseVisualStyleBackColor = true;
            this.pbtDisplayLedOff.Click += new System.EventHandler(this.pbtDisplayLedOff_Click);
            // 
            // pbtDisplayLedOn
            // 
            this.pbtDisplayLedOn.Location = new System.Drawing.Point(85, 42);
            this.pbtDisplayLedOn.Name = "pbtDisplayLedOn";
            this.pbtDisplayLedOn.Size = new System.Drawing.Size(75, 23);
            this.pbtDisplayLedOn.TabIndex = 1;
            this.pbtDisplayLedOn.UseVisualStyleBackColor = true;
            this.pbtDisplayLedOn.Click += new System.EventHandler(this.pbtDisplayLedOn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.sec);
            this.panel1.Controls.Add(this.pbtHide);
            this.panel1.Controls.Add(this.Hide);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.MinimumSize = new System.Drawing.Size(1034, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 152);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Green;
            this.label19.Location = new System.Drawing.Point(1156, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 91);
            this.label19.TabIndex = 14;
            this.label19.Text = ":";
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec.ForeColor = System.Drawing.Color.Green;
            this.sec.Location = new System.Drawing.Point(1189, 34);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(129, 91);
            this.sec.TabIndex = 13;
            this.sec.Text = "00";
            // 
            // pbtHide
            // 
            this.pbtHide.Location = new System.Drawing.Point(1231, 6);
            this.pbtHide.Name = "pbtHide";
            this.pbtHide.Size = new System.Drawing.Size(75, 23);
            this.pbtHide.TabIndex = 12;
            this.pbtHide.Text = "Ocultar";
            this.pbtHide.UseVisualStyleBackColor = true;
            this.pbtHide.Click += new System.EventHandler(this.pbtHide_Click_1);
            // 
            // Hide
            // 
            this.Hide.AutoSize = true;
            this.Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hide.ForeColor = System.Drawing.Color.Green;
            this.Hide.Location = new System.Drawing.Point(941, 34);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(242, 91);
            this.Hide.TabIndex = 11;
            this.Hide.Text = "00:00";
            this.Hide.Click += new System.EventHandler(this.lbl_hora_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.pbtResetposTx2);
            this.groupBox3.Controls.Add(this.nudXposTx2);
            this.groupBox3.Controls.Add(this.nudYposTx2);
            this.groupBox3.Controls.Add(this.tbxTx2);
            this.groupBox3.Controls.Add(this.cbxSpeedTx2);
            this.groupBox3.Controls.Add(this.cbxDirectionTx2);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(654, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 130);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Texto 02";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Pos Y :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Pos X :";
            // 
            // pbtResetposTx2
            // 
            this.pbtResetposTx2.Location = new System.Drawing.Point(166, 66);
            this.pbtResetposTx2.Name = "pbtResetposTx2";
            this.pbtResetposTx2.Size = new System.Drawing.Size(106, 43);
            this.pbtResetposTx2.TabIndex = 8;
            this.pbtResetposTx2.Text = "Reset";
            this.pbtResetposTx2.UseVisualStyleBackColor = true;
            this.pbtResetposTx2.Click += new System.EventHandler(this.pbtResetposTx2_Click);
            // 
            // nudXposTx2
            // 
            this.nudXposTx2.Location = new System.Drawing.Point(70, 66);
            this.nudXposTx2.Name = "nudXposTx2";
            this.nudXposTx2.Size = new System.Drawing.Size(72, 20);
            this.nudXposTx2.TabIndex = 7;
            this.nudXposTx2.ValueChanged += new System.EventHandler(this.nudXposTx2_ValueChanged);
            // 
            // nudYposTx2
            // 
            this.nudYposTx2.Location = new System.Drawing.Point(70, 89);
            this.nudYposTx2.Name = "nudYposTx2";
            this.nudYposTx2.Size = new System.Drawing.Size(72, 20);
            this.nudYposTx2.TabIndex = 6;
            this.nudYposTx2.ValueChanged += new System.EventHandler(this.nudYposTx2_ValueChanged);
            // 
            // tbxTx2
            // 
            this.tbxTx2.Location = new System.Drawing.Point(70, 13);
            this.tbxTx2.Name = "tbxTx2";
            this.tbxTx2.Size = new System.Drawing.Size(202, 20);
            this.tbxTx2.TabIndex = 5;
            this.tbxTx2.TextChanged += new System.EventHandler(this.tbxTx2_TextChanged);
            // 
            // cbxSpeedTx2
            // 
            this.cbxSpeedTx2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSpeedTx2.FormattingEnabled = true;
            this.cbxSpeedTx2.Items.AddRange(new object[] {
            "Lento",
            "Normal",
            "Rapido"});
            this.cbxSpeedTx2.Location = new System.Drawing.Point(207, 39);
            this.cbxSpeedTx2.Name = "cbxSpeedTx2";
            this.cbxSpeedTx2.Size = new System.Drawing.Size(65, 21);
            this.cbxSpeedTx2.TabIndex = 4;
            this.cbxSpeedTx2.SelectedIndexChanged += new System.EventHandler(this.cbxSpeedTx2_SelectedIndexChanged);
            // 
            // cbxDirectionTx2
            // 
            this.cbxDirectionTx2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDirectionTx2.FormattingEnabled = true;
            this.cbxDirectionTx2.Items.AddRange(new object[] {
            "Direita",
            "Esquerda",
            "Cima",
            "Baixo"});
            this.cbxDirectionTx2.Location = new System.Drawing.Point(70, 39);
            this.cbxDirectionTx2.Name = "cbxDirectionTx2";
            this.cbxDirectionTx2.Size = new System.Drawing.Size(72, 21);
            this.cbxDirectionTx2.TabIndex = 3;
            this.cbxDirectionTx2.SelectedIndexChanged += new System.EventHandler(this.cbxDirectionTx2_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(163, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Veloc. :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Direção : ";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Text :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ledMatrixControl
            // 
            this.ledMatrixControl.BackColor = System.Drawing.Color.Black;
            this.ledMatrixControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ledMatrixControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledMatrixControl.LedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ledMatrixControl.LedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ledMatrixControl.Location = new System.Drawing.Point(0, 0);
            this.ledMatrixControl.Name = "ledMatrixControl";
            this.ledMatrixControl.NbLedLines = 40;
            this.ledMatrixControl.NbLedRows = 174;
            this.ledMatrixControl.Size = new System.Drawing.Size(1309, 416);
            this.ledMatrixControl.SizeCoeff = 0.67D;
            this.ledMatrixControl.TabIndex = 2;
            this.ledMatrixControl.Text = "ledMatrixControl";
            this.ledMatrixControl.Click += new System.EventHandler(this.ledMatrixControl_Click);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1309, 568);
            this.Controls.Add(this.ledMatrixControl);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(476, 39);
            this.Name = "DisplayForm";
            this.Text = "PAINEL DE INFORMAÇOES";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXposTx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYposTx1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLedSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDisplayNbRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDisplayNbLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDisplayPeriod)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXposTx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYposTx2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

      private System.Windows.Forms.Button pbtDisplayCtrl;
      private LedMatrixControlNamespace.LedMatrixControl ledMatrixControl;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.ComboBox cbxSpeedTx1;
      private System.Windows.Forms.ComboBox cbxDirectionTx1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox tbxTx1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Button pbtResetposTx1;
      private System.Windows.Forms.NumericUpDown nudXposTx1;
      private System.Windows.Forms.NumericUpDown nudYposTx1;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button pbtDisplayLedOff;
      private System.Windows.Forms.Button pbtDisplayLedOn;
      private System.Windows.Forms.NumericUpDown nudDisplayPeriod;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.NumericUpDown nudDisplayNbRow;
      private System.Windows.Forms.NumericUpDown nudDisplayNbLine;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.ComboBox cbxDisplayLedStyle;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.Label label14;
      private System.Windows.Forms.Button pbtResetposTx2;
      private System.Windows.Forms.NumericUpDown nudXposTx2;
      private System.Windows.Forms.NumericUpDown nudYposTx2;
      private System.Windows.Forms.TextBox tbxTx2;
      private System.Windows.Forms.ComboBox cbxSpeedTx2;
      private System.Windows.Forms.ComboBox cbxDirectionTx2;
      private System.Windows.Forms.Label label15;
      private System.Windows.Forms.Label label16;
      private System.Windows.Forms.Label label17;
      private System.Windows.Forms.Label label18;
      private System.Windows.Forms.NumericUpDown nudLedSize;
        private System.Windows.Forms.Label Hide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button pbtHide;
        private System.Windows.Forms.Label sec;
        private System.Windows.Forms.Label label19;
    }
}

