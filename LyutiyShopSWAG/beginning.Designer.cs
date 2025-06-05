namespace LyutiyShopSWAG
{
    partial class beginning
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
            pictureBox1 = new PictureBox();
            voytiVButt = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\Jopa\\source\\repos\\LyutiyShopSWAG\\LyutiyShopSWAG\\data\\outside.jpg";
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 500);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // voytiVButt
            // 
            voytiVButt.Location = new Point(366, 506);
            voytiVButt.Name = "voytiVButt";
            voytiVButt.Size = new Size(94, 29);
            voytiVButt.TabIndex = 1;
            voytiVButt.Text = "Войти...";
            voytiVButt.UseVisualStyleBackColor = true;
            // 
            // beginning
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 543);
            Controls.Add(voytiVButt);
            Controls.Add(pictureBox1);
            Name = "beginning";
            Text = "Начало";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button voytiVButt;
    }
}