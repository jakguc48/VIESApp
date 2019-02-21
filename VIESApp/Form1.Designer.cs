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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVAVat = new System.Windows.Forms.TextBox();
            this.txtVAId = new System.Windows.Forms.TextBox();
            this.txtVAAdress = new System.Windows.Forms.TextBox();
            this.txtVAName = new System.Windows.Forms.TextBox();
            this.txtVAValid = new System.Windows.Forms.TextBox();
            this.labVAId = new System.Windows.Forms.Label();
            this.labVAAdress = new System.Windows.Forms.Label();
            this.labVAName = new System.Windows.Forms.Label();
            this.labVAValid = new System.Windows.Forms.Label();
            this.btnVAXml = new System.Windows.Forms.Button();
            this.txtVANumberRequester = new System.Windows.Forms.TextBox();
            this.cbVACountryRequester = new System.Windows.Forms.ComboBox();
            this.txtVANumber = new System.Windows.Forms.TextBox();
            this.cbVACountry = new System.Windows.Forms.ComboBox();
            this.labVANumberRequester = new System.Windows.Forms.Label();
            this.labVACountryRequester = new System.Windows.Forms.Label();
            this.btnVACheck = new System.Windows.Forms.Button();
            this.labVANumber = new System.Windows.Forms.Label();
            this.labVACountry = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtVADate = new System.Windows.Forms.TextBox();
            this.txtVACountry = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtVNumber);
            this.groupBox1.Controls.Add(this.btnVCheck);
            this.groupBox1.Controls.Add(this.cbVCountry);
            this.groupBox1.Controls.Add(this.labVNumber);
            this.groupBox1.Controls.Add(this.labVCountry);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(15, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szybka Walidacja Vat";
            this.toolTip1.SetToolTip(this.groupBox1, "Checkvat\r\n");
            // 
            // txtVNumber
            // 
            this.txtVNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVNumber.Location = new System.Drawing.Point(11, 126);
            this.txtVNumber.Name = "txtVNumber";
            this.txtVNumber.Size = new System.Drawing.Size(145, 23);
            this.txtVNumber.TabIndex = 7;
            // 
            // btnVCheck
            // 
            this.btnVCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVCheck.Location = new System.Drawing.Point(45, 164);
            this.btnVCheck.Name = "btnVCheck";
            this.btnVCheck.Size = new System.Drawing.Size(110, 40);
            this.btnVCheck.TabIndex = 6;
            this.btnVCheck.Text = "WERYFIKUJ";
            this.btnVCheck.UseVisualStyleBackColor = false;
            this.btnVCheck.Click += new System.EventHandler(this.btnVCheck_Click);
            // 
            // cbVCountry
            // 
            this.cbVCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbVCountry.FormattingEnabled = true;
            this.cbVCountry.Location = new System.Drawing.Point(10, 49);
            this.cbVCountry.Name = "cbVCountry";
            this.cbVCountry.Size = new System.Drawing.Size(145, 24);
            this.cbVCountry.TabIndex = 5;
            // 
            // labVNumber
            // 
            this.labVNumber.AutoSize = true;
            this.labVNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVNumber.Location = new System.Drawing.Point(8, 108);
            this.labVNumber.Name = "labVNumber";
            this.labVNumber.Size = new System.Drawing.Size(74, 15);
            this.labVNumber.TabIndex = 4;
            this.labVNumber.Text = "Numer Vat";
            // 
            // labVCountry
            // 
            this.labVCountry.AutoSize = true;
            this.labVCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVCountry.Location = new System.Drawing.Point(6, 26);
            this.labVCountry.Name = "labVCountry";
            this.labVCountry.Size = new System.Drawing.Size(150, 15);
            this.labVCountry.TabIndex = 3;
            this.labVCountry.Text = "Państwo członkowskie";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.txtVANumberRequester);
            this.groupBox2.Controls.Add(this.cbVACountryRequester);
            this.groupBox2.Controls.Add(this.txtVANumber);
            this.groupBox2.Controls.Add(this.cbVACountry);
            this.groupBox2.Controls.Add(this.labVANumberRequester);
            this.groupBox2.Controls.Add(this.labVACountryRequester);
            this.groupBox2.Controls.Add(this.btnVACheck);
            this.groupBox2.Controls.Add(this.labVANumber);
            this.groupBox2.Controls.Add(this.labVACountry);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(239, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 398);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Złożona Walidacja Vat";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtVACountry);
            this.panel1.Controls.Add(this.txtVADate);
            this.panel1.Controls.Add(this.txtVAVat);
            this.panel1.Controls.Add(this.txtVAId);
            this.panel1.Controls.Add(this.txtVAAdress);
            this.panel1.Controls.Add(this.txtVAName);
            this.panel1.Controls.Add(this.txtVAValid);
            this.panel1.Controls.Add(this.labVAId);
            this.panel1.Controls.Add(this.labVAAdress);
            this.panel1.Controls.Add(this.labVAName);
            this.panel1.Controls.Add(this.labVAValid);
            this.panel1.Controls.Add(this.btnVAXml);
            this.panel1.Location = new System.Drawing.Point(282, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 377);
            this.panel1.TabIndex = 19;
            // 
            // txtVAVat
            // 
            this.txtVAVat.Location = new System.Drawing.Point(3, 350);
            this.txtVAVat.Name = "txtVAVat";
            this.txtVAVat.Size = new System.Drawing.Size(29, 24);
            this.txtVAVat.TabIndex = 19;
            this.txtVAVat.Visible = false;
            // 
            // txtVAId
            // 
            this.txtVAId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVAId.Location = new System.Drawing.Point(19, 284);
            this.txtVAId.Name = "txtVAId";
            this.txtVAId.ReadOnly = true;
            this.txtVAId.Size = new System.Drawing.Size(275, 23);
            this.txtVAId.TabIndex = 18;
            // 
            // txtVAAdress
            // 
            this.txtVAAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVAAdress.Location = new System.Drawing.Point(19, 196);
            this.txtVAAdress.Multiline = true;
            this.txtVAAdress.Name = "txtVAAdress";
            this.txtVAAdress.ReadOnly = true;
            this.txtVAAdress.Size = new System.Drawing.Size(275, 37);
            this.txtVAAdress.TabIndex = 17;
            // 
            // txtVAName
            // 
            this.txtVAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVAName.Location = new System.Drawing.Point(19, 134);
            this.txtVAName.Name = "txtVAName";
            this.txtVAName.ReadOnly = true;
            this.txtVAName.Size = new System.Drawing.Size(275, 23);
            this.txtVAName.TabIndex = 16;
            // 
            // txtVAValid
            // 
            this.txtVAValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVAValid.Location = new System.Drawing.Point(19, 62);
            this.txtVAValid.Name = "txtVAValid";
            this.txtVAValid.ReadOnly = true;
            this.txtVAValid.Size = new System.Drawing.Size(275, 23);
            this.txtVAValid.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtVAValid, "Wartość True oznacza aktywny numer Vat");
            // 
            // labVAId
            // 
            this.labVAId.AutoSize = true;
            this.labVAId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVAId.Location = new System.Drawing.Point(16, 266);
            this.labVAId.Name = "labVAId";
            this.labVAId.Size = new System.Drawing.Size(150, 15);
            this.labVAId.TabIndex = 14;
            this.labVAId.Text = "Identyfikator zapytania";
            // 
            // labVAAdress
            // 
            this.labVAAdress.AutoSize = true;
            this.labVAAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVAAdress.Location = new System.Drawing.Point(16, 178);
            this.labVAAdress.Name = "labVAAdress";
            this.labVAAdress.Size = new System.Drawing.Size(85, 15);
            this.labVAAdress.TabIndex = 13;
            this.labVAAdress.Text = "Adres spółki";
            // 
            // labVAName
            // 
            this.labVAName.AutoSize = true;
            this.labVAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVAName.Location = new System.Drawing.Point(16, 116);
            this.labVAName.Name = "labVAName";
            this.labVAName.Size = new System.Drawing.Size(92, 15);
            this.labVAName.TabIndex = 12;
            this.labVAName.Text = "Nazwa spółki";
            // 
            // labVAValid
            // 
            this.labVAValid.AutoSize = true;
            this.labVAValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVAValid.Location = new System.Drawing.Point(16, 43);
            this.labVAValid.Name = "labVAValid";
            this.labVAValid.Size = new System.Drawing.Size(109, 15);
            this.labVAValid.TabIndex = 11;
            this.labVAValid.Text = "Poprawność Vat";
            // 
            // btnVAXml
            // 
            this.btnVAXml.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVAXml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVAXml.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnVAXml.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVAXml.Location = new System.Drawing.Point(194, 323);
            this.btnVAXml.Name = "btnVAXml";
            this.btnVAXml.Size = new System.Drawing.Size(100, 40);
            this.btnVAXml.TabIndex = 3;
            this.btnVAXml.Text = "ZAPISZ";
            this.btnVAXml.UseVisualStyleBackColor = false;
            this.btnVAXml.Click += new System.EventHandler(this.btnVAXml_Click);
            // 
            // txtVANumberRequester
            // 
            this.txtVANumberRequester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVANumberRequester.Location = new System.Drawing.Point(25, 276);
            this.txtVANumberRequester.Name = "txtVANumberRequester";
            this.txtVANumberRequester.Size = new System.Drawing.Size(145, 23);
            this.txtVANumberRequester.TabIndex = 10;
            // 
            // cbVACountryRequester
            // 
            this.cbVACountryRequester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVACountryRequester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbVACountryRequester.FormattingEnabled = true;
            this.cbVACountryRequester.Location = new System.Drawing.Point(25, 202);
            this.cbVACountryRequester.Name = "cbVACountryRequester";
            this.cbVACountryRequester.Size = new System.Drawing.Size(145, 24);
            this.cbVACountryRequester.TabIndex = 9;
            // 
            // txtVANumber
            // 
            this.txtVANumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtVANumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVANumber.Location = new System.Drawing.Point(24, 126);
            this.txtVANumber.Name = "txtVANumber";
            this.txtVANumber.Size = new System.Drawing.Size(145, 23);
            this.txtVANumber.TabIndex = 8;
            // 
            // cbVACountry
            // 
            this.cbVACountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVACountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbVACountry.FormattingEnabled = true;
            this.cbVACountry.Location = new System.Drawing.Point(24, 51);
            this.cbVACountry.Name = "cbVACountry";
            this.cbVACountry.Size = new System.Drawing.Size(145, 24);
            this.cbVACountry.TabIndex = 6;
            // 
            // labVANumberRequester
            // 
            this.labVANumberRequester.AutoSize = true;
            this.labVANumberRequester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVANumberRequester.Location = new System.Drawing.Point(22, 258);
            this.labVANumberRequester.Name = "labVANumberRequester";
            this.labVANumberRequester.Size = new System.Drawing.Size(147, 15);
            this.labVANumberRequester.TabIndex = 5;
            this.labVANumberRequester.Text = "Numer Vat pytającego";
            // 
            // labVACountryRequester
            // 
            this.labVACountryRequester.AutoSize = true;
            this.labVACountryRequester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVACountryRequester.Location = new System.Drawing.Point(22, 163);
            this.labVACountryRequester.MaximumSize = new System.Drawing.Size(150, 0);
            this.labVACountryRequester.Name = "labVACountryRequester";
            this.labVACountryRequester.Size = new System.Drawing.Size(150, 30);
            this.labVACountryRequester.TabIndex = 4;
            this.labVACountryRequester.Text = "Państwo członkowskie pytającego";
            // 
            // btnVACheck
            // 
            this.btnVACheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVACheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVACheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVACheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVACheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVACheck.Location = new System.Drawing.Point(62, 313);
            this.btnVACheck.Name = "btnVACheck";
            this.btnVACheck.Size = new System.Drawing.Size(110, 40);
            this.btnVACheck.TabIndex = 2;
            this.btnVACheck.Text = "WERYFIKUJ";
            this.btnVACheck.UseVisualStyleBackColor = false;
            this.btnVACheck.Click += new System.EventHandler(this.btnVACheck_Click);
            // 
            // labVANumber
            // 
            this.labVANumber.AutoSize = true;
            this.labVANumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVANumber.Location = new System.Drawing.Point(22, 108);
            this.labVANumber.Name = "labVANumber";
            this.labVANumber.Size = new System.Drawing.Size(74, 15);
            this.labVANumber.TabIndex = 1;
            this.labVANumber.Text = "Numer Vat";
            // 
            // labVACountry
            // 
            this.labVACountry.AutoSize = true;
            this.labVACountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labVACountry.Location = new System.Drawing.Point(22, 30);
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
            // txtVADate
            // 
            this.txtVADate.BackColor = System.Drawing.SystemColors.Control;
            this.txtVADate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVADate.Location = new System.Drawing.Point(163, 9);
            this.txtVADate.Name = "txtVADate";
            this.txtVADate.ReadOnly = true;
            this.txtVADate.Size = new System.Drawing.Size(130, 23);
            this.txtVADate.TabIndex = 20;
            // 
            // txtVACountry
            // 
            this.txtVACountry.Location = new System.Drawing.Point(38, 350);
            this.txtVACountry.Name = "txtVACountry";
            this.txtVACountry.Size = new System.Drawing.Size(28, 24);
            this.txtVACountry.TabIndex = 21;
            this.txtVACountry.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VIESApp.Properties.Resources._128px_Flag_of_Europe_svg;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 83);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(858, 474);
            this.Controls.Add(this.pictureBox1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtVAVat;
        private System.Windows.Forms.TextBox txtVADate;
        private System.Windows.Forms.TextBox txtVACountry;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

