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

        public event EventHandler balClicked;
        public event EventHandler BOMJ;



        public oplataForm()
        {
            InitializeComponent();
            BOMJ += OnBOMJ;
        }

        private void kartaButton_Click(object sender, EventArgs e)
        {
            bonusi form2 = new bonusi();
            form2.ShowDialog();
            PayByCardClicked?.Invoke(this, EventArgs.Empty);
        }

        private void NalButton_Click(object sender, EventArgs e)
        {
            bonusi form2 = new bonusi();
            form2.ShowDialog();
            PayByCashClicked?.Invoke(this, EventArgs.Empty);
        }



        private void removeButton_Click(object sender, EventArgs e)
        {
            Shelves shelves = new Shelves();
            var presenter = new StellajPresenter(shelves);
            shelves.ShowDialog();
        }

        private void balansButt_Click(object sender, EventArgs e)
        {
            balClicked?.Invoke(this, EventArgs.Empty);
        }

        private void returnToMain_Click(object sender, EventArgs e)
        {
            MAIN form1 = new MAIN();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void OnBOMJ(object? sender, EventArgs e)
        {
            oplataBOMJ bomjForm = new oplataBOMJ();
            this.Hide();
            bomjForm.ShowDialog();
            this.Close();
        }

        public void TriggerBOMJ()
        {
            BOMJ?.Invoke(this, EventArgs.Empty);
        }

        private void oplataForm_Load(object sender, EventArgs e)
        {

        }
    }

}
