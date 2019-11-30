using log4net;
using SQLiteDB;
using SQLiteDB.Model;
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

namespace ConfigurationWindowServiceBackup
{
    public partial class FormParametri : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(FormParametri));

        public FormParametri()
        {
            InitializeComponent();
            SQLiteManager sQLLiteManager = new SQLiteManager();
            sQLLiteManager.CreateTable();
            List<SQLiteDB.Model.FileStream> fileStreams = sQLLiteManager.SelectAll();
            listViewFiles.Columns.Add("File backup", -2, HorizontalAlignment.Left);
            listViewFiles.FullRowSelect = true;
            listViewFiles.GridLines = true;
            listViewFiles.View = System.Windows.Forms.View.List;    
            foreach (SQLiteDB.Model.FileStream row in fileStreams)
            {
                //Add Item to ListView.         
                ListViewItem item = new ListViewItem(row.Path);             
                string l = row.Path.Replace(@"\","@");
                listViewFiles.Items.Add(item);
                //   ListViewItem viewItem = new ListViewItem();       
                //  listViewFiles.Columns[0].Width = -1;                

            }
           // listViewFiles.Focus();          
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {           
            String path = textBoxFile.Text;          
            try
            {
                if (File.Exists(path))
                {
                    ElaborazioneFile(path);
                }
            }
            catch(Exception ex)
            {
                _log.Error(ex.Message);
                labelErrore.AutoSize = false; 
                labelErrore.Width = 300;
                labelErrore.Text = ex.Message;
                
            }
        }
        

        private void listViewFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOKCartella_Click(object sender, EventArgs e)
        {
            string path = textBoxCartella.Text;          
            List<string> allFiles = new List<string>();
            if (Directory.Exists(path))
            {
                allFiles = ProcessDirectory(path);
                foreach(string s in allFiles)
                {
                    ElaborazioneFile(s);
                }
            }
        }

        public static List<String> ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            List<String> files = new List<string>();
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            { files.Add(fileName); }

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
            {
                List<String> partialList = ProcessDirectory(subdirectory);
                files.AddRange(partialList);
            }

            return files;
        }

        private void ElaborazioneFile(string file)
        {
            SQLiteManager sQLLiteManager = new SQLiteManager();
            SQLiteDB.Model.FileStream fileStream = new SQLiteDB.Model.FileStream();
            fileStream.Path = file;
            List<SQLiteDB.Model.FileStream> fileStreams = sQLLiteManager.SelectRecordByPath(fileStream);
            if (fileStreams.Count == 0)
            {
                string filename = Path.GetFileName(file);
                fileStream.Name = filename;
                fileStream.Flgcopy = 0;
                fileStream.Dimension = 0;
                sQLLiteManager.SaveRecord(fileStream);
            }
            else
            {

            }
        }

        public static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", path);
        }
    }
}
