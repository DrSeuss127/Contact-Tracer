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
            viewDataBtn.Enabled = false;
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {
            name = inputName.Text;                                                  //Stores the name of the person taken from the text box to the variable name

        }

        private void inputAge_TextChanged(object sender, EventArgs e)
        {
            age = inputAge.Text;                                                   //Stores the age of the person taken from the text box to the variable age
        }

        private void inputAddress_TextChanged(object sender, EventArgs e)
        {
            address = inputAddress.Text;                                          //Stores the address of the person taken from the text box to the variable address
        }

        private void inputNumber_TextChanged(object sender, EventArgs e)
        {
            number = inputNumber.Text;                                            //Stores the contact number of the person taken from the text box to the variable number
        }

        private void inputNationality_TextChanged(object sender, EventArgs e)
        {
            nationality = inputNationality.Text;                                 //Stores the nationality of the person taken from the text box to the variable nationality
        }

        private void inputEmail_TextChanged(object sender, EventArgs e)
        {
            email = inputEmail.Text;                                            //Stores the email of the person taken from the text box to the variable email

            //Checks if the textbox has characters present
            if (inputEmail.Text.Length > 0)
            {
                //Enables both the submit and view data buttons
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
            //Variables for the exact time creationTime and the date today dateNow
            creationTime = DateTime.Now.ToShortTimeString();
            dateNow = DateTime.Now.ToShortDateString();

            //Declaration of read and write to file
            StreamWriter outputFile;
            StreamReader inputFile;

            inputFile = File.OpenText("Contacts.txt");

            string content = inputFile.ReadToEnd();

            inputFile.Close();

            //Checks if any of the fields have no characters, if true, does not record information and instead shows message box
            if (inputName.Text.Length == 0 || inputAge.Text.Length == 0 || inputAddress.Text.Length == 0 || inputNumber.Text.Length == 0 || inputNationality.Text.Length == 0 || inputEmail.Text.Length == 0)
            {
                MessageBox.Show("Please fill out all the fields.");
            }
            else
            {
                //Checks if the text file contains the date today
                if (content.Contains(dateNow))
                {
                    //If true, appends entry without date
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
                    //If false, appends date on top of entry, will act as automatic date filter for people
                    outputFile = File.AppendText("Contacts.txt");

                    outputFile.WriteLine("");
                    outputFile.WriteLine($"Entries as of {dateNow}");
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

                //Clears the text boxes and alerts the person that their information has been recorded
                inputName.Text = "";
                inputAge.Text = "";
                inputAddress.Text = "";
                inputNumber.Text = "";
                inputNationality.Text = "";
                inputEmail.Text = "";

                MessageBox.Show("Your information has been recorded. Thank you!");
            }
        }

        private void viewDataBtn_Click(object sender, EventArgs e)
        {
            //Instance of 2nd form for data display
            var newForm = new Form2();

            //When button is clicked, shows the second form
            newForm.Show();

            viewDataBtn.Enabled = !viewDataBtn.Enabled;
        }
    }
}
