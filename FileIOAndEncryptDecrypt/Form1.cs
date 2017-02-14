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


namespace FileIOAndEncryptDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string fileName = @"c:\FileIO\FileIO.txt";
        string directory = @"c:\FileIO";

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            } else
            {
                Directory.Delete(directory);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //string Fname = txtFirstName.Text;
            //string Lname = txtLastName.Text;

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(txtFirstName.Text + " " + txtLastName.Text, "\n");
                
            }

            

            
        }
    }
}
