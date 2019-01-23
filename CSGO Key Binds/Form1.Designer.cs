namespace CSGO_Buy_Binds_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.primaryList = new System.Windows.Forms.ComboBox();
            this.secondaryList = new System.Windows.Forms.ComboBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.keysLabel = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.gearCheck3 = new System.Windows.Forms.CheckBox();
            this.gearCheck4 = new System.Windows.Forms.CheckBox();
            this.gearGroup = new System.Windows.Forms.GroupBox();
            this.noarmorRadio = new System.Windows.Forms.RadioButton();
            this.kevlarRadio = new System.Windows.Forms.RadioButton();
            this.kevlarhelmRadio = new System.Windows.Forms.RadioButton();
            this.nadeGroup = new System.Windows.Forms.GroupBox();
            this.nadeCheck5 = new System.Windows.Forms.CheckBox();
            this.nadeCheck4 = new System.Windows.Forms.CheckBox();
            this.nadeCheck3 = new System.Windows.Forms.CheckBox();
            this.nadeCheck2 = new System.Windows.Forms.CheckBox();
            this.nadeCheck1 = new System.Windows.Forms.CheckBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.primaryGroup = new System.Windows.Forms.GroupBox();
            this.heavyList = new System.Windows.Forms.ComboBox();
            this.smgList = new System.Windows.Forms.ComboBox();
            this.heavysRadio = new System.Windows.Forms.RadioButton();
            this.smgsRadio = new System.Windows.Forms.RadioButton();
            this.riflesRadio = new System.Windows.Forms.RadioButton();
            this.noneRadio = new System.Windows.Forms.RadioButton();
            this.secondaryBox = new System.Windows.Forms.GroupBox();
            this.pistolRadio = new System.Windows.Forms.RadioButton();
            this.none2Radio = new System.Windows.Forms.RadioButton();
            this.costLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.infoLink = new System.Windows.Forms.LinkLabel();
            this.selectkeyButton = new System.Windows.Forms.Button();
            this.keyLabel = new System.Windows.Forms.Label();
            this.nadeCheck6 = new System.Windows.Forms.CheckBox();
            this.createCfg = new System.Windows.Forms.Button();
            this.saveToCfg = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.changelogLink = new System.Windows.Forms.LinkLabel();
            this.noteLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gearGroup.SuspendLayout();
            this.nadeGroup.SuspendLayout();
            this.primaryGroup.SuspendLayout();
            this.secondaryBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // primaryList
            // 
            this.primaryList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.primaryList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.primaryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.primaryList.Enabled = false;
            this.primaryList.FormattingEnabled = true;
            this.primaryList.Items.AddRange(new object[] {
            "AK-47",
            "M4A1-S",
            "M4A4",
            "Galil AR",
            "FAMAS",
            "SSG 08",
            "SG 553",
            "AUG",
            "G3SG1",
            "SCAR-20",
            "AWP"});
            this.primaryList.Location = new System.Drawing.Point(81, 52);
            this.primaryList.Name = "primaryList";
            this.primaryList.Size = new System.Drawing.Size(121, 21);
            this.primaryList.TabIndex = 1;
            this.primaryList.SelectedIndexChanged += new System.EventHandler(this.primaryChanged);
            // 
            // secondaryList
            // 
            this.secondaryList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.secondaryList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.secondaryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secondaryList.Enabled = false;
            this.secondaryList.FormattingEnabled = true;
            this.secondaryList.Items.AddRange(new object[] {
            "Glock-18",
            "USP-S",
            "P2000",
            "P250",
            "Dual Barettas",
            "Tec-9",
            "Five-SeveN",
            "CZ75-Auto",
            "Desert Eagle"});
            this.secondaryList.Location = new System.Drawing.Point(81, 40);
            this.secondaryList.Name = "secondaryList";
            this.secondaryList.Size = new System.Drawing.Size(121, 21);
            this.secondaryList.TabIndex = 2;
            this.secondaryList.Tag = "";
            this.secondaryList.SelectedValueChanged += new System.EventHandler(this.primaryChanged);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultBox.Location = new System.Drawing.Point(12, 389);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(355, 47);
            this.resultBox.TabIndex = 3;
            // 
            // keysLabel
            // 
            this.keysLabel.AutoSize = true;
            this.keysLabel.Location = new System.Drawing.Point(12, 64);
            this.keysLabel.Name = "keysLabel";
            this.keysLabel.Size = new System.Drawing.Size(73, 13);
            this.keysLabel.TabIndex = 6;
            this.keysLabel.Text = "Selected Key:";
            // 
            // gearCheck3
            // 
            this.gearCheck3.AutoSize = true;
            this.gearCheck3.Location = new System.Drawing.Point(6, 88);
            this.gearCheck3.Name = "gearCheck3";
            this.gearCheck3.Size = new System.Drawing.Size(75, 17);
            this.gearCheck3.TabIndex = 12;
            this.gearCheck3.Text = "Defuse Kit";
            this.gearCheck3.UseVisualStyleBackColor = true;
            this.gearCheck3.CheckedChanged += new System.EventHandler(this.gearCheck);
            // 
            // gearCheck4
            // 
            this.gearCheck4.AutoSize = true;
            this.gearCheck4.Location = new System.Drawing.Point(6, 111);
            this.gearCheck4.Name = "gearCheck4";
            this.gearCheck4.Size = new System.Drawing.Size(50, 17);
            this.gearCheck4.TabIndex = 13;
            this.gearCheck4.Text = "Zeus";
            this.gearCheck4.UseVisualStyleBackColor = true;
            this.gearCheck4.CheckedChanged += new System.EventHandler(this.gearCheck);
            // 
            // gearGroup
            // 
            this.gearGroup.Controls.Add(this.noarmorRadio);
            this.gearGroup.Controls.Add(this.kevlarRadio);
            this.gearGroup.Controls.Add(this.kevlarhelmRadio);
            this.gearGroup.Controls.Add(this.gearCheck4);
            this.gearGroup.Controls.Add(this.gearCheck3);
            this.gearGroup.Location = new System.Drawing.Point(235, 35);
            this.gearGroup.Name = "gearGroup";
            this.gearGroup.Size = new System.Drawing.Size(133, 139);
            this.gearGroup.TabIndex = 14;
            this.gearGroup.TabStop = false;
            this.gearGroup.Text = "Gear:";
            // 
            // noarmorRadio
            // 
            this.noarmorRadio.AutoSize = true;
            this.noarmorRadio.Checked = true;
            this.noarmorRadio.Location = new System.Drawing.Point(6, 19);
            this.noarmorRadio.Name = "noarmorRadio";
            this.noarmorRadio.Size = new System.Drawing.Size(69, 17);
            this.noarmorRadio.TabIndex = 16;
            this.noarmorRadio.TabStop = true;
            this.noarmorRadio.Text = "No Armor";
            this.noarmorRadio.UseVisualStyleBackColor = true;
            // 
            // kevlarRadio
            // 
            this.kevlarRadio.AutoSize = true;
            this.kevlarRadio.Location = new System.Drawing.Point(6, 42);
            this.kevlarRadio.Name = "kevlarRadio";
            this.kevlarRadio.Size = new System.Drawing.Size(55, 17);
            this.kevlarRadio.TabIndex = 15;
            this.kevlarRadio.Text = "Kevlar";
            this.kevlarRadio.UseVisualStyleBackColor = true;
            this.kevlarRadio.CheckedChanged += new System.EventHandler(this.kevlarChecked);
            // 
            // kevlarhelmRadio
            // 
            this.kevlarhelmRadio.AutoSize = true;
            this.kevlarhelmRadio.Location = new System.Drawing.Point(6, 65);
            this.kevlarhelmRadio.Name = "kevlarhelmRadio";
            this.kevlarhelmRadio.Size = new System.Drawing.Size(100, 17);
            this.kevlarhelmRadio.TabIndex = 14;
            this.kevlarhelmRadio.Text = "Kevlar + Helmet";
            this.kevlarhelmRadio.UseVisualStyleBackColor = true;
            this.kevlarhelmRadio.CheckedChanged += new System.EventHandler(this.kevlarChecked);
            // 
            // nadeGroup
            // 
            this.nadeGroup.Controls.Add(this.nadeCheck6);
            this.nadeGroup.Controls.Add(this.nadeCheck5);
            this.nadeGroup.Controls.Add(this.nadeCheck4);
            this.nadeGroup.Controls.Add(this.nadeCheck3);
            this.nadeGroup.Controls.Add(this.nadeCheck2);
            this.nadeGroup.Controls.Add(this.nadeCheck1);
            this.nadeGroup.Location = new System.Drawing.Point(235, 180);
            this.nadeGroup.Name = "nadeGroup";
            this.nadeGroup.Size = new System.Drawing.Size(133, 166);
            this.nadeGroup.TabIndex = 15;
            this.nadeGroup.TabStop = false;
            this.nadeGroup.Text = "Grenades:";
            // 
            // nadeCheck5
            // 
            this.nadeCheck5.Location = new System.Drawing.Point(6, 64);
            this.nadeCheck5.Name = "nadeCheck5";
            this.nadeCheck5.Size = new System.Drawing.Size(90, 17);
            this.nadeCheck5.TabIndex = 4;
            this.nadeCheck5.Text = "Flashbang 2";
            this.nadeCheck5.UseVisualStyleBackColor = true;
            this.nadeCheck5.CheckedChanged += new System.EventHandler(this.nadeCheck);
            // 
            // nadeCheck4
            // 
            this.nadeCheck4.AutoSize = true;
            this.nadeCheck4.Location = new System.Drawing.Point(6, 110);
            this.nadeCheck4.Name = "nadeCheck4";
            this.nadeCheck4.Size = new System.Drawing.Size(41, 17);
            this.nadeCheck4.TabIndex = 3;
            this.nadeCheck4.Text = "HE";
            this.nadeCheck4.UseVisualStyleBackColor = true;
            this.nadeCheck4.CheckedChanged += new System.EventHandler(this.nadeCheck);
            // 
            // nadeCheck3
            // 
            this.nadeCheck3.AutoSize = true;
            this.nadeCheck3.Location = new System.Drawing.Point(6, 87);
            this.nadeCheck3.Name = "nadeCheck3";
            this.nadeCheck3.Size = new System.Drawing.Size(59, 17);
            this.nadeCheck3.TabIndex = 2;
            this.nadeCheck3.Text = "Smoke";
            this.nadeCheck3.UseVisualStyleBackColor = true;
            this.nadeCheck3.CheckedChanged += new System.EventHandler(this.nadeCheck);
            // 
            // nadeCheck2
            // 
            this.nadeCheck2.AutoSize = true;
            this.nadeCheck2.Location = new System.Drawing.Point(6, 41);
            this.nadeCheck2.Name = "nadeCheck2";
            this.nadeCheck2.Size = new System.Drawing.Size(75, 17);
            this.nadeCheck2.TabIndex = 1;
            this.nadeCheck2.Text = "Flashbang";
            this.nadeCheck2.UseVisualStyleBackColor = true;
            this.nadeCheck2.CheckedChanged += new System.EventHandler(this.nadeCheck);
            // 
            // nadeCheck1
            // 
            this.nadeCheck1.AutoSize = true;
            this.nadeCheck1.Location = new System.Drawing.Point(6, 18);
            this.nadeCheck1.Name = "nadeCheck1";
            this.nadeCheck1.Size = new System.Drawing.Size(57, 17);
            this.nadeCheck1.TabIndex = 0;
            this.nadeCheck1.Text = "Decoy";
            this.nadeCheck1.UseVisualStyleBackColor = true;
            this.nadeCheck1.CheckedChanged += new System.EventHandler(this.nadeCheck);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(212, 360);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(55, 23);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Paste the generated code into the console ingame, or paste it into config.cfg fou" +
    "nd in your CSGO folder or into your custom cfg.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(151, 360);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(55, 23);
            this.copyButton.TabIndex = 18;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // primaryGroup
            // 
            this.primaryGroup.Controls.Add(this.heavyList);
            this.primaryGroup.Controls.Add(this.smgList);
            this.primaryGroup.Controls.Add(this.heavysRadio);
            this.primaryGroup.Controls.Add(this.smgsRadio);
            this.primaryGroup.Controls.Add(this.riflesRadio);
            this.primaryGroup.Controls.Add(this.noneRadio);
            this.primaryGroup.Controls.Add(this.primaryList);
            this.primaryGroup.Location = new System.Drawing.Point(15, 91);
            this.primaryGroup.Name = "primaryGroup";
            this.primaryGroup.Size = new System.Drawing.Size(217, 172);
            this.primaryGroup.TabIndex = 19;
            this.primaryGroup.TabStop = false;
            this.primaryGroup.Text = "Primary:";
            // 
            // heavyList
            // 
            this.heavyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.heavyList.Enabled = false;
            this.heavyList.FormattingEnabled = true;
            this.heavyList.Items.AddRange(new object[] {
            "Nova",
            "XM1014",
            "MAG-7",
            "Sawed-Off",
            "M249",
            "Negev"});
            this.heavyList.Location = new System.Drawing.Point(81, 132);
            this.heavyList.Name = "heavyList";
            this.heavyList.Size = new System.Drawing.Size(121, 21);
            this.heavyList.TabIndex = 5;
            this.heavyList.SelectedIndexChanged += new System.EventHandler(this.primaryChanged);
            // 
            // smgList
            // 
            this.smgList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smgList.Enabled = false;
            this.smgList.FormattingEnabled = true;
            this.smgList.Items.AddRange(new object[] {
            "MAC-10",
            "MP9",
            "MP7",
            "UMP-45",
            "P90",
            "PP-Bizon"});
            this.smgList.Location = new System.Drawing.Point(81, 91);
            this.smgList.Name = "smgList";
            this.smgList.Size = new System.Drawing.Size(121, 21);
            this.smgList.TabIndex = 4;
            this.smgList.SelectedIndexChanged += new System.EventHandler(this.primaryChanged);
            // 
            // heavysRadio
            // 
            this.heavysRadio.AutoSize = true;
            this.heavysRadio.Location = new System.Drawing.Point(15, 136);
            this.heavysRadio.Name = "heavysRadio";
            this.heavysRadio.Size = new System.Drawing.Size(64, 17);
            this.heavysRadio.TabIndex = 3;
            this.heavysRadio.Text = "Heavys:";
            this.heavysRadio.UseVisualStyleBackColor = true;
            this.heavysRadio.CheckedChanged += new System.EventHandler(this.primaryChecked);
            // 
            // smgsRadio
            // 
            this.smgsRadio.AutoSize = true;
            this.smgsRadio.Location = new System.Drawing.Point(14, 95);
            this.smgsRadio.Name = "smgsRadio";
            this.smgsRadio.Size = new System.Drawing.Size(57, 17);
            this.smgsRadio.TabIndex = 2;
            this.smgsRadio.Text = "SMGs:";
            this.smgsRadio.UseVisualStyleBackColor = true;
            this.smgsRadio.CheckedChanged += new System.EventHandler(this.primaryChecked);
            // 
            // riflesRadio
            // 
            this.riflesRadio.AutoSize = true;
            this.riflesRadio.Location = new System.Drawing.Point(14, 53);
            this.riflesRadio.Name = "riflesRadio";
            this.riflesRadio.Size = new System.Drawing.Size(54, 17);
            this.riflesRadio.TabIndex = 1;
            this.riflesRadio.Text = "Rifles:";
            this.riflesRadio.UseVisualStyleBackColor = true;
            this.riflesRadio.CheckedChanged += new System.EventHandler(this.primaryChecked);
            // 
            // noneRadio
            // 
            this.noneRadio.AutoSize = true;
            this.noneRadio.Checked = true;
            this.noneRadio.Location = new System.Drawing.Point(14, 19);
            this.noneRadio.Name = "noneRadio";
            this.noneRadio.Size = new System.Drawing.Size(51, 17);
            this.noneRadio.TabIndex = 0;
            this.noneRadio.TabStop = true;
            this.noneRadio.Text = "None";
            this.noneRadio.UseVisualStyleBackColor = true;
            this.noneRadio.CheckedChanged += new System.EventHandler(this.primaryChecked);
            // 
            // secondaryBox
            // 
            this.secondaryBox.Controls.Add(this.secondaryList);
            this.secondaryBox.Controls.Add(this.pistolRadio);
            this.secondaryBox.Controls.Add(this.none2Radio);
            this.secondaryBox.Location = new System.Drawing.Point(15, 269);
            this.secondaryBox.Name = "secondaryBox";
            this.secondaryBox.Size = new System.Drawing.Size(217, 77);
            this.secondaryBox.TabIndex = 20;
            this.secondaryBox.TabStop = false;
            this.secondaryBox.Text = "Secondary:";
            // 
            // pistolRadio
            // 
            this.pistolRadio.AutoSize = true;
            this.pistolRadio.Location = new System.Drawing.Point(15, 44);
            this.pistolRadio.Name = "pistolRadio";
            this.pistolRadio.Size = new System.Drawing.Size(58, 17);
            this.pistolRadio.TabIndex = 1;
            this.pistolRadio.Text = "Pistols:";
            this.pistolRadio.UseVisualStyleBackColor = true;
            this.pistolRadio.CheckedChanged += new System.EventHandler(this.secondaryChecked);
            // 
            // none2Radio
            // 
            this.none2Radio.AutoSize = true;
            this.none2Radio.Checked = true;
            this.none2Radio.Location = new System.Drawing.Point(14, 19);
            this.none2Radio.Name = "none2Radio";
            this.none2Radio.Size = new System.Drawing.Size(51, 17);
            this.none2Radio.TabIndex = 0;
            this.none2Radio.TabStop = true;
            this.none2Radio.Text = "None";
            this.none2Radio.UseVisualStyleBackColor = true;
            this.none2Radio.CheckedChanged += new System.EventHandler(this.secondaryChecked);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(273, 365);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(58, 13);
            this.costLabel.TabIndex = 21;
            this.costLabel.Text = "Total Cost:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.ForeColor = System.Drawing.Color.Green;
            this.priceLabel.Location = new System.Drawing.Point(328, 365);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(19, 13);
            this.priceLabel.TabIndex = 22;
            this.priceLabel.Text = "$0";
            // 
            // infoLink
            // 
            this.infoLink.AutoSize = true;
            this.infoLink.Location = new System.Drawing.Point(332, 26);
            this.infoLink.Name = "infoLink";
            this.infoLink.Size = new System.Drawing.Size(35, 13);
            this.infoLink.TabIndex = 24;
            this.infoLink.TabStop = true;
            this.infoLink.Text = "About";
            this.infoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutClicked);
            // 
            // selectkeyButton
            // 
            this.selectkeyButton.Location = new System.Drawing.Point(12, 35);
            this.selectkeyButton.Name = "selectkeyButton";
            this.selectkeyButton.Size = new System.Drawing.Size(114, 23);
            this.selectkeyButton.TabIndex = 25;
            this.selectkeyButton.Text = "Select a key...";
            this.selectkeyButton.UseVisualStyleBackColor = true;
            this.selectkeyButton.Click += new System.EventHandler(this.selectkeyButton_Click);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.ForeColor = System.Drawing.Color.Red;
            this.keyLabel.Location = new System.Drawing.Point(81, 64);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(33, 13);
            this.keyLabel.TabIndex = 26;
            this.keyLabel.Text = "None";
            this.keyLabel.TextChanged += new System.EventHandler(this.keyChanged);
            // 
            // nadeCheck6
            // 
            this.nadeCheck6.AutoSize = true;
            this.nadeCheck6.Location = new System.Drawing.Point(6, 133);
            this.nadeCheck6.Name = "nadeCheck6";
            this.nadeCheck6.Size = new System.Drawing.Size(124, 17);
            this.nadeCheck6.TabIndex = 5;
            this.nadeCheck6.Text = "Incendiary / Molotov";
            this.nadeCheck6.UseVisualStyleBackColor = true;
            this.nadeCheck6.CheckedChanged += new System.EventHandler(this.nadeCheck);
            // 
            // createCfg
            // 
            this.createCfg.Location = new System.Drawing.Point(12, 360);
            this.createCfg.Name = "createCfg";
            this.createCfg.Size = new System.Drawing.Size(72, 23);
            this.createCfg.TabIndex = 27;
            this.createCfg.Text = "Create Cfg";
            this.createCfg.UseVisualStyleBackColor = true;
            this.createCfg.Click += new System.EventHandler(this.createCfg_Click);
            // 
            // saveToCfg
            // 
            this.saveToCfg.Location = new System.Drawing.Point(90, 360);
            this.saveToCfg.Name = "saveToCfg";
            this.saveToCfg.Size = new System.Drawing.Size(55, 23);
            this.saveToCfg.TabIndex = 28;
            this.saveToCfg.Text = "Save";
            this.saveToCfg.UseVisualStyleBackColor = true;
            this.saveToCfg.Click += new System.EventHandler(this.saveToCfg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // changelogLink
            // 
            this.changelogLink.AutoSize = true;
            this.changelogLink.Location = new System.Drawing.Point(273, 26);
            this.changelogLink.Name = "changelogLink";
            this.changelogLink.Size = new System.Drawing.Size(58, 13);
            this.changelogLink.TabIndex = 29;
            this.changelogLink.TabStop = true;
            this.changelogLink.Text = "Changelog";
            this.changelogLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changelogLink_LinkClicked);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(129, 35);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(103, 26);
            this.noteLabel.TabIndex = 23;
            this.noteLabel.Text = "You should probably\r\nselect a key.";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(382, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem,
            this.steamToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(48, 22);
            this.toolStripDropDownButton1.Text = "More";
            this.toolStripDropDownButton1.ToolTipText = "More";
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("githubToolStripMenuItem.Image")));
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // steamToolStripMenuItem
            // 
            this.steamToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("steamToolStripMenuItem.Image")));
            this.steamToolStripMenuItem.Name = "steamToolStripMenuItem";
            this.steamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.steamToolStripMenuItem.Text = "Steam";
            this.steamToolStripMenuItem.Click += new System.EventHandler(this.steamToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 476);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.changelogLink);
            this.Controls.Add(this.saveToCfg);
            this.Controls.Add(this.createCfg);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.selectkeyButton);
            this.Controls.Add(this.infoLink);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.secondaryBox);
            this.Controls.Add(this.primaryGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nadeGroup);
            this.Controls.Add(this.gearGroup);
            this.Controls.Add(this.keysLabel);
            this.Controls.Add(this.resultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSGO Buy Bind Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gearGroup.ResumeLayout(false);
            this.gearGroup.PerformLayout();
            this.nadeGroup.ResumeLayout(false);
            this.nadeGroup.PerformLayout();
            this.primaryGroup.ResumeLayout(false);
            this.primaryGroup.PerformLayout();
            this.secondaryBox.ResumeLayout(false);
            this.secondaryBox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox primaryList;
        private System.Windows.Forms.ComboBox secondaryList;
        private System.Windows.Forms.TextBox resultBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label keysLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.CheckBox gearCheck3;
        private System.Windows.Forms.CheckBox gearCheck4;
        private System.Windows.Forms.GroupBox gearGroup;
        private System.Windows.Forms.GroupBox nadeGroup;
        private System.Windows.Forms.CheckBox nadeCheck5;
        private System.Windows.Forms.CheckBox nadeCheck4;
        private System.Windows.Forms.CheckBox nadeCheck3;
        private System.Windows.Forms.CheckBox nadeCheck2;
        private System.Windows.Forms.CheckBox nadeCheck1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.GroupBox primaryGroup;
        private System.Windows.Forms.RadioButton heavysRadio;
        private System.Windows.Forms.RadioButton smgsRadio;
        private System.Windows.Forms.RadioButton riflesRadio;
        private System.Windows.Forms.RadioButton noneRadio;
        private System.Windows.Forms.GroupBox secondaryBox;
        private System.Windows.Forms.RadioButton pistolRadio;
        private System.Windows.Forms.RadioButton none2Radio;
        private System.Windows.Forms.ComboBox heavyList;
        private System.Windows.Forms.ComboBox smgList;
        private System.Windows.Forms.RadioButton kevlarRadio;
        private System.Windows.Forms.RadioButton kevlarhelmRadio;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.RadioButton noarmorRadio;
        private System.Windows.Forms.LinkLabel infoLink;
        private System.Windows.Forms.Button selectkeyButton;
        public System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.CheckBox nadeCheck6;
        private System.Windows.Forms.Button createCfg;
        private System.Windows.Forms.Button saveToCfg;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel changelogLink;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steamToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

