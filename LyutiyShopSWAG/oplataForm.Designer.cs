namespace LyutiyShopSWAG
{
    partial class oplataForm
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
            label1 = new Label();
            kartaButton = new Button();
            NalButton = new Button();
            removeButton = new Button();
            returnToMain = new Button();
            balansButt = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\Jopa\\source\\repos\\LyutiyShopSWAG\\LyutiyShopSWAG\\data\\cassier.jpg";
            pictureBox1.Location = new Point(14, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(571, 366);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(80, 9);
            label1.Name = "label1";
            label1.Size = new Size(458, 46);
            label1.TabIndex = 1;
            label1.Text = "Оплата наличкой, по карте?";
            // 
            // kartaButton
            // 
            kartaButton.Location = new Point(37, 450);
            kartaButton.Name = "kartaButton";
            kartaButton.Size = new Size(100, 50);
            kartaButton.TabIndex = 2;
            kartaButton.Text = "Оплатить картой";
            kartaButton.UseVisualStyleBackColor = true;
            kartaButton.Click += kartaButton_Click;
            // 
            // NalButton
            // 
            NalButton.Location = new Point(143, 450);
            NalButton.Name = "NalButton";
            NalButton.Size = new Size(100, 50);
            NalButton.TabIndex = 3;
            NalButton.Text = "Оплатить наличными";
            NalButton.UseVisualStyleBackColor = true;
            NalButton.Click += NalButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(461, 450);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(100, 50);
            removeButton.TabIndex = 5;
            removeButton.Text = "К корзине...";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // returnToMain
            // 
            returnToMain.Location = new Point(355, 450);
            returnToMain.Name = "returnToMain";
            returnToMain.Size = new Size(100, 50);
            returnToMain.TabIndex = 6;
            returnToMain.Text = "Уйти от кассы";
            returnToMain.UseVisualStyleBackColor = true;
            returnToMain.Click += returnToMain_Click;
            // 
            // balansButt
            // 
            balansButt.Location = new Point(249, 450);
            balansButt.Name = "balansButt";
            balansButt.Size = new Size(100, 50);
            balansButt.TabIndex = 7;
            balansButt.Text = "Показать баланс";
            balansButt.UseVisualStyleBackColor = true;
            balansButt.Click += balansButt_Click;
            // 
            // oplataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 533);
            Controls.Add(balansButt);
            Controls.Add(returnToMain);
            Controls.Add(removeButton);
            Controls.Add(NalButton);
            Controls.Add(kartaButton);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "oplataForm";
            Text = "У кассы";
            Load += oplataForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button kartaButton;
        private Button NalButton;
        private Button removeButton;
        private Button returnToMain;
        private Button balansButt;
    }
}