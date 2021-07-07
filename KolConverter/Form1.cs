using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using KolReader.ItemStrukt;

namespace KolConverter
{
    public partial class Form1 : Form
    {
        public string Path;
        public Form1()
        {
            InitializeComponent();
            LoadPath();
            BuildViewColumns();
          
        }

        private void BuildViewColumns()
        {
            objectListView1.AllColumns.Add(new OLVColumn("Name", "name"));
            objectListView1.AllColumns[0].Width = 200;
            objectListView1.AllColumns[0].AspectName = "Name";
            objectListView1.AllColumns.Add(new OLVColumn("Type", "type"));
            objectListView1.AllColumns[1].Width = 200;
            objectListView1.AllColumns[1].AspectName = "Itemtype";
            objectListView1.AllColumns.Add(new OLVColumn("Sockets", "sockets"));
            objectListView1.AllColumns[2].Width = 200;
            objectListView1.AllColumns[2].AspectName = "Sockets";
            objectListView1.AllColumns.Add(new OLVColumn("ED/AR", "edar"));
            objectListView1.AllColumns[3].Width = 200;
            objectListView1.AllColumns[3].AspectName = "EDAR";
            objectListView1.AllColumns.Add(new OLVColumn("Ethereal", "ethereal"));
            objectListView1.AllColumns[4].Width = 200;
            objectListView1.AllColumns[4].AspectName = "Ethereal";
            objectListView1.AllColumns.Add(new OLVColumn("Acc/Char", "Accchar"));
            objectListView1.AllColumns[5].Width = 200;
            objectListView1.AllColumns[5].AspectName = "AccChar";
 


            objectListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Clickable;
            objectListView1.View = System.Windows.Forms.View.Details;
            objectListView1.RebuildColumns();
        }

        private void LoadPath()
        {
            try
            {
                string filepath = Application.StartupPath + "\\path.txt";
                using (StreamReader sr = File.OpenText(filepath))
                {
                    string s = "";
                    if ((s = sr.ReadLine()) != null)
                    {
                        Path = s;
                        label1.Text = s;
                        button1.Enabled = true;
                    }
                }
            }
            catch
            {
            }

        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            //load
            ItemManager.Clear();

            ProcessDirectory(Path);

            ItemManager.FillTreeUnFiltered(objectListView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //load folder
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            folderDialog.SelectedPath  = Path;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                ItemManager.Clear();
                ProcessDirectory(folderDialog.SelectedPath);
               
                
                ItemManager.FillTreeUnFiltered(objectListView1);
            }
        }

        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                string fileExt = System.IO.Path.GetExtension(fileName);
                if (fileExt == ".txt")
                {
                    ItemManager.LoadItems(fileName);
                }
            }

         

        // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        public static void ProcessDirectoryKeys(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                string fileExt = System.IO.Path.GetExtension(fileName);
                if (fileExt == ".txt")
                {
                    ItemManager.LoadKeys(fileName);
                }
            }



            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectoryKeys(subdirectory);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //path
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                Path = folderDialog.SelectedPath;
                string filepath = Application.StartupPath + "\\path.txt";
         

                using (FileStream fs = File.Create(filepath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(Path);
                    fs.Write(info, 0, info.Length);
                }
                label1.Text = Path;
                button1.Enabled = true;
            }
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            //runecounter
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Path;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ItemManager.ListRunes(fileDialog.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // show keys
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            folderDialog.SelectedPath = Path;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                ItemManager.Clear(); 
                ProcessDirectoryKeys(folderDialog.SelectedPath);


                ItemManager.FillTreeUnFiltered(objectListView1);

            }
        }

        private void filterBox_TextChanged(object sender, EventArgs e)
        {
            ItemManager.FilterItems(objectListView1,filterBox.Text);
        }

        private void CreateTorches()
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            folderDialog.SelectedPath = Path;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                ItemManager.Clear();
                ReadTorchFolders(folderDialog.SelectedPath);

                 
            }

        }
        private void ReadTorchFolders(string path)
        {
            string[] fileEntries = Directory.GetFiles(path);
            foreach (string fileName in fileEntries)
            {
                string fileExt = System.IO.Path.GetExtension(fileName);
                if (fileExt == ".txt")
                {
                    ItemManager.ListTorches(fileName);
                }
            }
            string[] subdirectoryEntries = Directory.GetDirectories(path);
            foreach (string subdirectory in subdirectoryEntries)
                ReadTorchFolders(subdirectory);
            ItemManager.TorchesToClipboard();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            CreateTorches();

        }
    }
}
