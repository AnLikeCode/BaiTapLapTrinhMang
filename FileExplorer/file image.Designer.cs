﻿namespace FileExplorer
{
    partial class file_image
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
            this.pbMainlmage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainlmage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMainlmage
            // 
            this.pbMainlmage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMainlmage.Location = new System.Drawing.Point(0, 0);
            this.pbMainlmage.Name = "pbMainlmage";
            this.pbMainlmage.Size = new System.Drawing.Size(800, 450);
            this.pbMainlmage.TabIndex = 0;
            this.pbMainlmage.TabStop = false;
            // 
            // file_image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbMainlmage);
            this.Name = "file_image";
            this.Text = "file_image";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainlmage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainlmage;
    }
}