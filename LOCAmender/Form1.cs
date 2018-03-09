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
using System.Text.RegularExpressions;

namespace LOCAmender
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
            amendFiles.Enabled = false; //prevent usage before selecting folder
		}
        
		private void selectFolder_Click(object sender, EventArgs e)
		{   //sets up folder picker
			using(var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{   
					string[] allFiles = Directory.GetFiles(fbd.SelectedPath);
					//puts folder path to string and displays
                    textBoxFolderSelected.Text = fbd.SelectedPath;
                    amendFiles.Enabled = true;

				}

		    }
		}

        private void amendFiles_Click(object sender, EventArgs e)
        {
            
            //create array List
            
            string target_folder = textBoxFolderSelected.Text;
            //placeholder for filenames
            string fileNames = null;
           
            

            var files = Directory.GetFiles(target_folder);
            foreach (string file in files)
            {
                List<string> letters = new List<string>();
                fileNames = System.IO.Path.GetFullPath(file);
                string text = File.ReadAllText(file);
                //intiate the printable string
                string editedText = null;

                letters.AddRange(Regex.Split(text, "\r\n---------------------------------------------------------------------\r\n").ToList());
                
                foreach (string item in letters)
                {
                    string amendedItem = item;

                    
                    string pattern1 = @"No.: \d{3,4}-\d{9,10}\s"; //regex for 1st Letter of credit # change 
                    string pattern2 = @"\d{3,4}-\d{9,10}"; //regex for 2nd LOC # change
                    
                    //edits
                    amendedItem = amendedItem.Replace("LETTER OF CREDIT", "AMENDED AND RESTATED LETTER OF CREDIT");
                    amendedItem = amendedItem.Replace("Date of Issuance", "Effective Date");
                    
                    //sets pattern2 to a var to be called in following edits
                    Match n = Regex.Match(amendedItem, pattern2);
                    amendedItem = amendedItem.Replace("We h" ,"The previously issued Letter of Credit " + n.Value + " is hereby revoked. We h");
                    amendedItem = amendedItem.Replace("Letter of Credit No. " + n.Value, "Amended and Restated Letter of Credit No. " + n.Value + "a");
                    amendedItem = amendedItem.Replace(n.Value + " issued", n.Value + "a issued");

                    foreach (Match m in Regex.Matches(amendedItem, pattern1))
                    {
                        amendedItem = amendedItem.Replace(m.Value, m.Value + "a");

                    }
                    //add to string 
                    editedText += amendedItem + "\r\n---------------------------------------------------------------------\r\n";
                }
                

                string fileOut = fileNames.Substring(0, fileNames.Length - 4) + "a.txt";
                File.WriteAllText(fileOut, editedText);
                
                
            }
            
            completeMessage.Text = "Complete";
            amendFiles.Enabled = false; //prevent double clicking
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
	}
}

