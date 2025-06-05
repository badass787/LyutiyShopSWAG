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
            bonusPAYbutton = new Button();
            removeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(571, 366);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(74, 9);
            label1.Name = "label1";
            label1.Size = new Size(458, 46);
            label1.TabIndex = 1;
            label1.Text = "Оплата наличкой, по карте?";
            // 
            // kartaButton
            // 
            kartaButton.Location = new Point(14, 450);
            kartaButton.Name = "kartaButton";
            kartaButton.Size = new Size(120, 50);
            kartaButton.TabIndex = 2;
            kartaButton.Text = "Оплатить картой";
            kartaButton.UseVisualStyleBackColor = true;
            // 
            // NalButton
            // 
            NalButton.Location = new Point(151, 450);
            NalButton.Name = "NalButton";
            NalButton.Size = new Size(120, 50);
            NalButton.TabIndex = 3;
            NalButton.Text = "Оплатить наличными";
            NalButton.UseVisualStyleBackColor = true;
            // 
            // bonusPAYbutton
            // 
            bonusPAYbutton.Location = new Point(303, 450);
            bonusPAYbutton.Name = "bonusPAYbutton";
            bonusPAYbutton.Size = new Size(120, 50);
            bonusPAYbutton.TabIndex = 4;
            bonusPAYbutton.Text = "Оплатить бонусами";
            bonusPAYbutton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(465, 450);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(120, 50);
            removeButton.TabIndex = 5;
            removeButton.Text = "Убрать что-то из корзины";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // oplataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 517);
            Controls.Add(removeButton);
            Controls.Add(bonusPAYbutton);
            Controls.Add(NalButton);
            Controls.Add(kartaButton);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "oplataForm";
            Text = "У кассы";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button kartaButton;
        private Button NalButton;
        private Button bonusPAYbutton;
        private Button removeButton;
    }
}