using StreamLab.Builders;
using System;
using System.IO;
using System.Windows.Forms;

namespace StreamLab
{
    public partial class Form1 : Form
    {
        public JSONTextBuilder JSONBuilder = new JSONTextBuilder(); //Initialising an instance of the class
        public Form1()
        {
            InitializeComponent();
        }

        private void appendButton_Click(object sender, EventArgs e)
        {
            try //Try Catch for error checking in case the program fails
            {
                using (StreamWriter writer = new StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory + "/Data/data.txt", true, System.Text.Encoding.UTF8)) //Opening the text file 
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
            using (StreamReader reader = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "/Data/data.txt")) //Opening a StreamReader to read the file
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
                            outputBox.Text = quote;
                        }
                    }
                } while (reader.EndOfStream == false);

                reader.Close();
            }
        }

        private void jsonWriteButton_Click(object sender, EventArgs e)
        {
            JSONBuilder.Write(member1Box.Text, member2Box.Text, member3Box.Text);
        }

        private void jsonLoadButton_Click(object sender, EventArgs e)
        {
            JSONBuilder.Load();

            foreach (var item in JSONBuilder.MemberProperties) 
            {
                string output = item.Value.MemberProperty1 + "\r\n" +
                                item.Value.MemberProperty2 + "\r\n" +
                                item.Value.MemberProperty3;

                outputBox.Text = output;
            }

            //IMPORTANT - Before running this program make sure to copy and paste your JSON file into the '\bin\Debug' folder of your project
        }
    }
}
