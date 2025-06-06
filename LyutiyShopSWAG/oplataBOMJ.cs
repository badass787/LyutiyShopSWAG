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
    public partial class oplataBOMJ : Form
    {
        public oplataBOMJ()
        {
            InitializeComponent();
        }

        private void PAYbutton_Click(object sender, EventArgs e)
        {
            AAAAAA form1 = new AAAAAA();
            this.Hide();
            form1.ShowDialog();
            this.Close();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Shelves formShelv = new Shelves();
            var presenter = new StellajPresenter(formShelv);
            this.Hide();
            formShelv.ShowDialog();
            this.Close();

        }

        private void oplataBOMJ_Load(object sender, EventArgs e)
        {

        }
    }
}
