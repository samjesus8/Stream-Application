using System;
using System.IO;
using System.Windows.Forms;

namespace StreamLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void appendButton_Click(object sender, EventArgs e)
        {
            try //Try Catch for error checking in case the program fails
            {
                using (StreamWriter writer = new StreamWriter("D:/UNI STUFF/C# Projects/Year 2/StreamLab/Data/data.txt", true, System.Text.Encoding.UTF8)) //Opening the text file 
                {
                    string data = quoteBox.Text.ToString(); //Assigning the user input into a variable

                    writer.WriteLine(data + " " + repeatTrackBar.Value.ToString()); //Writing the data from the textbox into the text file
                    writer.Close(); //Makes sure to save the file to use when the application isnt running
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("D:/UNI STUFF/C# Projects/Year 2/StreamLab/Data/data.txt")) //Opening a StreamReader to read the file
            {
                do
                {
                    string data = reader.ReadLine(); //Reading the whole file
                    string error = "No Data";

                    string quote; //Initialising Variables to store
                    string value;

                    if (data == null) //If the txt file is empty, show an error message
                    {
                        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string[] temp = data.Split(' '); //Splits the Quote and the Repeat value
                        quote = temp[0]; //Storing text here
                        value = temp[1]; //Storing repeat value here

                        for (int i = 0; i <= int.Parse(value); i++)
                        {
                            outputBox.Items.Add(quote); //For loop to output the quote based on the repeat value
                        }
                    }
                } while (reader.EndOfStream == false);

                reader.Close();
            }
        }
    }
}
