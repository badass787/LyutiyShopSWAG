namespace LyutiyShopSWAG
{
    partial class oplataBOMJ
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
            removeButton = new Button();
            PAYbutton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // removeButton
            // 
            removeButton.Location = new Point(103, 498);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(120, 50);
            removeButton.TabIndex = 11;
            removeButton.Text = "Убрать что-то из корзины";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // PAYbutton
            // 
            PAYbutton.Location = new Point(380, 498);
            PAYbutton.Name = "PAYbutton";
            PAYbutton.Size = new Size(120, 50);
            PAYbutton.TabIndex = 10;
            PAYbutton.Text = "Оплатить натурой...";
            PAYbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(82, 24);
            label1.Name = "label1";
            label1.Size = new Size(458, 46);
            label1.TabIndex = 7;
            label1.Text = "Оплата наличкой, по карте?";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(571, 366);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(103, 451);
            label2.Name = "label2";
            label2.Size = new Size(420, 30);
            label2.TabIndex = 12;
            label2.Text = "Похоже, что денег всё-таки не хватает...";
            // 
            // oplataBOMJ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 560);
            Controls.Add(label2);
            Controls.Add(removeButton);
            Controls.Add(PAYbutton);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "oplataBOMJ";
            Text = "Упс...";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button removeButton;
        private Button PAYbutton;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}