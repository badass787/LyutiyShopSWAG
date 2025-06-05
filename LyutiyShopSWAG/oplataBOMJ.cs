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
            form1.ShowDialog();
            
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Shelves formShelv = new Shelves();
            formShelv.ShowDialog();
            
        }
    }
}
