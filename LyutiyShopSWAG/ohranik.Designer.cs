namespace LyutiyShopSWAG
{
    partial class ohranik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ohranik));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(598, 437);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 23F);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(110, 3);
            label1.Name = "label1";
            label1.Size = new Size(438, 52);
            label1.TabIndex = 1;
            label1.Text = "МОЛОДОЙ ЧЕЛОВЕК!...";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(272, 509);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 2;
            button1.Text = "ВАЛИМ!!!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ohranik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 561);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ohranik";
            Text = "Упс...";
            Load += ohranik_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
    }
}