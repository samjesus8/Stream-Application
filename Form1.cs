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
            using (StreamWriter writer = new StreamWriter("D:/UNI STUFF/C# Projects/Year 2/StreamLab/Data/data.txt")) 
            {
                string data = quoteBox.Text.ToString();
                writer.WriteLine(data);
                writer.Close();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {

        }
    }
}
