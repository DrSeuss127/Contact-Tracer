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

namespace ContactTracing
{
    public partial class Form1 : Form
    {
        string name, age, address, number, nationality, email, creationTime, dateNow;

        public Form1()
        {
            InitializeComponent();

            submitBtn.Enabled = false;
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {
            name = inputName.Text;

        }

        private void inputAge_TextChanged(object sender, EventArgs e)
        {
            age = inputAge.Text;
        }

        private void inputAddress_TextChanged(object sender, EventArgs e)
        {
            address = inputAddress.Text;
        }

        private void inputNumber_TextChanged(object sender, EventArgs e)
        {
            number = inputNumber.Text;
        }

        private void inputNationality_TextChanged(object sender, EventArgs e)
        {
            nationality = inputNationality.Text;
        }

        private void inputEmail_TextChanged(object sender, EventArgs e)
        {
            email = inputEmail.Text;

            if (inputEmail.Text.Length > 0)
            {
                submitBtn.Enabled = true;
                viewDataBtn.Enabled = true;
            }
            else
            {
                submitBtn.Enabled = false;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            creationTime = DateTime.Now.ToShortTimeString();
            dateNow = DateTime.Now.ToShortDateString();

            StreamWriter outputFile;
            StreamReader inputFile;

            inputFile = File.OpenText("Contacts.txt");

            string content = inputFile.ReadToEnd();

            inputFile.Close();

            if (content.Contains(dateNow))
            {
                
                outputFile = File.AppendText("Contacts.txt");

                outputFile.WriteLine("");
                outputFile.WriteLine("");
                outputFile.WriteLine($"Name: {name}");
                outputFile.WriteLine($"Age: {age}");
                outputFile.WriteLine($"Address: {address}");
                outputFile.WriteLine($"Contact Number: {number}");
                outputFile.WriteLine($"Nationality: {nationality}");
                outputFile.WriteLine($"Email: {email}");
                outputFile.WriteLine($"Time Submitted: {creationTime}");
                outputFile.WriteLine("");
                outputFile.WriteLine("");
                outputFile.WriteLine("=============================================");
                outputFile.WriteLine("");
                outputFile.WriteLine("");
                outputFile.Close();
            }
            else
            {
                outputFile = File.AppendText("Contacts.txt");

                outputFile.WriteLine("");
                outputFile.WriteLine($"{dateNow}");
                outputFile.WriteLine("");
                outputFile.WriteLine("");
                outputFile.WriteLine("=============================================");
                outputFile.WriteLine("");
                outputFile.WriteLine("");
                outputFile.WriteLine($"Name: {name}");
                outputFile.WriteLine($"Age: {age}");
                outputFile.WriteLine($"Address: {address}");
                outputFile.WriteLine($"Contact Number: {number}");
                outputFile.WriteLine($"Nationality: {nationality}");
                outputFile.WriteLine($"Email: {email}");
                outputFile.WriteLine($"Time Submitted: {creationTime}");
                outputFile.WriteLine("");
                outputFile.WriteLine("");
                outputFile.WriteLine("=============================================");
                outputFile.Close();
            }
            

            inputName.Text = "";
            inputAge.Text = "";
            inputAddress.Text = "";
            inputNumber.Text = "";
            inputNationality.Text = "";
            inputEmail.Text = "";
            MessageBox.Show("Your information has been recorded. Thank you!");

        }

        private void viewDataBtn_Click(object sender, EventArgs e)
        {
            var newForm = new Form2();
            newForm.Show();
            viewDataBtn.Enabled = !viewDataBtn.Enabled;
        }
    }
}
