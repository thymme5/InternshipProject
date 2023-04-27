namespace VerklaringVanOntvangst
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.txtboxSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxBody = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.radioBtnSuggestion = new System.Windows.Forms.RadioButton();
            this.radiobtnProblem = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Naam:";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(185, 75);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(257, 27);
            this.txtboxName.TabIndex = 1;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFeedback.Location = new System.Drawing.Point(12, 9);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(191, 54);
            this.lblFeedback.TabIndex = 2;
            this.lblFeedback.Text = "Feedback";
            // 
            // txtboxSubject
            // 
            this.txtboxSubject.Location = new System.Drawing.Point(185, 113);
            this.txtboxSubject.Name = "txtboxSubject";
            this.txtboxSubject.Size = new System.Drawing.Size(257, 27);
            this.txtboxSubject.TabIndex = 3;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(12, 116);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(172, 20);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Samenvatting feedback: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "gedetailleerde uitleg\r\n(optioneel)";
            // 
            // txtboxBody
            // 
            this.txtboxBody.Location = new System.Drawing.Point(185, 207);
            this.txtboxBody.Multiline = true;
            this.txtboxBody.Name = "txtboxBody";
            this.txtboxBody.PlaceholderText = "Geef zoveel mogelijk gegevens.";
            this.txtboxBody.Size = new System.Drawing.Size(257, 150);
            this.txtboxBody.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(315, 381);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(127, 54);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Verzenden";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // radioBtnSuggestion
            // 
            this.radioBtnSuggestion.AutoSize = true;
            this.radioBtnSuggestion.Location = new System.Drawing.Point(3, 3);
            this.radioBtnSuggestion.Name = "radioBtnSuggestion";
            this.radioBtnSuggestion.Size = new System.Drawing.Size(95, 24);
            this.radioBtnSuggestion.TabIndex = 8;
            this.radioBtnSuggestion.TabStop = true;
            this.radioBtnSuggestion.Text = "Suggestie";
            this.radioBtnSuggestion.UseVisualStyleBackColor = true;
            // 
            // radiobtnProblem
            // 
            this.radiobtnProblem.AutoSize = true;
            this.radiobtnProblem.Location = new System.Drawing.Point(104, 3);
            this.radiobtnProblem.Name = "radiobtnProblem";
            this.radiobtnProblem.Size = new System.Drawing.Size(94, 24);
            this.radiobtnProblem.TabIndex = 9;
            this.radiobtnProblem.TabStop = true;
            this.radiobtnProblem.Text = "Probleem";
            this.radiobtnProblem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtnSuggestion);
            this.panel1.Controls.Add(this.radiobtnProblem);
            this.panel1.Location = new System.Drawing.Point(185, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 31);
            this.panel1.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtboxBody);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtboxSubject);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Feedback ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private TextBox txtboxName;
        private Label lblFeedback;
        private TextBox txtboxSubject;
        private Label lblSubject;
        private Label label1;
        private TextBox txtboxBody;
        private Button btnSend;
        private RadioButton radioBtnSuggestion;
        private RadioButton radiobtnProblem;
        private Panel panel1;
    }
}