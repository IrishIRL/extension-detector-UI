using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using Winista.Mime;

namespace extension_detector_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_hello.Text = "Hello, " + Environment.UserName + "!";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void btn_open_folder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    txtbox_start_folder_location.Text = (fbd.SelectedPath);
                    txtbox_count.Text = (files.Length.ToString());
                }
            }
        }

        private void txtbox_result_TextChanged(object sender, EventArgs e)
        {
            txtbox_result.ScrollBars = ScrollBars.Vertical;
        }

        private void btn_save_folder_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                txtbox_end_folder_location.Text = (folderName);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            int i;
            int x = 10;
           
            string dir = txtbox_start_folder_location.Text + "/file";
            System.IO.Directory.CreateDirectory(txtbox_end_folder_location.Text);
            string newdir = txtbox_end_folder_location.Text + "/file";
            var fileCount = Convert.ToInt32(this.txtbox_count.Text);
            progressBar1.Maximum = fileCount;

            for (i = 1; i < fileCount; i++)
            {
                try
                {
                    var mimeTypes = new MimeTypes();
                    var mimeType = mimeTypes.GetMimeTypeFromFile(dir + x); //Probably can think of a way checking files with no matter if they are named "fileXX", but I assume the task does not require it. 
                    var image = "image/jpeg";


                    if (mimeType == null)
                    {
                        txtbox_result.Text += ("File" + x + " has unknown extension." + Environment.NewLine);
                    }

                    else if (mimeType.ToString() == "image/jpeg")
                    {

                        try
                        {
                            File.Copy(dir + x, newdir + x + ".jpeg");
                            txtbox_result.Text += ("File" + x + " is an " + mimeType + ". Converted to .jpeg in detected_files folder." + Environment.NewLine);
                        }
                        catch
                        {
                            txtbox_result.Text += ("File" + x + " is an " + mimeType + ". It looks like the file was already copied to detected_files folder." + Environment.NewLine);
                        }

                    }

                    else
                    {
                        txtbox_result.Text += ("File" + x + " is a/an " + mimeType + "." + Environment.NewLine);

                    }


                }
                catch
                {
                    txtbox_result.Text += ("Something went wrong, Maybe the file" + x + " does not exist?" + Environment.NewLine);
                }
                x++;
                txtbox_result.SelectionStart = txtbox_result.Text.Length;
                txtbox_result.ScrollToCaret();

                if (progressBar1.Value < fileCount)
                {
                    progressBar1.Value = x;
                }
                else{}
               
            }
            txtbox_result.Text += (Environment.NewLine+"Finished!");
        }
    }
}
