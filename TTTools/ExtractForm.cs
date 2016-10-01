using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TTTools
{
    public partial class ExtractForm : Form
    {
        public string inputpath, outputpath;
        public List<string> filepaths;

        public ExtractForm()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            fbdGmadInput.ShowDialog();
            inputpath = fbdGmadInput.SelectedPath;
            txtGmadPath.Text = inputpath;
            txtOutputPath.Text = inputpath;
            filepaths = getGmadFiles(inputpath).ToList();

            foreach (string file in filepaths)
            {
                listGmad.Items.Add(Path.GetFileName(file));
            }
        }

        private void fbdGmad_HelpRequest(object sender, EventArgs e)
        {
            
        }

        private string[] getGmadFiles(string path)
        {             
            return Directory.GetFiles(path, "*.gma");
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            processGmad(filepaths.Count, filepaths, outputpath);
        }

        private void btnSelectOutput_Click(object sender, EventArgs e)
        {
            fbdGmadOutput.ShowDialog();
            outputpath = fbdGmadOutput.SelectedPath;
            txtOutputPath.Text = outputpath;
        }

        private void processGmad(int max, List <string> files, string outputpath)
        {
            progressGmad.Maximum = max;
            int counter = 1;
            progressGmad.Value = 0;

            Process p = new Process();
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "gmad.exe";
            
            foreach (string file in files)
            {
                progressGmad.Value = counter;
                counter++;

                if (checkMerge.Checked)
                {
                    p.StartInfo.Arguments = file + " -out " + outputpath;
                }
                else
                {
                    string path = Path.GetFileName(file);
                    path = path.Split(new string[] { ".gma" }, StringSplitOptions.None)[0];
                    p.StartInfo.Arguments = file + " -out " + outputpath + "/" + path;
                }

                p.Start();
                p.WaitForExit();
                if (checkDelete.Checked)
                {
                    File.Delete(file);
                }                         
            }
            MessageBox.Show(String.Format("{0} Gmad files were processed.", files.Count));
        }
    }
}