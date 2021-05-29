
namespace ContactTrace
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
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.ageLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.phoneNum = new System.Windows.Forms.TextBox();
            this.phoneNumLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.ntnltyTbx = new System.Windows.Forms.TextBox();
            this.nationalityLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstName.Location = new System.Drawing.Point(161, 147);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(476, 39);
            this.firstName.TabIndex = 0;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(161, 216);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(476, 39);
            this.lastName.TabIndex = 0;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLbl.Location = new System.Drawing.Point(12, 150);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(129, 32);
            this.firstNameLbl.TabIndex = 1;
            this.firstNameLbl.Text = "First Name";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLbl.Location = new System.Drawing.Point(12, 219);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(126, 32);
            this.lastNameLbl.TabIndex = 1;
            this.lastNameLbl.Text = "Last Name";
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.age.Location = new System.Drawing.Point(161, 295);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(127, 39);
            this.age.TabIndex = 0;
            this.age.TextChanged += new System.EventHandler(this.age_TextChanged);
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ageLbl.Location = new System.Drawing.Point(12, 298);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(56, 32);
            this.ageLbl.TabIndex = 1;
            this.ageLbl.Text = "Age";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.Location = new System.Drawing.Point(250, 60);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(276, 32);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Contact Tracing Program";
            // 
            // phoneNum
            // 
            this.phoneNum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNum.Location = new System.Drawing.Point(161, 444);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(293, 39);
            this.phoneNum.TabIndex = 0;
            this.phoneNum.TextChanged += new System.EventHandler(this.phoneNum_TextChanged);
            // 
            // phoneNumLbl
            // 
            this.phoneNumLbl.AutoSize = true;
            this.phoneNumLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumLbl.Location = new System.Drawing.Point(12, 447);
            this.phoneNumLbl.Name = "phoneNumLbl";
            this.phoneNumLbl.Size = new System.Drawing.Size(133, 32);
            this.phoneNumLbl.TabIndex = 1;
            this.phoneNumLbl.Text = "Mobile No.";
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.Location = new System.Drawing.Point(363, 562);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(91, 41);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // ntnltyTbx
            // 
            this.ntnltyTbx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ntnltyTbx.Location = new System.Drawing.Point(161, 367);
            this.ntnltyTbx.Name = "ntnltyTbx";
            this.ntnltyTbx.Size = new System.Drawing.Size(293, 39);
            this.ntnltyTbx.TabIndex = 0;
            this.ntnltyTbx.TextChanged += new System.EventHandler(this.ntnltyTbx_TextChanged);
            // 
            // nationalityLbl
            // 
            this.nationalityLbl.AutoSize = true;
            this.nationalityLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nationalityLbl.Location = new System.Drawing.Point(12, 370);
            this.nationalityLbl.Name = "nationalityLbl";
            this.nationalityLbl.Size = new System.Drawing.Size(130, 32);
            this.nationalityLbl.TabIndex = 1;
            this.nationalityLbl.Text = "Nationality";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.nationalityLbl);
            this.Controls.Add(this.phoneNumLbl);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.ntnltyTbx);
            this.Controls.Add(this.phoneNum);
            this.Controls.Add(this.age);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox phoneNum;
        private System.Windows.Forms.Label phoneNumLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox ntnltyTbx;
        private System.Windows.Forms.Label nationalityLbl;
    }
}

