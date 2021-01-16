namespace extension_detector_v2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_open_folder = new System.Windows.Forms.Button();
            this.txtbox_result = new System.Windows.Forms.TextBox();
            this.btn_save_folder = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtbox_start_folder_location = new System.Windows.Forms.TextBox();
            this.txtbox_end_folder_location = new System.Windows.Forms.TextBox();
            this.lbl_found = new System.Windows.Forms.Label();
            this.txtbox_count = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(37, 129);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(188, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.Location = new System.Drawing.Point(12, 22);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(34, 13);
            this.lbl_hello.TabIndex = 1;
            this.lbl_hello.Text = "Hello!";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btn_open_folder
            // 
            this.btn_open_folder.Location = new System.Drawing.Point(12, 38);
            this.btn_open_folder.Name = "btn_open_folder";
            this.btn_open_folder.Size = new System.Drawing.Size(75, 23);
            this.btn_open_folder.TabIndex = 2;
            this.btn_open_folder.Text = "Open Folder";
            this.btn_open_folder.UseVisualStyleBackColor = true;
            this.btn_open_folder.Click += new System.EventHandler(this.btn_open_folder_Click);
            // 
            // txtbox_result
            // 
            this.txtbox_result.Location = new System.Drawing.Point(15, 182);
            this.txtbox_result.Multiline = true;
            this.txtbox_result.Name = "txtbox_result";
            this.txtbox_result.ReadOnly = true;
            this.txtbox_result.Size = new System.Drawing.Size(237, 145);
            this.txtbox_result.TabIndex = 4;
            this.txtbox_result.TextChanged += new System.EventHandler(this.txtbox_result_TextChanged);
            // 
            // btn_save_folder
            // 
            this.btn_save_folder.Location = new System.Drawing.Point(12, 89);
            this.btn_save_folder.Name = "btn_save_folder";
            this.btn_save_folder.Size = new System.Drawing.Size(75, 23);
            this.btn_save_folder.TabIndex = 5;
            this.btn_save_folder.Text = "Save Folder";
            this.btn_save_folder.UseVisualStyleBackColor = true;
            this.btn_save_folder.Click += new System.EventHandler(this.btn_save_folder_Click);
            // 
            // txtbox_start_folder_location
            // 
            this.txtbox_start_folder_location.Location = new System.Drawing.Point(97, 40);
            this.txtbox_start_folder_location.Name = "txtbox_start_folder_location";
            this.txtbox_start_folder_location.ReadOnly = true;
            this.txtbox_start_folder_location.Size = new System.Drawing.Size(155, 20);
            this.txtbox_start_folder_location.TabIndex = 6;
            // 
            // txtbox_end_folder_location
            // 
            this.txtbox_end_folder_location.Location = new System.Drawing.Point(97, 92);
            this.txtbox_end_folder_location.Name = "txtbox_end_folder_location";
            this.txtbox_end_folder_location.ReadOnly = true;
            this.txtbox_end_folder_location.Size = new System.Drawing.Size(155, 20);
            this.txtbox_end_folder_location.TabIndex = 7;
            // 
            // lbl_found
            // 
            this.lbl_found.AutoSize = true;
            this.lbl_found.Location = new System.Drawing.Point(26, 69);
            this.lbl_found.Name = "lbl_found";
            this.lbl_found.Size = new System.Drawing.Size(61, 13);
            this.lbl_found.TabIndex = 8;
            this.lbl_found.Text = "Files found:";
            // 
            // txtbox_count
            // 
            this.txtbox_count.Location = new System.Drawing.Point(97, 66);
            this.txtbox_count.Name = "txtbox_count";
            this.txtbox_count.ReadOnly = true;
            this.txtbox_count.Size = new System.Drawing.Size(155, 20);
            this.txtbox_count.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 333);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(237, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Progress:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(264, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtbox_count);
            this.Controls.Add(this.lbl_found);
            this.Controls.Add(this.txtbox_end_folder_location);
            this.Controls.Add(this.txtbox_start_folder_location);
            this.Controls.Add(this.btn_save_folder);
            this.Controls.Add(this.txtbox_result);
            this.Controls.Add(this.btn_open_folder);
            this.Controls.Add(this.lbl_hello);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Extension-Detector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_open_folder;
        private System.Windows.Forms.TextBox txtbox_result;
        private System.Windows.Forms.Button btn_save_folder;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtbox_start_folder_location;
        private System.Windows.Forms.TextBox txtbox_end_folder_location;
        private System.Windows.Forms.Label lbl_found;
        private System.Windows.Forms.TextBox txtbox_count;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}

