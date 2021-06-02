using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactTracing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            contactsDisplay.Text = File.ReadAllText("Contacts.txt");

            if (contactsDisplay.Text.Length <= 0)
            {
                clrDataBtn.Enabled = false;
            }
            else
            {
                clrDataBtn.Enabled = true;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            contactsDisplay.Text = "";
            contactsDisplay.Text = File.ReadAllText("Contacts.txt");
        }

        private void clrDataBtn_Click(object sender, EventArgs e)
        {
            if (contactsDisplay.Text == "")
            {
                contactsDisplay.Text = "";
            }
            else
            {
                StreamWriter outputFile;

                outputFile = File.CreateText("Contacts.txt");
                outputFile.Close();

                contactsDisplay.Text = "";
            }
            
        }
    }
}
