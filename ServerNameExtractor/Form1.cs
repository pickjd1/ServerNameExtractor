using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerNameExtractor
{
    //public static Process Start(string fileName, string arguments)

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            string fileName = "";
            System.Windows.Forms.OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                fileName = openFile.FileName;
            }

            tBxFilePath.Text = fileName;
            //|| (fileName.Contains(""))
            if (fileName.Contains(".csv"))
            {
                var reader = new StreamReader(File.OpenRead(fileName));
                List<string> serverNames = new List<string>();

                var count = 0;
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Replace("\"", "").Split(',');

                    if (count != 0)
                    {
                        if ((values[0].Length != 0) && values[7].Contains("In use"))
                        {
                            serverNames.Add(values[0]);
                        }
                    }
                    count++;
                }

                TextWriter tw = new StreamWriter(fileName + "ServerNames.txt");
                StringBuilder sb = new StringBuilder();

                foreach(string s in serverNames)
                {
                    tw.WriteLine(s);
                    sb.AppendLine(s);
                }
                textBox1.Text = sb.ToString();
                tw.Close();
            }
            else
            {
                MessageBox.Show("Unable to process this file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
