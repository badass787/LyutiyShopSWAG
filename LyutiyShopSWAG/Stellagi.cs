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
    public partial class Shelves : Form, IShelvesView
    {
        public event EventHandler AddTomatoClicked;
        public event EventHandler RemoveTomatoClicked;

        public event EventHandler AddCucumberClicked;
        public event EventHandler RemoveCucumberClicked;

        public event EventHandler AddPotatoClicked;
        public event EventHandler RemovePotatoClicked;

        public event EventHandler AddCarrotClicked;
        public event EventHandler RemoveCarrotClicked;

        public event EventHandler AddOnionClicked;
        public event EventHandler RemoveOnionClicked;

        public event EventHandler AddCabbageClicked;
        public event EventHandler RemoveCabbageClicked;

        public event EventHandler AddTomatoesPackedClicked;
        public event EventHandler RemoveTomatoesPackedClicked;

        public event EventHandler AddPotatoesPackedClicked;
        public event EventHandler RemovePotatoesPackedClicked;

        public event EventHandler AddCarrotsPackedClicked;
        public event EventHandler RemoveCarrotsPackedClicked;

        public event EventHandler LeaveToKassaClicked;
        public event EventHandler WeighClicked;
        public event EventHandler countSummaClicked;

        public Shelves()
        {
            InitializeComponent();

            ShoppingCart.Instance.CartChanged += OnCartChanged;

            tomatoLabel.Text = ShoppingCart.Instance.GetCountByID(1).ToString();
            cucLable.Text = ShoppingCart.Instance.GetCountByID(2).ToString();
            potatoLabel.Text = ShoppingCart.Instance.GetCountByID(3).ToString();
            carrotLabel.Text = ShoppingCart.Instance.GetCountByID(4).ToString();
            onioLabel.Text = ShoppingCart.Instance.GetCountByID(5).ToString();
            cabbageLabel.Text = ShoppingCart.Instance.GetCountByID(6).ToString();

            tomatoesLabel.Text = ShoppingCart.Instance.GetCountByID(7).ToString();
            potatoesLabel.Text = ShoppingCart.Instance.GetCountByID(8).ToString();
            carrotsLabel.Text = ShoppingCart.Instance.GetCountByID(9).ToString();


            toolTip1.SetToolTip(tomato, Stellaj.allGoods.Find(g => g.ID == 1).Description);
            toolTip1.SetToolTip(cucumber, Stellaj.allGoods.Find(g => g.ID == 2).Description);
            toolTip1.SetToolTip(potato, Stellaj.allGoods.Find(g => g.ID == 3).Description);
            toolTip1.SetToolTip(carrot, Stellaj.allGoods.Find(g => g.ID == 4).Description);
            toolTip1.SetToolTip(onion, Stellaj.allGoods.Find(g => g.ID == 5).Description);
            toolTip1.SetToolTip(cabbage, Stellaj.allGoods.Find(g => g.ID == 6).Description);
            toolTip1.SetToolTip(tomatoes, Stellaj.allGoods.Find(g => g.ID == 7).Description);
            toolTip1.SetToolTip(potatoes, Stellaj.allGoods.Find(g => g.ID == 8).Description);
            toolTip1.SetToolTip(carrots, Stellaj.allGoods.Find(g => g.ID == 9).Description);

        }

        private void OnCartChanged()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateLabels));
            }
            else
            {
                UpdateLabels();
            }
        }

        private void UpdateLabels()
        {
            tomatoLabel.Text = ShoppingCart.Instance.GetCountByID(1).ToString();
            cucLable.Text = ShoppingCart.Instance.GetCountByID(2).ToString();
            potatoLabel.Text = ShoppingCart.Instance.GetCountByID(3).ToString();
            carrotLabel.Text = ShoppingCart.Instance.GetCountByID(4).ToString();
            onioLabel.Text = ShoppingCart.Instance.GetCountByID(5).ToString();
            cabbageLabel.Text = ShoppingCart.Instance.GetCountByID(6).ToString();

            tomatoesLabel.Text = ShoppingCart.Instance.GetCountByID(7).ToString();
            potatoesLabel.Text = ShoppingCart.Instance.GetCountByID(8).ToString();
            carrotsLabel.Text = ShoppingCart.Instance.GetCountByID(9).ToString();
        }

        private void plusTomato_Click(object sender, EventArgs e)
        { 
            AddTomatoClicked?.Invoke(this, EventArgs.Empty); tomatoLabel.Refresh(); }

        private void minusTomato_Click(object sender, EventArgs e)
        { RemoveTomatoClicked?.Invoke(this, EventArgs.Empty); tomatoLabel.Refresh(); }

        private void plusCucumber_Click(object sender, EventArgs e)
        { AddCucumberClicked?.Invoke(this, EventArgs.Empty); cucLable.Refresh(); }

        private void minusCucumber_Click(object sender, EventArgs e)
        { RemoveCucumberClicked?.Invoke(this, EventArgs.Empty); cucLable.Refresh(); }

        private void plusPotato_Click(object sender, EventArgs e)
        { AddPotatoClicked?.Invoke(this, EventArgs.Empty); potatoLabel.Refresh(); }

        private void minusPotato_Click(object sender, EventArgs e)
        { RemovePotatoClicked?.Invoke(this, EventArgs.Empty); potatoLabel.Refresh();}

        private void plusCarrot_Click(object sender, EventArgs e)
        { AddCarrotClicked?.Invoke(this, EventArgs.Empty); carrotLabel.Refresh(); }

        private void minusCarrot_Click(object sender, EventArgs e)
        { RemoveCarrotClicked?.Invoke(this, EventArgs.Empty); carrotLabel.Refresh();}

        private void plusOnion_Click(object sender, EventArgs e)
        { AddOnionClicked?.Invoke(this, EventArgs.Empty); onioLabel.Refresh(); }

        private void minusOnion_Click(object sender, EventArgs e)
        { RemoveOnionClicked?.Invoke(this, EventArgs.Empty); onioLabel.Refresh();}

        private void plusCabbage_Click(object sender, EventArgs e)
        { AddCabbageClicked?.Invoke(this, EventArgs.Empty); cabbageLabel.Refresh(); }

        private void minusCabbage_Click(object sender, EventArgs e)
        { RemoveCabbageClicked?.Invoke(this, EventArgs.Empty); cabbageLabel.Refresh();}

        private void plusTomatoes_Click(object sender, EventArgs e)
        { AddTomatoesPackedClicked?.Invoke(this, EventArgs.Empty); tomatoesLabel.Refresh(); }

        private void minusTomatoes_Click(object sender, EventArgs e)
        { RemoveTomatoesPackedClicked?.Invoke(this, EventArgs.Empty); tomatoesLabel.Refresh();}

        private void plusPotatoes_Click(object sender, EventArgs e)
        { AddPotatoesPackedClicked?.Invoke(this, EventArgs.Empty); potatoesLabel.Refresh(); }

        private void minusPotatoes_Click(object sender, EventArgs e)
        { RemovePotatoesPackedClicked?.Invoke(this, EventArgs.Empty); potatoesLabel.Refresh(); }

        private void plusCarrots_Click(object sender, EventArgs e)
        { AddCarrotsPackedClicked?.Invoke(this, EventArgs.Empty); carrotsLabel.Refresh(); }

        private void minusCarrots_Click(object sender, EventArgs e)
        { RemoveCarrotsPackedClicked?.Invoke(this, EventArgs.Empty); carrotsLabel.Refresh();}



        private void weighting_Click(object sender, EventArgs e)
            => WeighClicked?.Invoke(this, EventArgs.Empty);


        private void leaveToKassaButton_Click(object sender, EventArgs e)
        {
            MAIN form1 = new MAIN();
            this.Hide();
            form1.ShowDialog();

        }

        private void countSumma_Click(object sender, EventArgs e)
         => countSummaClicked?.Invoke(this, EventArgs.Empty);
    }
}
