namespace tthk_dragndrop
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
            this.scaleUpLabel = new System.Windows.Forms.Label();
            this.scaleDownLabel = new System.Windows.Forms.Label();
            this.heightAndWeightLabel = new System.Windows.Forms.Label();
            this.gameTimerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(40, 35);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(2004, 837);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // viewLabel
            // 
            this.viewLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.viewLabel.Location = new System.Drawing.Point(138, 655);
            this.viewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(274, 153);
            this.viewLabel.TabIndex = 4;
            this.viewLabel.Text = "Вид";
            this.viewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formLabel
            // 
            this.formLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.formLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.formLabel.Location = new System.Drawing.Point(922, 655);
            this.formLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(274, 153);
            this.formLabel.TabIndex = 5;
            this.formLabel.Text = "Форма";
            this.formLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.infoLabel.Location = new System.Drawing.Point(1635, 655);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(376, 153);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Информация";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scaleUpLabel
            // 
            this.scaleUpLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.scaleUpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scaleUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.scaleUpLabel.Location = new System.Drawing.Point(1635, 348);
            this.scaleUpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scaleUpLabel.Name = "scaleUpLabel";
            this.scaleUpLabel.Size = new System.Drawing.Size(376, 153);
            this.scaleUpLabel.TabIndex = 7;
            this.scaleUpLabel.Text = "Увеличить";
            this.scaleUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scaleDownLabel
            // 
            this.scaleDownLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.scaleDownLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scaleDownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.scaleDownLabel.Location = new System.Drawing.Point(1635, 75);
            this.scaleDownLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scaleDownLabel.Name = "scaleDownLabel";
            this.scaleDownLabel.Size = new System.Drawing.Size(376, 153);
            this.scaleDownLabel.TabIndex = 8;
            this.scaleDownLabel.Text = "Уменьшить";
            this.scaleDownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heightAndWeightLabel
            // 
            this.heightAndWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.heightAndWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (186)));
            this.heightAndWeightLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.heightAndWeightLabel.Location = new System.Drawing.Point(1629, 823);
            this.heightAndWeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightAndWeightLabel.Name = "heightAndWeightLabel";
            this.heightAndWeightLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.heightAndWeightLabel.Size = new System.Drawing.Size(376, 0);
            this.heightAndWeightLabel.TabIndex = 11;
            this.heightAndWeightLabel.Text = "Ширина и высота";
            this.heightAndWeightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gameTimerLabel
            // 
            this.gameTimerLabel.Location = new System.Drawing.Point(43, 6);
            this.gameTimerLabel.Name = "gameTimerLabel";
            this.gameTimerLabel.Size = new System.Drawing.Size(201, 24);
            this.gameTimerLabel.TabIndex = 12;
            this.gameTimerLabel.Text = "Таймер для игры";
            // 
            // DragAndDropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2062, 892);
            this.Controls.Add(this.gameTimerLabel);
            this.Controls.Add(this.heightAndWeightLabel);
            this.Controls.Add(this.scaleDownLabel);
            this.Controls.Add(this.scaleUpLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.viewLabel);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DragAndDropForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label gameTimerLabel;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label scaleUpLabel;
        private System.Windows.Forms.Label scaleDownLabel;
        private System.Windows.Forms.Label heightAndWeightLabel;
    }
}

