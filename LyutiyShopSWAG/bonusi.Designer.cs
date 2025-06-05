namespace LyutiyShopSWAG
{
    partial class bonusi
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
            kopimButton = new Button();
            spisivaemButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kopimButton
            // 
            kopimButton.Location = new Point(365, 452);
            kopimButton.Name = "kopimButton";
            kopimButton.Size = new Size(120, 50);
            kopimButton.TabIndex = 9;
            kopimButton.Text = "Копим";
            kopimButton.UseVisualStyleBackColor = true;
            // 
            // spisivaemButton
            // 
            spisivaemButton.Location = new Point(112, 452);
            spisivaemButton.Name = "spisivaemButton";
            spisivaemButton.Size = new Size(120, 50);
            spisivaemButton.TabIndex = 8;
            spisivaemButton.Text = "Списываем";
            spisivaemButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(82, 9);
            label1.Name = "label1";
            label1.Size = new Size(449, 46);
            label1.TabIndex = 7;
            label1.Text = "Бонусы копим, списываем?";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(571, 366);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // bonusi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 514);
            Controls.Add(kopimButton);
            Controls.Add(spisivaemButton);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "bonusi";
            Text = "bonusi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button kopimButton;
        private Button spisivaemButton;
        private Label label1;
        private PictureBox pictureBox1;
    }
}