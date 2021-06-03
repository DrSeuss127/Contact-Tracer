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

            //Checks if the output display has no characters, disables the clear data button (on app start)
            if (contactsDisplay.Text.Length == 0)
            {
                clrDataBtn.Enabled = false;
            }
            //Checks if the output display has characters, enables the clear data button (on app start)
            else if (contactsDisplay.Text.Length > 0)
            {
                clrDataBtn.Enabled = true;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            //Refreshes the data list
            contactsDisplay.Text = "";
            contactsDisplay.Text = File.ReadAllText("Contacts.txt");
        }

        private void clrDataBtn_Click(object sender, EventArgs e)
        {
            //Prevents output display from displaying "System.IO.." text when data is cleared
            if (contactsDisplay.Text == "")
            {
                contactsDisplay.Text = "";
            }
            //Removes the file, creates another one of the same name, therefore technically clearing the data
            else
            {
                StreamWriter outputFile;

                outputFile = File.CreateText("Contacts.txt");
                outputFile.Close();

                contactsDisplay.Text = "";
            }

        }

        private void contactsDisplay_TextChanged(object sender, EventArgs e)            //Event for when the output display text has changed
        {
            //Checks if output display has no characters, disables clear data button
            if (contactsDisplay.Text.Length == 0)
            {
                clrDataBtn.Enabled = false;
            }
            //Checks if output display has characters, enables clear data button
            else if (contactsDisplay.Text.Length > 0)
            {
                clrDataBtn.Enabled = true;
            }
        }

        public void Form2_Closed(object sender, FormClosedEventArgs e)              //Event for when Form2 is closed
        {
            //Instance of form 1 to be used when this event is triggered
            var form1 = new Form1();
            form1.viewDataBtn.Enabled = true;       //Enables the view data button on form1
        }
    }
}
