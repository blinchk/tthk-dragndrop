﻿namespace tthk_dragndrop
{
    partial class DragAndDropForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.viewLabel = new System.Windows.Forms.Label();
            this.formLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(55, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(691, 283);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // viewLabel
            // 
            this.viewLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewLabel.Location = new System.Drawing.Point(55, 332);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(183, 100);
            this.viewLabel.TabIndex = 4;
            this.viewLabel.Text = "Вид";
            this.viewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formLabel
            // 
            this.formLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.formLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formLabel.Location = new System.Drawing.Point(309, 332);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(183, 100);
            this.formLabel.TabIndex = 5;
            this.formLabel.Text = "Форма";
            this.formLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.Location = new System.Drawing.Point(564, 332);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(183, 100);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Информация";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragAndDropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.viewLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "DragAndDropForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}
