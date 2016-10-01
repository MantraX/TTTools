namespace TTTools
{
    partial class StartForm
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
            this.btnGmad = new System.Windows.Forms.Button();
            this.btnPointshop = new System.Windows.Forms.Button();
            this.btnWorkshop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGmad
            // 
            this.btnGmad.Location = new System.Drawing.Point(13, 13);
            this.btnGmad.Name = "btnGmad";
            this.btnGmad.Size = new System.Drawing.Size(259, 59);
            this.btnGmad.TabIndex = 0;
            this.btnGmad.Text = "Extract Gmad";
            this.btnGmad.UseVisualStyleBackColor = true;
            this.btnGmad.Click += new System.EventHandler(this.btnGmad_Click);
            // 
            // btnPointshop
            // 
            this.btnPointshop.Location = new System.Drawing.Point(13, 78);
            this.btnPointshop.Name = "btnPointshop";
            this.btnPointshop.Size = new System.Drawing.Size(259, 59);
            this.btnPointshop.TabIndex = 1;
            this.btnPointshop.Text = "Generate Pointshop Lua";
            this.btnPointshop.UseVisualStyleBackColor = true;
            // 
            // btnWorkshop
            // 
            this.btnWorkshop.Location = new System.Drawing.Point(13, 143);
            this.btnWorkshop.Name = "btnWorkshop";
            this.btnWorkshop.Size = new System.Drawing.Size(259, 59);
            this.btnWorkshop.TabIndex = 2;
            this.btnWorkshop.Text = "Generate FastDL Lua";
            this.btnWorkshop.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.btnWorkshop);
            this.Controls.Add(this.btnPointshop);
            this.Controls.Add(this.btnGmad);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGmad;
        private System.Windows.Forms.Button btnPointshop;
        private System.Windows.Forms.Button btnWorkshop;
    }
}