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
            this.btnVAXml = new System.Windows.Forms.Button();
            this.btnVACheck = new System.Windows.Forms.Button();
            this.labVANumber = new System.Windows.Forms.Label();
            this.labVACountry = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labVACountryRequester = new System.Windows.Forms.Label();
            this.labVANumberRequester = new System.Windows.Forms.Label();
            this.cbVACountry = new System.Windows.Forms.ComboBox();
            this.txtVANumber = new System.Windows.Forms.TextBox();
            this.cbVACountryRequester = new System.Windows.Forms.ComboBox();
            this.txtVANumberRequester = new System.Windows.Forms.TextBox();
            this.labVAValid = new System.Windows.Forms.Label();
            this.labVAName = new System.Windows.Forms.Label();
            this.labVAAdress = new System.Windows.Forms.Label();
            this.labVAId = new System.Windows.Forms.Label();
            this.txtVAValid = new System.Windows.Forms.TextBox();
            this.txtVAName = new System.Windows.Forms.TextBox();
            this.txtVAAdress = new System.Windows.Forms.TextBox();
            this.txtVAId = new System.Windows.Forms.TextBox();
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
            this.groupBox2.Controls.Add(this.txtVAId);
            this.groupBox2.Controls.Add(this.txtVAAdress);
            this.groupBox2.Controls.Add(this.txtVAName);
            this.groupBox2.Controls.Add(this.txtVAValid);
            this.groupBox2.Controls.Add(this.labVAId);
            this.groupBox2.Controls.Add(this.labVAAdress);
            this.groupBox2.Controls.Add(this.labVAName);
            this.groupBox2.Controls.Add(this.labVAValid);
            this.groupBox2.Controls.Add(this.txtVANumberRequester);
            this.groupBox2.Controls.Add(this.cbVACountryRequester);
            this.groupBox2.Controls.Add(this.txtVANumber);
            this.groupBox2.Controls.Add(this.cbVACountry);
            this.groupBox2.Controls.Add(this.labVANumberRequester);
            this.groupBox2.Controls.Add(this.labVACountryRequester);
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
            // btnVAXml
            // 
            this.btnVAXml.Location = new System.Drawing.Point(460, 302);
            this.btnVAXml.Name = "btnVAXml";
            this.btnVAXml.Size = new System.Drawing.Size(75, 23);
            this.btnVAXml.TabIndex = 3;
            this.btnVAXml.Text = "Zapisz";
            this.btnVAXml.UseVisualStyleBackColor = true;
            // 
            // btnVACheck
            // 
            this.btnVACheck.Location = new System.Drawing.Point(38, 311);
            this.btnVACheck.Name = "btnVACheck";
            this.btnVACheck.Size = new System.Drawing.Size(75, 23);
            this.btnVACheck.TabIndex = 2;
            this.btnVACheck.Text = "Weryfikacja";
            this.btnVACheck.UseVisualStyleBackColor = true;
            this.btnVACheck.Click += new System.EventHandler(this.btnVACheck_Click);
            // 
            // labVANumber
            // 
            this.labVANumber.AutoSize = true;
            this.labVANumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVANumber.Location = new System.Drawing.Point(6, 94);
            this.labVANumber.Name = "labVANumber";
            this.labVANumber.Size = new System.Drawing.Size(74, 15);
            this.labVANumber.TabIndex = 1;
            this.labVANumber.Text = "Numer Vat";
            // 
            // labVACountry
            // 
            this.labVACountry.AutoSize = true;
            this.labVACountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVACountry.Location = new System.Drawing.Point(6, 28);
            this.labVACountry.Name = "labVACountry";
            this.labVACountry.Size = new System.Drawing.Size(150, 15);
            this.labVACountry.TabIndex = 0;
            this.labVACountry.Text = "Państwo członkowskie";
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
            // labVACountryRequester
            // 
            this.labVACountryRequester.AutoSize = true;
            this.labVACountryRequester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVACountryRequester.Location = new System.Drawing.Point(6, 161);
            this.labVACountryRequester.MaximumSize = new System.Drawing.Size(150, 0);
            this.labVACountryRequester.Name = "labVACountryRequester";
            this.labVACountryRequester.Size = new System.Drawing.Size(150, 30);
            this.labVACountryRequester.TabIndex = 4;
            this.labVACountryRequester.Text = "Państwo członkowskie pytającego";
            // 
            // labVANumberRequester
            // 
            this.labVANumberRequester.AutoSize = true;
            this.labVANumberRequester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVANumberRequester.Location = new System.Drawing.Point(6, 243);
            this.labVANumberRequester.Name = "labVANumberRequester";
            this.labVANumberRequester.Size = new System.Drawing.Size(147, 15);
            this.labVANumberRequester.TabIndex = 5;
            this.labVANumberRequester.Text = "Numer Vat pytającego";
            // 
            // cbVACountry
            // 
            this.cbVACountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVACountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbVACountry.FormattingEnabled = true;
            this.cbVACountry.Location = new System.Drawing.Point(8, 49);
            this.cbVACountry.Name = "cbVACountry";
            this.cbVACountry.Size = new System.Drawing.Size(145, 23);
            this.cbVACountry.TabIndex = 6;
            // 
            // txtVANumber
            // 
            this.txtVANumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVANumber.Location = new System.Drawing.Point(8, 124);
            this.txtVANumber.Name = "txtVANumber";
            this.txtVANumber.Size = new System.Drawing.Size(145, 21);
            this.txtVANumber.TabIndex = 8;
            // 
            // cbVACountryRequester
            // 
            this.cbVACountryRequester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVACountryRequester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbVACountryRequester.FormattingEnabled = true;
            this.cbVACountryRequester.Location = new System.Drawing.Point(9, 200);
            this.cbVACountryRequester.Name = "cbVACountryRequester";
            this.cbVACountryRequester.Size = new System.Drawing.Size(145, 23);
            this.cbVACountryRequester.TabIndex = 9;
            // 
            // txtVANumberRequester
            // 
            this.txtVANumberRequester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVANumberRequester.Location = new System.Drawing.Point(9, 274);
            this.txtVANumberRequester.Name = "txtVANumberRequester";
            this.txtVANumberRequester.Size = new System.Drawing.Size(145, 21);
            this.txtVANumberRequester.TabIndex = 10;
            // 
            // labVAValid
            // 
            this.labVAValid.AutoSize = true;
            this.labVAValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVAValid.Location = new System.Drawing.Point(323, 28);
            this.labVAValid.Name = "labVAValid";
            this.labVAValid.Size = new System.Drawing.Size(109, 15);
            this.labVAValid.TabIndex = 11;
            this.labVAValid.Text = "Poprawność Vat";
            // 
            // labVAName
            // 
            this.labVAName.AutoSize = true;
            this.labVAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVAName.Location = new System.Drawing.Point(323, 94);
            this.labVAName.Name = "labVAName";
            this.labVAName.Size = new System.Drawing.Size(92, 15);
            this.labVAName.TabIndex = 12;
            this.labVAName.Text = "Nazwa spółki";
            // 
            // labVAAdress
            // 
            this.labVAAdress.AutoSize = true;
            this.labVAAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVAAdress.Location = new System.Drawing.Point(323, 161);
            this.labVAAdress.Name = "labVAAdress";
            this.labVAAdress.Size = new System.Drawing.Size(85, 15);
            this.labVAAdress.TabIndex = 13;
            this.labVAAdress.Text = "Adres spółki";
            // 
            // labVAId
            // 
            this.labVAId.AutoSize = true;
            this.labVAId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVAId.Location = new System.Drawing.Point(323, 243);
            this.labVAId.Name = "labVAId";
            this.labVAId.Size = new System.Drawing.Size(85, 15);
            this.labVAId.TabIndex = 14;
            this.labVAId.Text = "Identyfikator";
            // 
            // txtVAValid
            // 
            this.txtVAValid.Location = new System.Drawing.Point(326, 52);
            this.txtVAValid.Name = "txtVAValid";
            this.txtVAValid.ReadOnly = true;
            this.txtVAValid.Size = new System.Drawing.Size(275, 20);
            this.txtVAValid.TabIndex = 15;
            // 
            // txtVAName
            // 
            this.txtVAName.Location = new System.Drawing.Point(326, 124);
            this.txtVAName.Name = "txtVAName";
            this.txtVAName.ReadOnly = true;
            this.txtVAName.Size = new System.Drawing.Size(275, 20);
            this.txtVAName.TabIndex = 16;
            // 
            // txtVAAdress
            // 
            this.txtVAAdress.Location = new System.Drawing.Point(326, 186);
            this.txtVAAdress.Multiline = true;
            this.txtVAAdress.Name = "txtVAAdress";
            this.txtVAAdress.ReadOnly = true;
            this.txtVAAdress.Size = new System.Drawing.Size(275, 37);
            this.txtVAAdress.TabIndex = 17;
            // 
            // txtVAId
            // 
            this.txtVAId.Location = new System.Drawing.Point(326, 274);
            this.txtVAId.Name = "txtVAId";
            this.txtVAId.ReadOnly = true;
            this.txtVAId.Size = new System.Drawing.Size(275, 20);
            this.txtVAId.TabIndex = 18;
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
        private System.Windows.Forms.Label labVANumberRequester;
        private System.Windows.Forms.Label labVACountryRequester;
        private System.Windows.Forms.TextBox txtVANumberRequester;
        private System.Windows.Forms.ComboBox cbVACountryRequester;
        private System.Windows.Forms.TextBox txtVANumber;
        private System.Windows.Forms.ComboBox cbVACountry;
        private System.Windows.Forms.Label labVAId;
        private System.Windows.Forms.Label labVAAdress;
        private System.Windows.Forms.Label labVAName;
        private System.Windows.Forms.Label labVAValid;
        private System.Windows.Forms.TextBox txtVAId;
        private System.Windows.Forms.TextBox txtVAAdress;
        private System.Windows.Forms.TextBox txtVAName;
        private System.Windows.Forms.TextBox txtVAValid;
    }
}

