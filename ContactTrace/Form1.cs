using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTrace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

         
        }

        string fName, lName, yearsOld, mobNum;

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            
            fName = firstName.Text;
        }

        

        private void lastName_TextChanged(object sender, EventArgs e)
        {
           
            lName = lastName.Text;
        }

        private void age_TextChanged(object sender, EventArgs e)
        {
            yearsOld = age.Text;
        }

        private void phoneNum_TextChanged(object sender, EventArgs e)
        {
            mobNum = phoneNum.Text;
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;

            outputFile = File.AppendText("");
        }
    }
}
