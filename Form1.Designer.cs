
namespace LargeAddressAwarePatcher
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
            this.ui_FilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ui_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.ui_Browse = new System.Windows.Forms.Button();
            this.ui_Patch = new System.Windows.Forms.Button();
            this.ui_Unpatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ui_FilePath
            // 
            this.ui_FilePath.Location = new System.Drawing.Point(44, 12);
            this.ui_FilePath.Name = "ui_FilePath";
            this.ui_FilePath.Size = new System.Drawing.Size(356, 20);
            this.ui_FilePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File:";
            // 
            // ui_Dialog
            // 
            this.ui_Dialog.DefaultExt = "exe";
            this.ui_Dialog.FileName = "openFileDialog1";
            this.ui_Dialog.Filter = "Executable Files|*.exe";
            this.ui_Dialog.Title = "Select file to patch.";
            // 
            // ui_Browse
            // 
            this.ui_Browse.Location = new System.Drawing.Point(406, 10);
            this.ui_Browse.Name = "ui_Browse";
            this.ui_Browse.Size = new System.Drawing.Size(75, 23);
            this.ui_Browse.TabIndex = 2;
            this.ui_Browse.Text = "Browse";
            this.ui_Browse.UseVisualStyleBackColor = true;
            this.ui_Browse.Click += new System.EventHandler(this.ui_Browse_Click);
            // 
            // ui_Patch
            // 
            this.ui_Patch.Location = new System.Drawing.Point(144, 38);
            this.ui_Patch.Name = "ui_Patch";
            this.ui_Patch.Size = new System.Drawing.Size(75, 23);
            this.ui_Patch.TabIndex = 3;
            this.ui_Patch.Text = "Patch";
            this.ui_Patch.UseVisualStyleBackColor = true;
            this.ui_Patch.Click += new System.EventHandler(this.ui_Patch_Click);
            // 
            // ui_Unpatch
            // 
            this.ui_Unpatch.Location = new System.Drawing.Point(225, 38);
            this.ui_Unpatch.Name = "ui_Unpatch";
            this.ui_Unpatch.Size = new System.Drawing.Size(75, 23);
            this.ui_Unpatch.TabIndex = 4;
            this.ui_Unpatch.Text = "Unpatch";
            this.ui_Unpatch.UseVisualStyleBackColor = true;
            this.ui_Unpatch.Click += new System.EventHandler(this.ui_Unpatch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 73);
            this.Controls.Add(this.ui_Unpatch);
            this.Controls.Add(this.ui_Patch);
            this.Controls.Add(this.ui_Browse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ui_FilePath);
            this.Name = "Form1";
            this.Text = "LargeAddressAwarePatcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ui_FilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ui_Dialog;
        private System.Windows.Forms.Button ui_Browse;
        private System.Windows.Forms.Button ui_Patch;
        private System.Windows.Forms.Button ui_Unpatch;
    }
}

