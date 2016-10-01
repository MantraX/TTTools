namespace TTTools
{
    partial class ExtractForm
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
            this.btnExtract = new System.Windows.Forms.Button();
            this.checkMerge = new System.Windows.Forms.CheckBox();
            this.checkDelete = new System.Windows.Forms.CheckBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtGmadPath = new System.Windows.Forms.TextBox();
            this.listGmad = new System.Windows.Forms.ListBox();
            this.fbdGmadInput = new System.Windows.Forms.FolderBrowserDialog();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnSelectOutput = new System.Windows.Forms.Button();
            this.fbdGmadOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.progressGmad = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(277, 234);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(106, 39);
            this.btnExtract.TabIndex = 0;
            this.btnExtract.Text = "Exctract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // checkMerge
            // 
            this.checkMerge.AutoSize = true;
            this.checkMerge.Location = new System.Drawing.Point(13, 234);
            this.checkMerge.Name = "checkMerge";
            this.checkMerge.Size = new System.Drawing.Size(142, 17);
            this.checkMerge.TabIndex = 1;
            this.checkMerge.Text = "Merge all Gmad together";
            this.checkMerge.UseVisualStyleBackColor = true;
            // 
            // checkDelete
            // 
            this.checkDelete.AutoSize = true;
            this.checkDelete.Location = new System.Drawing.Point(13, 257);
            this.checkDelete.Name = "checkDelete";
            this.checkDelete.Size = new System.Drawing.Size(207, 17);
            this.checkDelete.TabIndex = 2;
            this.checkDelete.Text = "Delete original gmad files after process";
            this.checkDelete.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(358, 282);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(25, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtGmadPath
            // 
            this.txtGmadPath.Location = new System.Drawing.Point(13, 282);
            this.txtGmadPath.Name = "txtGmadPath";
            this.txtGmadPath.ReadOnly = true;
            this.txtGmadPath.Size = new System.Drawing.Size(339, 20);
            this.txtGmadPath.TabIndex = 4;
            this.txtGmadPath.Text = "Select InputPath...";
            // 
            // listGmad
            // 
            this.listGmad.FormattingEnabled = true;
            this.listGmad.Location = new System.Drawing.Point(13, 13);
            this.listGmad.Name = "listGmad";
            this.listGmad.Size = new System.Drawing.Size(370, 212);
            this.listGmad.TabIndex = 5;
            // 
            // fbdGmadInput
            // 
            this.fbdGmadInput.HelpRequest += new System.EventHandler(this.fbdGmad_HelpRequest);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(13, 309);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(339, 20);
            this.txtOutputPath.TabIndex = 6;
            this.txtOutputPath.Text = "Select Output Path...";
            // 
            // btnSelectOutput
            // 
            this.btnSelectOutput.Location = new System.Drawing.Point(358, 306);
            this.btnSelectOutput.Name = "btnSelectOutput";
            this.btnSelectOutput.Size = new System.Drawing.Size(25, 23);
            this.btnSelectOutput.TabIndex = 7;
            this.btnSelectOutput.Text = "...";
            this.btnSelectOutput.UseVisualStyleBackColor = true;
            this.btnSelectOutput.Click += new System.EventHandler(this.btnSelectOutput_Click);
            // 
            // progressGmad
            // 
            this.progressGmad.Location = new System.Drawing.Point(12, 335);
            this.progressGmad.Name = "progressGmad";
            this.progressGmad.Size = new System.Drawing.Size(371, 23);
            this.progressGmad.TabIndex = 8;
            // 
            // ExtractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 366);
            this.Controls.Add(this.progressGmad);
            this.Controls.Add(this.btnSelectOutput);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.listGmad);
            this.Controls.Add(this.txtGmadPath);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.checkDelete);
            this.Controls.Add(this.checkMerge);
            this.Controls.Add(this.btnExtract);
            this.Name = "ExtractForm";
            this.Text = "Extract Gmad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.CheckBox checkMerge;
        private System.Windows.Forms.CheckBox checkDelete;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtGmadPath;
        private System.Windows.Forms.ListBox listGmad;
        private System.Windows.Forms.FolderBrowserDialog fbdGmadInput;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnSelectOutput;
        private System.Windows.Forms.FolderBrowserDialog fbdGmadOutput;
        private System.Windows.Forms.ProgressBar progressGmad;
    }
}

