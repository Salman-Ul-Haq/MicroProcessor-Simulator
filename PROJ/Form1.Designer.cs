namespace PROJ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainMem = new System.Windows.Forms.DataGridView();
            this.pc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmar = new System.Windows.Forms.RichTextBox();
            this.txtmdr = new System.Windows.Forms.RichTextBox();
            this.cbmp = new System.Windows.Forms.ComboBox();
            this.decoder = new System.Windows.Forms.DataGridView();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.txtal = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox10 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtALU = new System.Windows.Forms.RichTextBox();
            this.alulbl = new System.Windows.Forms.Label();
            this.microprocessorlbl = new System.Windows.Forms.Label();
            this.EXECUTE = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.visa = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cbi = new System.Windows.Forms.ComboBox();
            this.clearallbtn = new System.Windows.Forms.Button();
            this.clearmembtn = new System.Windows.Forms.Button();
            this.decodergroupbox = new System.Windows.Forms.GroupBox();
            this.LBLOP2 = new System.Windows.Forms.Label();
            this.lblOPERAND = new System.Windows.Forms.Label();
            this.lblOPCODE = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ZEROtxt = new System.Windows.Forms.TextBox();
            this.NEGATIVEtxt = new System.Windows.Forms.TextBox();
            this.CARRYtxt = new System.Windows.Forms.TextBox();
            this.OVERFLOWtxt = new System.Windows.Forms.TextBox();
            this.flagsgroupbox = new System.Windows.Forms.GroupBox();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.rjToggleButton1 = new PROJ.RJToggleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restart = new System.Windows.Forms.Button();
            this.registersgroupbox = new System.Windows.Forms.GroupBox();
            this.specialregistergroupbox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.formatxtbox = new System.Windows.Forms.RichTextBox();
            this.AddAssemblyFilebtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decoder)).BeginInit();
            this.decodergroupbox.SuspendLayout();
            this.flagsgroupbox.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.registersgroupbox.SuspendLayout();
            this.specialregistergroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMem
            // 
            this.MainMem.AccessibleName = "MainMem";
            this.MainMem.AllowDrop = true;
            this.MainMem.AllowUserToOrderColumns = true;
            this.MainMem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainMem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MainMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainMem.Location = new System.Drawing.Point(722, 195);
            this.MainMem.Name = "MainMem";
            this.MainMem.RowTemplate.Height = 25;
            this.MainMem.Size = new System.Drawing.Size(343, 389);
            this.MainMem.TabIndex = 0;
            this.MainMem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pc
            // 
            this.pc.Location = new System.Drawing.Point(66, 32);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(58, 49);
            this.pc.TabIndex = 4;
            this.pc.Text = "";
            this.pc.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "PC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "MAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "MDR";
            // 
            // txtmar
            // 
            this.txtmar.Location = new System.Drawing.Point(66, 139);
            this.txtmar.Name = "txtmar";
            this.txtmar.Size = new System.Drawing.Size(58, 49);
            this.txtmar.TabIndex = 9;
            this.txtmar.Text = "";
            // 
            // txtmdr
            // 
            this.txtmdr.Location = new System.Drawing.Point(66, 244);
            this.txtmdr.Name = "txtmdr";
            this.txtmdr.Size = new System.Drawing.Size(58, 49);
            this.txtmdr.TabIndex = 10;
            this.txtmdr.Text = "";
            // 
            // cbmp
            // 
            this.cbmp.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbmp.FormattingEnabled = true;
            this.cbmp.Items.AddRange(new object[] {
            "8 BIT",
            "16 BIT",
            "32 BIT",
            "64 BIT"});
            this.cbmp.Location = new System.Drawing.Point(430, 104);
            this.cbmp.Name = "cbmp";
            this.cbmp.Size = new System.Drawing.Size(225, 25);
            this.cbmp.TabIndex = 11;
            this.cbmp.Text = "SELECT MICROPROCESSOR";
            this.cbmp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // decoder
            // 
            this.decoder.AllowUserToDeleteRows = false;
            this.decoder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.decoder.Location = new System.Drawing.Point(6, 28);
            this.decoder.Name = "decoder";
            this.decoder.ReadOnly = true;
            this.decoder.RowTemplate.Height = 25;
            this.decoder.Size = new System.Drawing.Size(1516, 54);
            this.decoder.TabIndex = 12;
            this.decoder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(46, 113);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(116, 49);
            this.richTextBox4.TabIndex = 13;
            this.richTextBox4.Text = "";
            // 
            // txtal
            // 
            this.txtal.Location = new System.Drawing.Point(47, 58);
            this.txtal.Name = "txtal";
            this.txtal.Size = new System.Drawing.Size(115, 49);
            this.txtal.TabIndex = 15;
            this.txtal.Text = "";
            // 
            // richTextBox8
            // 
            this.richTextBox8.Location = new System.Drawing.Point(46, 225);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(115, 49);
            this.richTextBox8.TabIndex = 17;
            this.richTextBox8.Text = "";
            // 
            // richTextBox10
            // 
            this.richTextBox10.Location = new System.Drawing.Point(46, 170);
            this.richTextBox10.Name = "richTextBox10";
            this.richTextBox10.Size = new System.Drawing.Size(115, 49);
            this.richTextBox10.TabIndex = 19;
            this.richTextBox10.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "R3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "R2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "R4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(17, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "R1";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtALU
            // 
            this.txtALU.Location = new System.Drawing.Point(223, 585);
            this.txtALU.Name = "txtALU";
            this.txtALU.Size = new System.Drawing.Size(186, 119);
            this.txtALU.TabIndex = 25;
            this.txtALU.Text = "";
            this.txtALU.TextChanged += new System.EventHandler(this.txtALU_TextChanged);
            // 
            // alulbl
            // 
            this.alulbl.AutoSize = true;
            this.alulbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alulbl.Location = new System.Drawing.Point(185, 634);
            this.alulbl.Name = "alulbl";
            this.alulbl.Size = new System.Drawing.Size(32, 17);
            this.alulbl.TabIndex = 26;
            this.alulbl.Text = "ALU";
            // 
            // microprocessorlbl
            // 
            this.microprocessorlbl.AutoSize = true;
            this.microprocessorlbl.Font = new System.Drawing.Font("Palatino Linotype", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.microprocessorlbl.Location = new System.Drawing.Point(486, -3);
            this.microprocessorlbl.Name = "microprocessorlbl";
            this.microprocessorlbl.Size = new System.Drawing.Size(554, 72);
            this.microprocessorlbl.TabIndex = 28;
            this.microprocessorlbl.Text = "MICROPROCESSOR";
            this.microprocessorlbl.Click += new System.EventHandler(this.label10_Click);
            // 
            // EXECUTE
            // 
            this.EXECUTE.BackColor = System.Drawing.Color.Lime;
            this.EXECUTE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EXECUTE.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EXECUTE.Location = new System.Drawing.Point(449, 149);
            this.EXECUTE.Name = "EXECUTE";
            this.EXECUTE.Size = new System.Drawing.Size(81, 58);
            this.EXECUTE.TabIndex = 29;
            this.EXECUTE.Text = "EXECUTE";
            this.EXECUTE.UseVisualStyleBackColor = false;
            this.EXECUTE.Click += new System.EventHandler(this.EXECUTE_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            // 
            // visa
            // 
            this.visa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.visa.Location = new System.Drawing.Point(1363, 9);
            this.visa.Name = "visa";
            this.visa.Size = new System.Drawing.Size(78, 46);
            this.visa.TabIndex = 33;
            this.visa.Text = "View Formats";
            this.visa.UseVisualStyleBackColor = true;
            this.visa.Click += new System.EventHandler(this.visa_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 37;
            // 
            // cbi
            // 
            this.cbi.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbi.FormattingEnabled = true;
            this.cbi.Items.AddRange(new object[] {
            "LOAD Value",
            "ADD 2 Numbers",
            "SUB 2 Numbers",
            "MUL 2 Numbers",
            "DIV 2 Numbers"});
            this.cbi.Location = new System.Drawing.Point(834, 164);
            this.cbi.Name = "cbi";
            this.cbi.Size = new System.Drawing.Size(132, 25);
            this.cbi.TabIndex = 38;
            this.cbi.Tag = "";
            this.cbi.Text = "SELECT PROGRAM";
            this.cbi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // clearallbtn
            // 
            this.clearallbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearallbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearallbtn.Location = new System.Drawing.Point(12, 226);
            this.clearallbtn.Name = "clearallbtn";
            this.clearallbtn.Size = new System.Drawing.Size(88, 34);
            this.clearallbtn.TabIndex = 39;
            this.clearallbtn.Text = "CLEAR ALL";
            this.clearallbtn.UseVisualStyleBackColor = false;
            this.clearallbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // clearmembtn
            // 
            this.clearmembtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearmembtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.clearmembtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.clearmembtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.clearmembtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearmembtn.Location = new System.Drawing.Point(843, 590);
            this.clearmembtn.Name = "clearmembtn";
            this.clearmembtn.Size = new System.Drawing.Size(123, 23);
            this.clearmembtn.TabIndex = 40;
            this.clearmembtn.Text = "CLEAR Memory";
            this.clearmembtn.UseVisualStyleBackColor = false;
            this.clearmembtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // decodergroupbox
            // 
            this.decodergroupbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.decodergroupbox.Controls.Add(this.LBLOP2);
            this.decodergroupbox.Controls.Add(this.lblOPERAND);
            this.decodergroupbox.Controls.Add(this.lblOPCODE);
            this.decodergroupbox.Controls.Add(this.decoder);
            this.decodergroupbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decodergroupbox.Location = new System.Drawing.Point(12, 710);
            this.decodergroupbox.Name = "decodergroupbox";
            this.decodergroupbox.Size = new System.Drawing.Size(1528, 143);
            this.decodergroupbox.TabIndex = 41;
            this.decodergroupbox.TabStop = false;
            this.decodergroupbox.Text = "DECODER";
            this.decodergroupbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LBLOP2
            // 
            this.LBLOP2.AutoSize = true;
            this.LBLOP2.BackColor = System.Drawing.Color.RosyBrown;
            this.LBLOP2.Location = new System.Drawing.Point(1230, 112);
            this.LBLOP2.Name = "LBLOP2";
            this.LBLOP2.Size = new System.Drawing.Size(100, 21);
            this.LBLOP2.TabIndex = 15;
            this.LBLOP2.Text = "OPERAND 2";
            this.LBLOP2.Visible = false;
            // 
            // lblOPERAND
            // 
            this.lblOPERAND.AutoSize = true;
            this.lblOPERAND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblOPERAND.Location = new System.Drawing.Point(896, 112);
            this.lblOPERAND.Name = "lblOPERAND";
            this.lblOPERAND.Size = new System.Drawing.Size(100, 21);
            this.lblOPERAND.TabIndex = 14;
            this.lblOPERAND.Text = "OPERAND 1";
            this.lblOPERAND.Visible = false;
            // 
            // lblOPCODE
            // 
            this.lblOPCODE.AutoSize = true;
            this.lblOPCODE.BackColor = System.Drawing.Color.Yellow;
            this.lblOPCODE.Location = new System.Drawing.Point(111, 112);
            this.lblOPCODE.Name = "lblOPCODE";
            this.lblOPCODE.Size = new System.Drawing.Size(75, 21);
            this.lblOPCODE.TabIndex = 13;
            this.lblOPCODE.Text = "OPCODE";
            this.lblOPCODE.Visible = false;
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Tomato;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stop.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stop.Location = new System.Drawing.Point(553, 149);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(81, 58);
            this.stop.TabIndex = 43;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "ZERO ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "NEGATIVE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "CARRY";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "OVERFLOW";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // ZEROtxt
            // 
            this.ZEROtxt.Location = new System.Drawing.Point(91, 56);
            this.ZEROtxt.Name = "ZEROtxt";
            this.ZEROtxt.Size = new System.Drawing.Size(28, 25);
            this.ZEROtxt.TabIndex = 47;
            // 
            // NEGATIVEtxt
            // 
            this.NEGATIVEtxt.Location = new System.Drawing.Point(91, 105);
            this.NEGATIVEtxt.Name = "NEGATIVEtxt";
            this.NEGATIVEtxt.Size = new System.Drawing.Size(28, 25);
            this.NEGATIVEtxt.TabIndex = 48;
            // 
            // CARRYtxt
            // 
            this.CARRYtxt.Location = new System.Drawing.Point(91, 155);
            this.CARRYtxt.Name = "CARRYtxt";
            this.CARRYtxt.Size = new System.Drawing.Size(28, 25);
            this.CARRYtxt.TabIndex = 49;
            // 
            // OVERFLOWtxt
            // 
            this.OVERFLOWtxt.Location = new System.Drawing.Point(91, 204);
            this.OVERFLOWtxt.Name = "OVERFLOWtxt";
            this.OVERFLOWtxt.Size = new System.Drawing.Size(28, 25);
            this.OVERFLOWtxt.TabIndex = 50;
            this.OVERFLOWtxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // flagsgroupbox
            // 
            this.flagsgroupbox.Controls.Add(this.OVERFLOWtxt);
            this.flagsgroupbox.Controls.Add(this.CARRYtxt);
            this.flagsgroupbox.Controls.Add(this.NEGATIVEtxt);
            this.flagsgroupbox.Controls.Add(this.ZEROtxt);
            this.flagsgroupbox.Controls.Add(this.label16);
            this.flagsgroupbox.Controls.Add(this.label15);
            this.flagsgroupbox.Controls.Add(this.label14);
            this.flagsgroupbox.Controls.Add(this.label9);
            this.flagsgroupbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flagsgroupbox.Location = new System.Drawing.Point(47, 318);
            this.flagsgroupbox.Name = "flagsgroupbox";
            this.flagsgroupbox.Size = new System.Drawing.Size(151, 255);
            this.flagsgroupbox.TabIndex = 46;
            this.flagsgroupbox.TabStop = false;
            this.flagsgroupbox.Enter += new System.EventHandler(this.flagsgroupbox_Enter);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.Orange;
            this.mainpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainpanel.Controls.Add(this.label17);
            this.mainpanel.Controls.Add(this.microprocessorlbl);
            this.mainpanel.Controls.Add(this.rjToggleButton1);
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1594, 70);
            this.mainpanel.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(1468, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 17);
            this.label17.TabIndex = 51;
            this.label17.Text = "Dark Mode";
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.rjToggleButton1.FlatAppearance.BorderSize = 2;
            this.rjToggleButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.rjToggleButton1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rjToggleButton1.Location = new System.Drawing.Point(1482, 21);
            this.rjToggleButton1.MaximumSize = new System.Drawing.Size(57, 23);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(15, 29);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.Size = new System.Drawing.Size(57, 29);
            this.rjToggleButton1.TabIndex = 50;
            this.rjToggleButton1.Text = "rjToggleButton1";
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            this.rjToggleButton1.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Gold;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restart.Location = new System.Drawing.Point(12, 149);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(88, 58);
            this.restart.TabIndex = 49;
            this.restart.Text = "RESTART";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.button5_Click);
            // 
            // registersgroupbox
            // 
            this.registersgroupbox.Controls.Add(this.richTextBox4);
            this.registersgroupbox.Controls.Add(this.txtal);
            this.registersgroupbox.Controls.Add(this.richTextBox8);
            this.registersgroupbox.Controls.Add(this.richTextBox10);
            this.registersgroupbox.Controls.Add(this.label2);
            this.registersgroupbox.Controls.Add(this.label5);
            this.registersgroupbox.Controls.Add(this.label6);
            this.registersgroupbox.Controls.Add(this.label7);
            this.registersgroupbox.Location = new System.Drawing.Point(223, 237);
            this.registersgroupbox.Name = "registersgroupbox";
            this.registersgroupbox.Size = new System.Drawing.Size(200, 336);
            this.registersgroupbox.TabIndex = 50;
            this.registersgroupbox.TabStop = false;
            // 
            // specialregistergroupbox
            // 
            this.specialregistergroupbox.Controls.Add(this.pc);
            this.specialregistergroupbox.Controls.Add(this.label1);
            this.specialregistergroupbox.Controls.Add(this.label3);
            this.specialregistergroupbox.Controls.Add(this.label4);
            this.specialregistergroupbox.Controls.Add(this.txtmar);
            this.specialregistergroupbox.Controls.Add(this.txtmdr);
            this.specialregistergroupbox.Location = new System.Drawing.Point(508, 268);
            this.specialregistergroupbox.Name = "specialregistergroupbox";
            this.specialregistergroupbox.Size = new System.Drawing.Size(177, 310);
            this.specialregistergroupbox.TabIndex = 51;
            this.specialregistergroupbox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1268, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 38);
            this.button1.TabIndex = 52;
            this.button1.Text = "Show Formats";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // formatxtbox
            // 
            this.formatxtbox.AutoWordSelection = true;
            this.formatxtbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.formatxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.formatxtbox.EnableAutoDragDrop = true;
            this.formatxtbox.Location = new System.Drawing.Point(1135, 422);
            this.formatxtbox.Name = "formatxtbox";
            this.formatxtbox.ReadOnly = true;
            this.formatxtbox.Size = new System.Drawing.Size(388, 266);
            this.formatxtbox.TabIndex = 53;
            this.formatxtbox.Text = "";
            this.formatxtbox.TextChanged += new System.EventHandler(this.formatxtbox_TextChanged);
            // 
            // AddAssemblyFilebtn
            // 
            this.AddAssemblyFilebtn.Depth = 0;
            this.AddAssemblyFilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddAssemblyFilebtn.Location = new System.Drawing.Point(1256, 76);
            this.AddAssemblyFilebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddAssemblyFilebtn.Name = "AddAssemblyFilebtn";
            this.AddAssemblyFilebtn.Primary = true;
            this.AddAssemblyFilebtn.Size = new System.Drawing.Size(137, 15);
            this.AddAssemblyFilebtn.TabIndex = 55;
            this.AddAssemblyFilebtn.Text = "ADD assembly File";
            this.AddAssemblyFilebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddAssemblyFilebtn.UseVisualStyleBackColor = true;
            this.AddAssemblyFilebtn.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "OpenFileDialogText";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(1135, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(388, 233);
            this.richTextBox1.TabIndex = 56;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1594, 865);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.AddAssemblyFilebtn);
            this.Controls.Add(this.formatxtbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.specialregistergroupbox);
            this.Controls.Add(this.registersgroupbox);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.flagsgroupbox);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.decodergroupbox);
            this.Controls.Add(this.clearmembtn);
            this.Controls.Add(this.clearallbtn);
            this.Controls.Add(this.cbi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.visa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EXECUTE);
            this.Controls.Add(this.alulbl);
            this.Controls.Add(this.txtALU);
            this.Controls.Add(this.cbmp);
            this.Controls.Add(this.MainMem);
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MICROPROCESSOR ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decoder)).EndInit();
            this.decodergroupbox.ResumeLayout(false);
            this.decodergroupbox.PerformLayout();
            this.flagsgroupbox.ResumeLayout(false);
            this.flagsgroupbox.PerformLayout();
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.registersgroupbox.ResumeLayout(false);
            this.registersgroupbox.PerformLayout();
            this.specialregistergroupbox.ResumeLayout(false);
            this.specialregistergroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView MainMem;
        private RichTextBox pc;
        private Label label1;
        private Label label3;
        private Label label4;
        private RichTextBox richTextBox2;
        private RichTextBox txtmdr;
        private ComboBox cbmp;
        private DataGridView decoder;
        private RichTextBox richTextBox4;
        private RichTextBox txtal;
        private RichTextBox richTextBox8;
        private RichTextBox richTextBox10;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox txtALU;
        private Label alulbl;
        private TextBox tb1;
        private TextBox tb2;
        private Label microprocessorlbl;
        private Button EXECUTE;
        private Button button2;
        private RichTextBox txtmar;
        private Button visa;
        private Label label13;
        private ComboBox cbi;
        private Button clearallbtn;
        private Button clearmembtn;
        private GroupBox decodergroupbox;
        private Label lblOPERAND;
        private Label lblOPCODE;
        private Button stop;
        private Label label9;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox ZEROtxt;
        private TextBox NEGATIVEtxt;
        private TextBox CARRYtxt;
        private TextBox OVERFLOWtxt;
        private GroupBox flagsgroupbox;
        private Panel mainpanel;
        private ContextMenuStrip contextMenuStrip1;
        private Button restart;
        private RJToggleButton rjToggleButton1;
        private Label label17;
        private GroupBox registersgroupbox;
        private GroupBox specialregistergroupbox;
        private Button button1;
        private RichTextBox formatxtbox;
        private Label LBLOP2;
        private MaterialSkin.Controls.MaterialRaisedButton AddAssemblyFilebtn;
        private OpenFileDialog openFileDialog1;
        private RichTextBox richTextBox1;
    }
}