namespace VIESApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVNumber = new System.Windows.Forms.TextBox();
            this.btnVCheck = new System.Windows.Forms.Button();
            this.cbVCountry = new System.Windows.Forms.ComboBox();
            this.labVNumber = new System.Windows.Forms.Label();
            this.labVCountry = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labVACountry = new System.Windows.Forms.Label();
            this.labVANumber = new System.Windows.Forms.Label();
            this.btnVACheck = new System.Windows.Forms.Button();
            this.btnVAXml = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVNumber);
            this.groupBox1.Controls.Add(this.btnVCheck);
            this.groupBox1.Controls.Add(this.cbVCountry);
            this.groupBox1.Controls.Add(this.labVNumber);
            this.groupBox1.Controls.Add(this.labVCountry);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(7, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CheckVat";
            this.toolTip1.SetToolTip(this.groupBox1, "Checkvat\r\n");
            // 
            // txtVNumber
            // 
            this.txtVNumber.Location = new System.Drawing.Point(10, 124);
            this.txtVNumber.Name = "txtVNumber";
            this.txtVNumber.Size = new System.Drawing.Size(145, 21);
            this.txtVNumber.TabIndex = 7;
            // 
            // btnVCheck
            // 
            this.btnVCheck.Location = new System.Drawing.Point(37, 186);
            this.btnVCheck.Name = "btnVCheck";
            this.btnVCheck.Size = new System.Drawing.Size(117, 48);
            this.btnVCheck.TabIndex = 6;
            this.btnVCheck.Text = "CheckValid";
            this.btnVCheck.UseVisualStyleBackColor = true;
            this.btnVCheck.Click += new System.EventHandler(this.btnVCheck_Click);
            // 
            // cbVCountry
            // 
            this.cbVCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVCountry.FormattingEnabled = true;
            this.cbVCountry.Location = new System.Drawing.Point(10, 49);
            this.cbVCountry.Name = "cbVCountry";
            this.cbVCountry.Size = new System.Drawing.Size(145, 23);
            this.cbVCountry.TabIndex = 5;
            // 
            // labVNumber
            // 
            this.labVNumber.AutoSize = true;
            this.labVNumber.Location = new System.Drawing.Point(10, 94);
            this.labVNumber.Name = "labVNumber";
            this.labVNumber.Size = new System.Drawing.Size(74, 15);
            this.labVNumber.TabIndex = 4;
            this.labVNumber.Text = "Numer Vat";
            // 
            // labVCountry
            // 
            this.labVCountry.AutoSize = true;
            this.labVCountry.Location = new System.Drawing.Point(6, 26);
            this.labVCountry.Name = "labVCountry";
            this.labVCountry.Size = new System.Drawing.Size(150, 15);
            this.labVCountry.TabIndex = 3;
            this.labVCountry.Text = "Państwo członkowskie";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVAXml);
            this.groupBox2.Controls.Add(this.btnVACheck);
            this.groupBox2.Controls.Add(this.labVANumber);
            this.groupBox2.Controls.Add(this.labVACountry);
            this.groupBox2.Location = new System.Drawing.Point(239, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 384);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check Vat Approx";
            // 
            // labTitle
            // 
            this.labTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTitle.Location = new System.Drawing.Point(12, 19);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(831, 18);
            this.labTitle.TabIndex = 2;
            this.labTitle.Text = "Weryfikacja numerów identyfikacyjnych VAT podmiotów gospodarczych zarejestrowanyc" +
    "h w Unii Europejskiej";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labVACountry
            // 
            this.labVACountry.AutoSize = true;
            this.labVACountry.Location = new System.Drawing.Point(41, 45);
            this.labVACountry.Name = "labVACountry";
            this.labVACountry.Size = new System.Drawing.Size(35, 13);
            this.labVACountry.TabIndex = 0;
            this.labVACountry.Text = "label1";
            // 
            // labVANumber
            // 
            this.labVANumber.AutoSize = true;
            this.labVANumber.Location = new System.Drawing.Point(48, 122);
            this.labVANumber.Name = "labVANumber";
            this.labVANumber.Size = new System.Drawing.Size(35, 13);
            this.labVANumber.TabIndex = 1;
            this.labVANumber.Text = "label2";
            // 
            // btnVACheck
            // 
            this.btnVACheck.Location = new System.Drawing.Point(80, 288);
            this.btnVACheck.Name = "btnVACheck";
            this.btnVACheck.Size = new System.Drawing.Size(75, 23);
            this.btnVACheck.TabIndex = 2;
            this.btnVACheck.Text = "Weryfikacja";
            this.btnVACheck.UseVisualStyleBackColor = true;
            this.btnVACheck.Click += new System.EventHandler(this.btnVACheck_Click);
            // 
            // btnVAXml
            // 
            this.btnVAXml.Location = new System.Drawing.Point(460, 302);
            this.btnVAXml.Name = "btnVAXml";
            this.btnVAXml.Size = new System.Drawing.Size(75, 23);
            this.btnVAXml.TabIndex = 3;
            this.btnVAXml.Text = "Zapisz";
            this.btnVAXml.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VIES Vat Check";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labVCountry;
        private System.Windows.Forms.ComboBox cbVCountry;
        private System.Windows.Forms.Label labVNumber;
        private System.Windows.Forms.Button btnVCheck;
        private System.Windows.Forms.TextBox txtVNumber;
        private System.Windows.Forms.Button btnVAXml;
        private System.Windows.Forms.Button btnVACheck;
        private System.Windows.Forms.Label labVANumber;
        private System.Windows.Forms.Label labVACountry;
    }
}

