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
    public partial class oplataForm : Form, IOplataView
    {
        public event EventHandler PayByCardClicked;
        public event EventHandler PayByCashClicked;
        public event EventHandler PayByBonusClicked;
        public event EventHandler CancelClicked;

        public oplataForm()
        {
            InitializeComponent();
        }

        private void kartaButton_Click(object sender, EventArgs e)
        {
            PayByCardClicked?.Invoke(this, EventArgs.Empty);
        }

        private void NalButton_Click(object sender, EventArgs e)
        {
            PayByCashClicked?.Invoke(this, EventArgs.Empty);
        }

        private void bonusPAYbutton_Click(object sender, EventArgs e)
        {
            PayByBonusClicked?.Invoke(this, EventArgs.Empty);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Shelves shelves = new Shelves();
            var presenter = new StellajPresenter(shelves);
            shelves.ShowDialog();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void CloseForm()
        {
            this.Close();
        }
    }

}
