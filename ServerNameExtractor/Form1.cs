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
        //Start the application - auto-generated.
        public MainForm()
        {
            InitializeComponent();
        }

        //Load the form - auto-generated.
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Method to handle the file browser button click event.
        private void btnFilePath_Click(object sender, EventArgs e)
        {
            //Create a new empty string variable for the file path to be stored in.
            string fileName = "";

            //Open the file system dialog box for the user to browse to a file.
            System.Windows.Forms.OpenFileDialog openFile = new OpenFileDialog();

            //If the user selects a file a selects the OK button the file path is set to the file they selected.
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                fileName = openFile.FileName;
            }

            //Set the textbox to display the file path in order to provide feedback to the user.
            tBxFilePath.Text = fileName;
            
            //If the file name contains the .csv extension then it can be converted.
            if (fileName.Contains(".csv"))
            {
                //Create a new variable and set it to a new file reader object.
                var reader = new StreamReader(File.OpenRead(fileName));

                //Create a new empty list to hold the serve names as they are added.
                List<string> serverNames = new List<string>();

                //Create a new variable to count the lines of the file as the reader loops through it.
                var count = 0;

                //Start a loop that continues while the reader has not reached the end of the file.
                while(!reader.EndOfStream)
                {
                    //Create a variable to hold the current line that the file reader is on.
                    var line = reader.ReadLine();

                    //Create a variable that holds an array of string that are retrived form the line object, 
                    //these are split on the commas of the .csv file and the quote marks are removed from each string.
                    var values = line.Replace("\"", "").Split(',');

                    //If the count is greater than the first line of the file (which contains the titles) then the object can be treated as a server.
                    if (count != 0)
                    {
                        //If the length of the first column (the server name is greater than 0,
                        //and the seventh column displays that the server is in use and not inactive then...
                        if ((values[0].Length != 0) && values[7].Contains("In use"))
                        {
                            //Add the server name to the list of server names to be written to a file.
                            serverNames.Add(values[0]);
                        }
                    }
                    //Increment the count by one.
                    count++;
                }

                //Create a new text writer object with the same name as the input file but add the ServerNames.txt extension to it.
                TextWriter tw = new StreamWriter(fileName + "ServerNames.txt");

                //Create a new string builder object to use to write the file contents to the multiline textbox in the GUI.
                StringBuilder sb = new StringBuilder();

                //Then for each of the strings in the server name list...
                foreach(string s in serverNames)
                {
                    //Add the name to a new line of the .txt file
                    tw.WriteLine(s);
                    //Add it to a new line of the string builder object
                    sb.AppendLine(s);
                }

                //Print the stringbuilder object to the GUIs multi line textbox
                textBox1.Text = sb.ToString();

                //Close the text writer and finish computation.
                tw.Close();
            }
            //Else if the file does not contain the .csv extension then...
            else
            {
                //Display a message box warning the file cannot be processed.
                MessageBox.Show("Unable to process this file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
