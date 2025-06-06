using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyutiyShopSWAG
{
    public partial class bonusi : Form
    {
        public bonusi()
        {
            InitializeComponent();
        }

        private void spisivaemButton_Click(object sender, EventArgs e)
        {
            Vallet.Instance.BonusCard.flag = true;
            MessageBox.Show("Вы выбрали списать");
            this.Close();
        }

        private void kopimButton_Click(object sender, EventArgs e)
        {
            Vallet.Instance.BonusCard.flag = false;
            MessageBox.Show("Вы выбрали копить");
            this.Close();
        }
    }
}
