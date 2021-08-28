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

namespace FindDuplicatedFiles
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //private string outputFilePath = Application.StartupPath;

        private string firstFolderPath = null;
        private string secondFolderPath = null;

        // Full filenames (with path)
        private List<string> firstFolderFilePaths;
        private List<string> secondFolderFilePaths;

        private List<string> duplicatedFiles;

        private List<string> GetFiles(string folderPath)
        {
            if (!(Directory.Exists(folderPath)))
            {
                MessageBox.Show("Selected directory not found!", "Error");
                return null;
            }

            int filesCounter = 0;
            List<string> files = new List<string>();

            IEnumerable<string> rootFiles = Directory.EnumerateFiles(folderPath, "*", SearchOption.TopDirectoryOnly);

            // At first we find all files in root directory
            foreach (string f in rootFiles)
            {
                //logTB.Text += Environment.NewLine + "Root folder: " + f.Substring(folderPath.Length + 1) + Environment.NewLine;
                //logTB.Text += Environment.NewLine + f.Substring(folderPath.Length + 1) + Environment.NewLine;
                //PrintFileName(f);

                files.Add(f);
                filesCounter++;
            }

            //logTB.Text += Environment.NewLine;

            IEnumerable<string> directories = Directory.EnumerateDirectories(folderPath, "*", SearchOption.AllDirectories);

            // Next we find files from subfolders
            foreach (string dir in directories)
            {
                //logTB.Text += "Subfolder: " + dir + Environment.NewLine;
                IEnumerable<string> subfolderFiles = Directory.EnumerateFiles(dir, "*", SearchOption.TopDirectoryOnly);

                foreach (string f in subfolderFiles)
                {
                    //logTB.Text += f.Substring(dir.Length + 1) + Environment.NewLine;
                    //PrintFileName(f, dir);

                    files.Add(f);
                    filesCounter++;
                }
                //logTB.Text += Environment.NewLine;
            }

            logTB.Text += "Total files: " + filesCounter.ToString() + Environment.NewLine + "-----";
            logTB.Text += Environment.NewLine;

            //PrintFileList(files);

            return files;
        }

        private void PrintFileList(List<string> list)
        {
            foreach (var i in list)
            {
                logTB.Text += i;
                logTB.Text += Environment.NewLine;
            }
        }

        // Leave just filename + extension
        private string GetFileName(string filePath)
        {
            string fileName = string.Empty;

            int ind = filePath.LastIndexOf(@"\");

            if (ind > 0)
            {
                fileName = filePath.Substring(ind + 1);
            }
       
            return fileName;
        }

        private void SelectFirstFolderBtn_Click(object sender, EventArgs e)
        {
            // Clean output on each selecting first folder
            logTB.Text = string.Empty;

            firstFolderBrowser.ShowDialog();

            // If user doesn't select any folder and closed dialog
            if (firstFolderBrowser.@SelectedPath == string.Empty)
            {
                return;
            }

            firstFolderPath = firstFolderBrowser.@SelectedPath;

            logTB.Text += "First selected folder: " + firstFolderPath + Environment.NewLine;

            firstFolderFilePaths = GetFiles(firstFolderPath);

            firstFolderPathTB.Text = firstFolderPath;
        }

        private void SelectSecondFolderBtn_Click(object sender, EventArgs e)
        {
            // If first folder wasn't selected we restrict selecting second folder
            if (firstFolderBrowser.@SelectedPath == string.Empty)
            {
                MessageBox.Show("Please select first folder before selecting second one!", "Error");
                return;
            }

            secondFolderBrowser.ShowDialog();

            if (secondFolderBrowser.@SelectedPath == string.Empty)
            {
                return;
            }

            secondFolderPath = secondFolderBrowser.@SelectedPath;

            logTB.Text += "Second selected folder: " + secondFolderPath + Environment.NewLine;

            secondFolderFilePaths = GetFiles(secondFolderPath);

            secondFolderPathTB.Text = secondFolderPath;

            FindDuplicatedFiles(firstFolderFilePaths, secondFolderFilePaths);
        }

        private void FindDuplicatedFiles(List<string> firstFileList, List<string> secondFileList)
        {
            duplicatedFiles = new List<string>();

            string f1;
            string f2;

            foreach (var i in firstFileList)
            {
                f1 = GetFileName(i);

                foreach (var j in secondFileList)
                {
                    f2 = GetFileName(j);

                    if (f1 == f2)
                    {
                        duplicatedFiles.Add(j);
                        break;
                    }
                }
            }

            logTB.Text += "Duplicates found: " + duplicatedFiles.Count + Environment.NewLine;
            logTB.Text += "Duplicated files:" + Environment.NewLine;

            PrintFileList(duplicatedFiles);

        }

        //private void OpenOutputFile()
        //{
        //    if (File.Exists(outputFilePath))
        //    {
        //        Process.Start(outputFilePath);
        //    }
        //}

        //private void WriteToFile(List<string> data)
        //{
        //    if (!File.Exists(outputFilePath))
        //    {
        //        File.Create(outputFilePath);
        //    }

        //    try
        //    {
        //        File.WriteAllLines(outputFilePath, data);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}
    }
}
