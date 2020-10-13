using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS322_StreamWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        string path;
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK) {

                btnWrite.Enabled = true;
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter(File.OpenWrite(path));
            sw.Write(tbUnesi.Text);
            sw.WriteLine("\nThis is second line.");
            sw.Write("Bojan");
            sw.Dispose();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(File.OpenRead(ofd.FileName));

                lblText.Text = streamReader.ReadToEnd();
                streamReader.Dispose();

            }

        }
    }
}
