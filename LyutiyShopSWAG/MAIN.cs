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
            this.Hide();
            formShelv.ShowDialog();
            this.Close();
        }

        private void goToPayButton_Click(object sender, EventArgs e)
        {
            oplataForm opl = new oplataForm();
            var presenter = new OplataPresenter(opl);
            this.Hide();
            opl.ShowDialog();
            this.Close();
            
        }

        private void goOUTbutton_Click(object sender, EventArgs e)
        {
            ShoppingCart.Instance.ForcedCartCost();
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
