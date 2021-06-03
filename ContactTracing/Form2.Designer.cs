
namespace ContactTracing
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
            this.refreshBtn = new System.Windows.Forms.Button();
            this.clrDataBtn = new System.Windows.Forms.Button();
            this.contactsDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.White;
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshBtn.Location = new System.Drawing.Point(282, 503);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(83, 44);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // clrDataBtn
            // 
            this.clrDataBtn.BackColor = System.Drawing.Color.White;
            this.clrDataBtn.FlatAppearance.BorderSize = 0;
            this.clrDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrDataBtn.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clrDataBtn.Location = new System.Drawing.Point(429, 503);
            this.clrDataBtn.Name = "clrDataBtn";
            this.clrDataBtn.Size = new System.Drawing.Size(83, 44);
            this.clrDataBtn.TabIndex = 1;
            this.clrDataBtn.Text = "Clear Data";
            this.clrDataBtn.UseVisualStyleBackColor = false;
            this.clrDataBtn.Click += new System.EventHandler(this.clrDataBtn_Click);
            // 
            // contactsDisplay
            // 
            this.contactsDisplay.BackColor = System.Drawing.SystemColors.Info;
            this.contactsDisplay.Location = new System.Drawing.Point(68, 55);
            this.contactsDisplay.Name = "contactsDisplay";
            this.contactsDisplay.Size = new System.Drawing.Size(649, 430);
            this.contactsDisplay.TabIndex = 2;
            this.contactsDisplay.Text = "";
            this.contactsDisplay.TextChanged += new System.EventHandler(this.contactsDisplay_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.contactsDisplay);
            this.Controls.Add(this.clrDataBtn);
            this.Controls.Add(this.refreshBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Contacts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_Closed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button clrDataBtn;
        private System.Windows.Forms.RichTextBox contactsDisplay;
    }
}