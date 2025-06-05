namespace LyutiyShopSWAG
{
    partial class MAIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            goToGoodsButt = new Button();
            goToPayButton = new Button();
            goOUTbutton = new Button();
            entry = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)entry).BeginInit();
            SuspendLayout();
            // 
            // goToGoodsButt
            // 
            goToGoodsButt.Location = new Point(98, 517);
            goToGoodsButt.Name = "goToGoodsButt";
            goToGoodsButt.Size = new Size(170, 30);
            goToGoodsButt.TabIndex = 0;
            goToGoodsButt.Text = "Пойти к стеллажам";
            goToGoodsButt.UseVisualStyleBackColor = true;
            // 
            // goToPayButton
            // 
            goToPayButton.Location = new Point(369, 517);
            goToPayButton.Name = "goToPayButton";
            goToPayButton.Size = new Size(170, 30);
            goToPayButton.TabIndex = 1;
            goToPayButton.Text = "Пойти к кассе";
            goToPayButton.UseVisualStyleBackColor = true;
            // 
            // goOUTbutton
            // 
            goOUTbutton.Location = new Point(652, 517);
            goOUTbutton.Name = "goOUTbutton";
            goOUTbutton.Size = new Size(170, 30);
            goOUTbutton.TabIndex = 2;
            goOUTbutton.Text = "Покинуть магазин";
            goOUTbutton.UseVisualStyleBackColor = true;
            // 
            // entry
            // 
            entry.ImageLocation = "C:\\Users\\Jopa\\source\\repos\\LyutiyShopSWAG\\LyutiyShopSWAG\\data\\entry.jpg";
            entry.Location = new Point(64, 9);
            entry.Name = "entry";
            entry.Size = new Size(796, 502);
            entry.TabIndex = 3;
            entry.TabStop = false;
            // 
            // MAIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 562);
            Controls.Add(entry);
            Controls.Add(goOUTbutton);
            Controls.Add(goToPayButton);
            Controls.Add(goToGoodsButt);
            Name = "MAIN";
            Text = "Добро пожаловать!";
            ((System.ComponentModel.ISupportInitialize)entry).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button goToGoodsButt;
        private Button goToPayButton;
        private Button goOUTbutton;
        private PictureBox entry;
    }
}
