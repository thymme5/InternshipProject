#pragma warning disable

namespace VerklaringVanOntvangst
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
            this.lblName = new System.Windows.Forms.Label();
            this._Nametxtbx = new System.Windows.Forms.TextBox();
            this._TypeInput = new System.Windows.Forms.ComboBox();
            this._DeviceType = new System.Windows.Forms.ComboBox();
            this._Device = new System.Windows.Forms.Label();
            this._DeviceTxtbx = new System.Windows.Forms.TextBox();
            this._SerialnumberInputlbl = new System.Windows.Forms.Label();
            this._SerialnrInput = new System.Windows.Forms.TextBox();
            this._IDinput = new System.Windows.Forms.TextBox();
            this._IDlbl = new System.Windows.Forms.Label();
            this.btnDOCX = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.lblSaveAs = new System.Windows.Forms.Label();
            this._DocumentNametxtbox = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtboxPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._OpenFileCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testKnopInschakelenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackVerzendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(131, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Naam ondergetekende:";
            // 
            // _Nametxtbx
            // 
            this._Nametxtbx.Location = new System.Drawing.Point(177, 71);
            this._Nametxtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._Nametxtbx.MaxLength = 40;
            this._Nametxtbx.Name = "_Nametxtbx";
            this._Nametxtbx.Size = new System.Drawing.Size(217, 23);
            this._Nametxtbx.TabIndex = 3;
            // 
            // _TypeInput
            // 
            this._TypeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._TypeInput.FormattingEnabled = true;
            this._TypeInput.Items.AddRange(new object[] {
            "Ontvangst",
            "Teruggave"});
            this._TypeInput.Location = new System.Drawing.Point(58, 37);
            this._TypeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._TypeInput.Name = "_TypeInput";
            this._TypeInput.Size = new System.Drawing.Size(146, 23);
            this._TypeInput.TabIndex = 1;
            // 
            // _DeviceType
            // 
            this._DeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._DeviceType.ForeColor = System.Drawing.SystemColors.WindowText;
            this._DeviceType.FormattingEnabled = true;
            this._DeviceType.Items.AddRange(new object[] {
            "Laptop",
            "Tablet",
            "GSM"});
            this._DeviceType.Location = new System.Drawing.Point(228, 37);
            this._DeviceType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._DeviceType.Name = "_DeviceType";
            this._DeviceType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._DeviceType.Size = new System.Drawing.Size(133, 23);
            this._DeviceType.TabIndex = 2;
            // 
            // _Device
            // 
            this._Device.AutoSize = true;
            this._Device.Location = new System.Drawing.Point(27, 98);
            this._Device.Name = "_Device";
            this._Device.Size = new System.Drawing.Size(61, 15);
            this._Device.TabIndex = 4;
            this._Device.Text = "Apparaat: ";
            // 
            // _DeviceTxtbx
            // 
            this._DeviceTxtbx.Location = new System.Drawing.Point(177, 98);
            this._DeviceTxtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._DeviceTxtbx.MaxLength = 40;
            this._DeviceTxtbx.Name = "_DeviceTxtbx";
            this._DeviceTxtbx.Size = new System.Drawing.Size(217, 23);
            this._DeviceTxtbx.TabIndex = 4;
            // 
            // _SerialnumberInputlbl
            // 
            this._SerialnumberInputlbl.AutoSize = true;
            this._SerialnumberInputlbl.Location = new System.Drawing.Point(27, 123);
            this._SerialnumberInputlbl.Name = "_SerialnumberInputlbl";
            this._SerialnumberInputlbl.Size = new System.Drawing.Size(84, 15);
            this._SerialnumberInputlbl.TabIndex = 6;
            this._SerialnumberInputlbl.Text = "Serienummer: ";
            // 
            // _SerialnrInput
            // 
            this._SerialnrInput.Location = new System.Drawing.Point(177, 121);
            this._SerialnrInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._SerialnrInput.MaxLength = 11;
            this._SerialnrInput.Name = "_SerialnrInput";
            this._SerialnrInput.Size = new System.Drawing.Size(217, 23);
            this._SerialnrInput.TabIndex = 5;
            // 
            // _IDinput
            // 
            this._IDinput.Location = new System.Drawing.Point(177, 146);
            this._IDinput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._IDinput.MaxLength = 11;
            this._IDinput.Name = "_IDinput";
            this._IDinput.Size = new System.Drawing.Size(217, 23);
            this._IDinput.TabIndex = 6;
            this._IDinput.TextChanged += new System.EventHandler(this._IDinput_TextChanged);
            this._IDinput.KeyDown += new System.Windows.Forms.KeyEventHandler(this._IDinput_KeyDown);
            this._IDinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._IDinput_KeyPress);
            // 
            // _IDlbl
            // 
            this._IDlbl.AutoSize = true;
            this._IDlbl.Location = new System.Drawing.Point(27, 148);
            this._IDlbl.Name = "_IDlbl";
            this._IDlbl.Size = new System.Drawing.Size(24, 15);
            this._IDlbl.TabIndex = 9;
            this._IDlbl.Text = "ID: ";
            // 
            // btnDOCX
            // 
            this.btnDOCX.Location = new System.Drawing.Point(156, 254);
            this.btnDOCX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDOCX.Name = "btnDOCX";
            this.btnDOCX.Size = new System.Drawing.Size(120, 22);
            this.btnDOCX.TabIndex = 8;
            this.btnDOCX.Text = ".docx";
            this.btnDOCX.UseVisualStyleBackColor = true;
            this.btnDOCX.Click += new System.EventHandler(this.btnDOCX_Click_1);
            // 
            // btnPDF
            // 
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPDF.Location = new System.Drawing.Point(156, 294);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(120, 22);
            this.btnPDF.TabIndex = 9;
            this.btnPDF.TabStop = false;
            this.btnPDF.Text = ".pdf";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // lblSaveAs
            // 
            this.lblSaveAs.AutoSize = true;
            this.lblSaveAs.Location = new System.Drawing.Point(27, 172);
            this.lblSaveAs.Name = "lblSaveAs";
            this.lblSaveAs.Size = new System.Drawing.Size(73, 15);
            this.lblSaveAs.TabIndex = 12;
            this.lblSaveAs.Text = "Opslaan als: ";
            // 
            // _DocumentNametxtbox
            // 
            this._DocumentNametxtbox.Location = new System.Drawing.Point(177, 170);
            this._DocumentNametxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._DocumentNametxtbox.MaxLength = 221;
            this._DocumentNametxtbox.Name = "_DocumentNametxtbox";
            this._DocumentNametxtbox.Size = new System.Drawing.Size(217, 23);
            this._DocumentNametxtbox.TabIndex = 7;
            this._DocumentNametxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._DocumentNametxtbox_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(281, 254);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 22);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Verwijder";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTest
            // 
            this.btnTest.Enabled = false;
            this.btnTest.Location = new System.Drawing.Point(27, 253);
            this.btnTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(120, 22);
            this.btnTest.TabIndex = 14;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(27, 200);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(33, 15);
            this.lblPath.TabIndex = 15;
            this.lblPath.Text = "Pad: ";
            // 
            // txtboxPath
            // 
            this.txtboxPath.Location = new System.Drawing.Point(177, 198);
            this.txtboxPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxPath.Name = "txtboxPath";
            this.txtboxPath.ReadOnly = true;
            this.txtboxPath.Size = new System.Drawing.Size(183, 23);
            this.txtboxPath.TabIndex = 16;
            // 
            // btnPath
            // 
            this.btnPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPath.CausesValidation = false;
            this.btnPath.Image = global::VerklaringVanOntvangst.Properties.Resources.folder_win101;
            this.btnPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPath.Location = new System.Drawing.Point(365, 198);
            this.btnPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(28, 20);
            this.btnPath.TabIndex = 17;
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // _OpenFileCheckBox
            // 
            this._OpenFileCheckBox.AutoSize = true;
            this._OpenFileCheckBox.Checked = true;
            this._OpenFileCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._OpenFileCheckBox.Location = new System.Drawing.Point(177, 223);
            this._OpenFileCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._OpenFileCheckBox.Name = "_OpenFileCheckBox";
            this._OpenFileCheckBox.Size = new System.Drawing.Size(182, 19);
            this._OpenFileCheckBox.TabIndex = 18;
            this._OpenFileCheckBox.Text = "Automatisch bestand openen";
            this._OpenFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem1,
            this.optiesToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(412, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem1
            // 
            this.bestandToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem1});
            this.bestandToolStripMenuItem1.Name = "bestandToolStripMenuItem1";
            this.bestandToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem1.Text = "&Bestand";
            // 
            // afsluitenToolStripMenuItem1
            // 
            this.afsluitenToolStripMenuItem1.Name = "afsluitenToolStripMenuItem1";
            this.afsluitenToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.afsluitenToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.afsluitenToolStripMenuItem1.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem1.Click += new System.EventHandler(this.afsluitenToolStripMenuItem1_Click);
            // 
            // optiesToolStripMenuItem
            // 
            this.optiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testKnopInschakelenToolStripMenuItem});
            this.optiesToolStripMenuItem.Name = "optiesToolStripMenuItem";
            this.optiesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.optiesToolStripMenuItem.Text = "&Opties";
            // 
            // testKnopInschakelenToolStripMenuItem
            // 
            this.testKnopInschakelenToolStripMenuItem.CheckOnClick = true;
            this.testKnopInschakelenToolStripMenuItem.Name = "testKnopInschakelenToolStripMenuItem";
            this.testKnopInschakelenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.testKnopInschakelenToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.testKnopInschakelenToolStripMenuItem.Text = "Test knop tonen";
            this.testKnopInschakelenToolStripMenuItem.Click += new System.EventHandler(this.testKnopInschakelenToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feedbackVerzendenToolStripMenuItem,
            this.toolStripMenuItem1});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // feedbackVerzendenToolStripMenuItem
            // 
            this.feedbackVerzendenToolStripMenuItem.Name = "feedbackVerzendenToolStripMenuItem";
            this.feedbackVerzendenToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.feedbackVerzendenToolStripMenuItem.Text = "Feedback Verzenden";
            this.feedbackVerzendenToolStripMenuItem.Click += new System.EventHandler(this.feedbackVerzendenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "Help";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(412, 280);
            this.Controls.Add(this._OpenFileCheckBox);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtboxPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this._DocumentNametxtbox);
            this.Controls.Add(this.lblSaveAs);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnDOCX);
            this.Controls.Add(this._IDlbl);
            this.Controls.Add(this._IDinput);
            this.Controls.Add(this._SerialnrInput);
            this.Controls.Add(this._SerialnumberInputlbl);
            this.Controls.Add(this._DeviceTxtbx);
            this.Controls.Add(this._Device);
            this.Controls.Add(this._DeviceType);
            this.Controls.Add(this._TypeInput);
            this.Controls.Add(this._Nametxtbx);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internship Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        Label lblName;
        private TextBox _Nametxtbx;
        private Label _Name;
        private TextBox _naamInput;
        private ComboBox _typeDropdown;
        private ComboBox _TypeInput;
        private ComboBox _DeviceType;
        private Label _Device;
        private TextBox _DeviceTxtbx;
        private Label _SerialnumberInputlbl;
        private TextBox _SerialnrInput;
        private TextBox _IDinput;
        private Label _IDlbl;
        private Button btnDOCX;
        private Button btnPDF;
        private Label lblSaveAs;
        private TextBox _DocumentNametxtbox;
        private Button btnDelete;
        private Button btnTest;
        private Label lblPath;
        private TextBox txtboxPath;
        private Button btnPath;
        private ToolStripMenuItem bestandToolStripMenuItem;
        private ToolStripMenuItem afsluitenToolStripMenuItem;
        private CheckBox _OpenFileCheckBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bestandToolStripMenuItem1;
        private ToolStripMenuItem afsluitenToolStripMenuItem1;
        private ToolTip toolTip1;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem feedbackVerzendenToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem optiesToolStripMenuItem;
        private ToolStripMenuItem testKnopInschakelenToolStripMenuItem;
    }
}