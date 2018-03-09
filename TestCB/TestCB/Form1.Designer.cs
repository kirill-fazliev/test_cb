namespace TestCB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxBIKFilter = new System.Windows.Forms.MaskedTextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.maskedTextBoxRegionFilter = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxTypeFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxDATE_CH = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxREG = new System.Windows.Forms.ComboBox();
            this.comboBoxUER = new System.Windows.Forms.ComboBox();
            this.comboBoxTNP = new System.Windows.Forms.ComboBox();
            this.comboBoxPZN = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxREAL = new System.Windows.Forms.TextBox();
            this.textBoxIND = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxNNP = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxDATE_IN = new System.Windows.Forms.TextBox();
            this.textBoxADR = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxDT_IZM = new System.Windows.Forms.TextBox();
            this.textBoxRKC = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxOKPO = new System.Windows.Forms.TextBox();
            this.textBoxNAMEP = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxREGN = new System.Windows.Forms.TextBox();
            this.textBoxNAMEN = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxTELEF = new System.Windows.Forms.TextBox();
            this.textBoxNEWNUM = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDB
            // 
            this.dataGridViewDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDB.Location = new System.Drawing.Point(12, 43);
            this.dataGridViewDB.MultiSelect = false;
            this.dataGridViewDB.Name = "dataGridViewDB";
            this.dataGridViewDB.ReadOnly = true;
            this.dataGridViewDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDB.Size = new System.Drawing.Size(1162, 557);
            this.dataGridViewDB.TabIndex = 1;
            this.dataGridViewDB.SelectionChanged += new System.EventHandler(this.DataGridViewDB_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "БИК:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Регион:";
            // 
            // maskedTextBoxBIKFilter
            // 
            this.maskedTextBoxBIKFilter.Location = new System.Drawing.Point(174, 15);
            this.maskedTextBoxBIKFilter.Mask = "000000000";
            this.maskedTextBoxBIKFilter.Name = "maskedTextBoxBIKFilter";
            this.maskedTextBoxBIKFilter.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBoxBIKFilter.TabIndex = 8;
            this.maskedTextBoxBIKFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBoxBIKFilter.TextChanged += new System.EventHandler(this.MaskedTextBoxBIK_TextChanged);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(415, 14);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(115, 23);
            this.buttonFilter.TabIndex = 9;
            this.buttonFilter.Text = "Отфильтровать";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // maskedTextBoxRegionFilter
            // 
            this.maskedTextBoxRegionFilter.Location = new System.Drawing.Point(57, 15);
            this.maskedTextBoxRegionFilter.Mask = "00";
            this.maskedTextBoxRegionFilter.Name = "maskedTextBoxRegionFilter";
            this.maskedTextBoxRegionFilter.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBoxRegionFilter.TabIndex = 10;
            this.maskedTextBoxRegionFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxTypeFilter
            // 
            this.comboBoxTypeFilter.AllowDrop = true;
            this.comboBoxTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeFilter.FormattingEnabled = true;
            this.comboBoxTypeFilter.Location = new System.Drawing.Point(288, 14);
            this.comboBoxTypeFilter.Name = "comboBoxTypeFilter";
            this.comboBoxTypeFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeFilter.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Тип:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(933, 606);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChange.Location = new System.Drawing.Point(1014, 606);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 21;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(1099, 606);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(45, 346);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 80;
            this.label18.Text = "DATE_IN";
            // 
            // textBoxDATE_CH
            // 
            this.textBoxDATE_CH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDATE_CH.Location = new System.Drawing.Point(131, 369);
            this.textBoxDATE_CH.Name = "textBoxDATE_CH";
            this.textBoxDATE_CH.Size = new System.Drawing.Size(68, 20);
            this.textBoxDATE_CH.TabIndex = 81;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(45, 372);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 82;
            this.label19.Text = "DATE_CH";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(166, 592);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 83;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(50, 592);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 84;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEdit.Controls.Add(this.label7);
            this.panelEdit.Controls.Add(this.label6);
            this.panelEdit.Controls.Add(this.label5);
            this.panelEdit.Controls.Add(this.label4);
            this.panelEdit.Controls.Add(this.comboBoxREG);
            this.panelEdit.Controls.Add(this.comboBoxUER);
            this.panelEdit.Controls.Add(this.comboBoxTNP);
            this.panelEdit.Controls.Add(this.comboBoxPZN);
            this.panelEdit.Controls.Add(this.label20);
            this.panelEdit.Controls.Add(this.buttonCancel);
            this.panelEdit.Controls.Add(this.textBoxREAL);
            this.panelEdit.Controls.Add(this.textBoxIND);
            this.panelEdit.Controls.Add(this.buttonOK);
            this.panelEdit.Controls.Add(this.label21);
            this.panelEdit.Controls.Add(this.textBoxNNP);
            this.panelEdit.Controls.Add(this.label19);
            this.panelEdit.Controls.Add(this.label22);
            this.panelEdit.Controls.Add(this.textBoxDATE_IN);
            this.panelEdit.Controls.Add(this.textBoxDATE_CH);
            this.panelEdit.Controls.Add(this.textBoxADR);
            this.panelEdit.Controls.Add(this.label23);
            this.panelEdit.Controls.Add(this.label18);
            this.panelEdit.Controls.Add(this.label24);
            this.panelEdit.Controls.Add(this.textBoxDT_IZM);
            this.panelEdit.Controls.Add(this.textBoxRKC);
            this.panelEdit.Controls.Add(this.label25);
            this.panelEdit.Controls.Add(this.label26);
            this.panelEdit.Controls.Add(this.textBoxOKPO);
            this.panelEdit.Controls.Add(this.textBoxNAMEP);
            this.panelEdit.Controls.Add(this.label27);
            this.panelEdit.Controls.Add(this.label28);
            this.panelEdit.Controls.Add(this.textBoxREGN);
            this.panelEdit.Controls.Add(this.textBoxNAMEN);
            this.panelEdit.Controls.Add(this.label29);
            this.panelEdit.Controls.Add(this.label30);
            this.panelEdit.Controls.Add(this.textBoxTELEF);
            this.panelEdit.Controls.Add(this.textBoxNEWNUM);
            this.panelEdit.Controls.Add(this.label31);
            this.panelEdit.Location = new System.Drawing.Point(1180, 14);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(265, 628);
            this.panelEdit.TabIndex = 85;
            this.panelEdit.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "REG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "UER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "TNP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "PZN";
            // 
            // comboBoxREG
            // 
            this.comboBoxREG.AllowDrop = true;
            this.comboBoxREG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxREG.FormattingEnabled = true;
            this.comboBoxREG.Location = new System.Drawing.Point(120, 523);
            this.comboBoxREG.Name = "comboBoxREG";
            this.comboBoxREG.Size = new System.Drawing.Size(121, 21);
            this.comboBoxREG.TabIndex = 86;
            // 
            // comboBoxUER
            // 
            this.comboBoxUER.AllowDrop = true;
            this.comboBoxUER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUER.FormattingEnabled = true;
            this.comboBoxUER.Location = new System.Drawing.Point(120, 496);
            this.comboBoxUER.Name = "comboBoxUER";
            this.comboBoxUER.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUER.TabIndex = 86;
            // 
            // comboBoxTNP
            // 
            this.comboBoxTNP.AllowDrop = true;
            this.comboBoxTNP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTNP.FormattingEnabled = true;
            this.comboBoxTNP.Location = new System.Drawing.Point(120, 469);
            this.comboBoxTNP.Name = "comboBoxTNP";
            this.comboBoxTNP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTNP.TabIndex = 86;
            // 
            // comboBoxPZN
            // 
            this.comboBoxPZN.AllowDrop = true;
            this.comboBoxPZN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPZN.FormattingEnabled = true;
            this.comboBoxPZN.Location = new System.Drawing.Point(120, 442);
            this.comboBoxPZN.Name = "comboBoxPZN";
            this.comboBoxPZN.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPZN.TabIndex = 85;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Enabled = false;
            this.label20.Location = new System.Drawing.Point(39, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 56;
            this.label20.Text = "REAL";
            // 
            // textBoxREAL
            // 
            this.textBoxREAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxREAL.Enabled = false;
            this.textBoxREAL.Location = new System.Drawing.Point(131, 28);
            this.textBoxREAL.Name = "textBoxREAL";
            this.textBoxREAL.Size = new System.Drawing.Size(68, 20);
            this.textBoxREAL.TabIndex = 55;
            // 
            // textBoxIND
            // 
            this.textBoxIND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIND.Location = new System.Drawing.Point(131, 54);
            this.textBoxIND.Name = "textBoxIND";
            this.textBoxIND.Size = new System.Drawing.Size(68, 20);
            this.textBoxIND.TabIndex = 57;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(45, 57);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 13);
            this.label21.TabIndex = 58;
            this.label21.Text = "IND";
            // 
            // textBoxNNP
            // 
            this.textBoxNNP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNNP.Location = new System.Drawing.Point(131, 80);
            this.textBoxNNP.Name = "textBoxNNP";
            this.textBoxNNP.Size = new System.Drawing.Size(68, 20);
            this.textBoxNNP.TabIndex = 59;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(45, 83);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 13);
            this.label22.TabIndex = 60;
            this.label22.Text = "NNP";
            // 
            // textBoxDATE_IN
            // 
            this.textBoxDATE_IN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDATE_IN.Location = new System.Drawing.Point(131, 343);
            this.textBoxDATE_IN.Name = "textBoxDATE_IN";
            this.textBoxDATE_IN.Size = new System.Drawing.Size(68, 20);
            this.textBoxDATE_IN.TabIndex = 79;
            // 
            // textBoxADR
            // 
            this.textBoxADR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxADR.Location = new System.Drawing.Point(131, 108);
            this.textBoxADR.Name = "textBoxADR";
            this.textBoxADR.Size = new System.Drawing.Size(68, 20);
            this.textBoxADR.TabIndex = 61;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(45, 321);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 13);
            this.label23.TabIndex = 78;
            this.label23.Text = "DT_IZM";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(45, 109);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 13);
            this.label24.TabIndex = 62;
            this.label24.Text = "ADR";
            // 
            // textBoxDT_IZM
            // 
            this.textBoxDT_IZM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDT_IZM.Location = new System.Drawing.Point(131, 318);
            this.textBoxDT_IZM.Name = "textBoxDT_IZM";
            this.textBoxDT_IZM.ReadOnly = true;
            this.textBoxDT_IZM.Size = new System.Drawing.Size(68, 20);
            this.textBoxDT_IZM.TabIndex = 77;
            // 
            // textBoxRKC
            // 
            this.textBoxRKC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRKC.Location = new System.Drawing.Point(131, 134);
            this.textBoxRKC.Name = "textBoxRKC";
            this.textBoxRKC.Size = new System.Drawing.Size(68, 20);
            this.textBoxRKC.TabIndex = 63;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(45, 295);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 13);
            this.label25.TabIndex = 76;
            this.label25.Text = "OKPO";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(45, 135);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 13);
            this.label26.TabIndex = 64;
            this.label26.Text = "RKC";
            // 
            // textBoxOKPO
            // 
            this.textBoxOKPO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOKPO.Location = new System.Drawing.Point(131, 292);
            this.textBoxOKPO.Name = "textBoxOKPO";
            this.textBoxOKPO.Size = new System.Drawing.Size(68, 20);
            this.textBoxOKPO.TabIndex = 75;
            // 
            // textBoxNAMEP
            // 
            this.textBoxNAMEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNAMEP.Location = new System.Drawing.Point(131, 160);
            this.textBoxNAMEP.Name = "textBoxNAMEP";
            this.textBoxNAMEP.Size = new System.Drawing.Size(68, 20);
            this.textBoxNAMEP.TabIndex = 65;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(45, 267);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(38, 13);
            this.label27.TabIndex = 74;
            this.label27.Text = "REGN";
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(45, 161);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 13);
            this.label28.TabIndex = 66;
            this.label28.Text = "NAMEP";
            // 
            // textBoxREGN
            // 
            this.textBoxREGN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxREGN.Location = new System.Drawing.Point(131, 264);
            this.textBoxREGN.Name = "textBoxREGN";
            this.textBoxREGN.Size = new System.Drawing.Size(68, 20);
            this.textBoxREGN.TabIndex = 73;
            // 
            // textBoxNAMEN
            // 
            this.textBoxNAMEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNAMEN.Location = new System.Drawing.Point(131, 186);
            this.textBoxNAMEN.Name = "textBoxNAMEN";
            this.textBoxNAMEN.Size = new System.Drawing.Size(68, 20);
            this.textBoxNAMEN.TabIndex = 67;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(45, 241);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(40, 13);
            this.label29.TabIndex = 72;
            this.label29.Text = "TELEF";
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(45, 187);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(46, 13);
            this.label30.TabIndex = 68;
            this.label30.Text = "NAMEN";
            // 
            // textBoxTELEF
            // 
            this.textBoxTELEF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTELEF.Location = new System.Drawing.Point(131, 238);
            this.textBoxTELEF.Name = "textBoxTELEF";
            this.textBoxTELEF.Size = new System.Drawing.Size(68, 20);
            this.textBoxTELEF.TabIndex = 71;
            // 
            // textBoxNEWNUM
            // 
            this.textBoxNEWNUM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNEWNUM.Location = new System.Drawing.Point(131, 212);
            this.textBoxNEWNUM.Name = "textBoxNEWNUM";
            this.textBoxNEWNUM.Size = new System.Drawing.Size(68, 20);
            this.textBoxNEWNUM.TabIndex = 69;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(45, 213);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 13);
            this.label31.TabIndex = 70;
            this.label31.Text = "NEWNUM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 679);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTypeFilter);
            this.Controls.Add(this.maskedTextBoxRegionFilter);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.maskedTextBoxBIKFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBIKFilter;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRegionFilter;
        private System.Windows.Forms.ComboBox comboBoxTypeFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxDATE_CH;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxREAL;
        private System.Windows.Forms.TextBox textBoxIND;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxNNP;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxDATE_IN;
        private System.Windows.Forms.TextBox textBoxADR;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBoxDT_IZM;
        private System.Windows.Forms.TextBox textBoxRKC;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxOKPO;
        private System.Windows.Forms.TextBox textBoxNAMEP;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxREGN;
        private System.Windows.Forms.TextBox textBoxNAMEN;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxTELEF;
        private System.Windows.Forms.TextBox textBoxNEWNUM;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox comboBoxREG;
        private System.Windows.Forms.ComboBox comboBoxUER;
        private System.Windows.Forms.ComboBox comboBoxTNP;
        private System.Windows.Forms.ComboBox comboBoxPZN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

