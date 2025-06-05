using System.Windows.Forms;

namespace LyutiyShopSWAG
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void goToGoodsButt_Click(object sender, EventArgs e)
        {
            Shelves formShelv = new Shelves();
            var presenter = new StellajPresenter(formShelv);
            formShelv.ShowDialog();
            
        }

        private void goToPayButton_Click(object sender, EventArgs e)
        {
            oplataForm opl = new oplataForm();
            var presenter = new OplataPresenter(opl);
            opl.ShowDialog();
            
        }

        private void goOUTbutton_Click(object sender, EventArgs e)
        {
            if (ShoppingCart.Instance.SummaPokupok == 0)
            {
                MessageBox.Show("Вы успешно покинули магазин. Конец.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ohranik ending = new ohranik();
                ending.ShowDialog();
                MessageBox.Show("Вы убежали от правосудия");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}
