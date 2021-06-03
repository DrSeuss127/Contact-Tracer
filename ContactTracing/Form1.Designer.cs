
namespace ContactTracing
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
            this.appTitle = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameFormat = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.inputAge = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.contactNoLabel = new System.Windows.Forms.Label();
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.nationalityLabel = new System.Windows.Forms.Label();
            this.inputNationality = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.gmailLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.viewDataBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("ISOCPEUR", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appTitle.Location = new System.Drawing.Point(224, 43);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(320, 44);
            this.appTitle.TabIndex = 0;
            this.appTitle.Text = "Contact Tracing Form";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputName
            // 
            this.inputName.BackColor = System.Drawing.SystemColors.Info;
            this.inputName.Font = new System.Drawing.Font("ISOCPEUR", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputName.Location = new System.Drawing.Point(136, 118);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(408, 37);
            this.inputName.TabIndex = 1;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("ISOCPEUR", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(56, 116);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(84, 34);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name: ";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameFormat
            // 
            this.nameFormat.AutoSize = true;
            this.nameFormat.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameFormat.Location = new System.Drawing.Point(136, 153);
            this.nameFormat.Name = "nameFormat";
            this.nameFormat.Size = new System.Drawing.Size(349, 27);
            this.nameFormat.TabIndex = 0;
            this.nameFormat.Text = "Format: (Surname, First Name, Last Name)";
            this.nameFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("ISOCPEUR", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ageLabel.Location = new System.Drawing.Point(563, 118);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(60, 34);
            this.ageLabel.TabIndex = 0;
            this.ageLabel.Text = "Age:";
            this.ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputAge
            // 
            this.inputAge.BackColor = System.Drawing.SystemColors.Info;
            this.inputAge.Font = new System.Drawing.Font("ISOCPEUR", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputAge.Location = new System.Drawing.Point(635, 120);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(62, 37);
            this.inputAge.TabIndex = 1;
            this.inputAge.TextChanged += new System.EventHandler(this.inputAge_TextChanged);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("ISOCPEUR", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.Location = new System.Drawing.Point(56, 202);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(116, 34);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address: ";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputAddress
            // 
            this.inputAddress.BackColor = System.Drawing.SystemColors.Info;
            this.inputAddress.Font = new System.Drawing.Font("ISOCPEUR", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputAddress.Location = new System.Drawing.Point(159, 202);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(538, 37);
            this.inputAddress.TabIndex = 1;
            this.inputAddress.TextChanged += new System.EventHandler(this.inputAddress_TextChanged);
            // 
            // contactNoLabel
            // 
            this.contactNoLabel.AutoSize = true;
            this.contactNoLabel.Font = new System.Drawing.Font("ISOCPEUR", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactNoLabel.Location = new System.Drawing.Point(56, 252);
            this.contactNoLabel.Name = "contactNoLabel";
            this.contactNoLabel.Size = new System.Drawing.Size(184, 34);
            this.contactNoLabel.TabIndex = 0;
            this.contactNoLabel.Text = "Contact Number:";
            this.contactNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputNumber
            // 
            this.inputNumber.BackColor = System.Drawing.SystemColors.Info;
            this.inputNumber.Font = new System.Drawing.Font("ISOCPEUR", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputNumber.Location = new System.Drawing.Point(240, 252);
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(457, 37);
            this.inputNumber.TabIndex = 1;
            this.inputNumber.TextChanged += new System.EventHandler(this.inputNumber_TextChanged);
            // 
            // nationalityLabel
            // 
            this.nationalityLabel.AutoSize = true;
            this.nationalityLabel.Font = new System.Drawing.Font("ISOCPEUR", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nationalityLabel.Location = new System.Drawing.Point(56, 301);
            this.nationalityLabel.Name = "nationalityLabel";
            this.nationalityLabel.Size = new System.Drawing.Size(131, 34);
            this.nationalityLabel.TabIndex = 0;
            this.nationalityLabel.Text = "Nationality:";
            this.nationalityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputNationality
            // 
            this.inputNationality.BackColor = System.Drawing.SystemColors.Info;
            this.inputNationality.Font = new System.Drawing.Font("ISOCPEUR", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputNationality.Location = new System.Drawing.Point(183, 301);
            this.inputNationality.Name = "inputNationality";
            this.inputNationality.Size = new System.Drawing.Size(514, 37);
            this.inputNationality.TabIndex = 1;
            this.inputNationality.TextChanged += new System.EventHandler(this.inputNationality_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("ISOCPEUR", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(56, 349);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(72, 34);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputEmail
            // 
            this.inputEmail.BackColor = System.Drawing.SystemColors.Info;
            this.inputEmail.Font = new System.Drawing.Font("ISOCPEUR", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputEmail.Location = new System.Drawing.Point(128, 349);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(569, 37);
            this.inputEmail.TabIndex = 1;
            this.inputEmail.TextChanged += new System.EventHandler(this.inputEmail_TextChanged);
            // 
            // gmailLbl
            // 
            this.gmailLbl.AutoSize = true;
            this.gmailLbl.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gmailLbl.Location = new System.Drawing.Point(309, 389);
            this.gmailLbl.Name = "gmailLbl";
            this.gmailLbl.Size = new System.Drawing.Size(161, 27);
            this.gmailLbl.TabIndex = 0;
            this.gmailLbl.Text = "(Preferrably gmail)";
            this.gmailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.White;
            this.submitBtn.FlatAppearance.BorderSize = 0;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("ISOCPEUR", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.Location = new System.Drawing.Point(343, 438);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 37);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // viewDataBtn
            // 
            this.viewDataBtn.BackColor = System.Drawing.Color.White;
            this.viewDataBtn.FlatAppearance.BorderSize = 0;
            this.viewDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewDataBtn.Font = new System.Drawing.Font("ISOCPEUR", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewDataBtn.Location = new System.Drawing.Point(670, 438);
            this.viewDataBtn.Name = "viewDataBtn";
            this.viewDataBtn.Size = new System.Drawing.Size(118, 37);
            this.viewDataBtn.TabIndex = 2;
            this.viewDataBtn.Text = "View Data >";
            this.viewDataBtn.UseVisualStyleBackColor = false;
            this.viewDataBtn.Click += new System.EventHandler(this.viewDataBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.viewDataBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.inputNationality);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.inputAddress);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.gmailLbl);
            this.Controls.Add(this.nameFormat);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nationalityLabel);
            this.Controls.Add(this.contactNoLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.appTitle);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ContactTracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nameFormat;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox inputAge;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox inputAddress;
        private System.Windows.Forms.Label contactNoLabel;
        private System.Windows.Forms.TextBox inputNumber;
        private System.Windows.Forms.Label nationalityLabel;
        private System.Windows.Forms.TextBox inputNationality;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label gmailLbl;
        private System.Windows.Forms.Button submitBtn;
        public System.Windows.Forms.Button viewDataBtn;
    }
}

