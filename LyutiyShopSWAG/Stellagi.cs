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

        public Shelves()
        {
            InitializeComponent();

            toolTip1.SetToolTip(tomato, "Это подсказка при наведении на картинку");
            toolTip1.SetToolTip(cucumber, "Это подсказка при наведении на картинку");
            toolTip1.SetToolTip(potato, "Это подсказка при наведении на картинку");
            toolTip1.SetToolTip(carrot, "Это подсказка при наведении на картинку");
            toolTip1.SetToolTip(onion, "Это подсказка при наведении на картинку");
            toolTip1.SetToolTip(cabbage, "Это подсказка при наведении на картинку");
            toolTip1.SetToolTip(tomatoes, "Это подсказка при наведении на картинку");
            toolTip1.SetToolTip(potatoes, "Это подсказка при наведении на картинку");
            toolTip1.SetToolTip(carrots, "Это подсказка при наведении на картинку");

        }
        private void plusTomato_Click(object sender, EventArgs e)
            => AddTomatoClicked?.Invoke(this, EventArgs.Empty);

        private void minusTomato_Click(object sender, EventArgs e)
            => RemoveTomatoClicked?.Invoke(this, EventArgs.Empty);

        private void plusCucumber_Click(object sender, EventArgs e)
            => AddCucumberClicked?.Invoke(this, EventArgs.Empty);

        private void minusCucumber_Click(object sender, EventArgs e)
            => RemoveCucumberClicked?.Invoke(this, EventArgs.Empty);

        private void plusPotato_Click(object sender, EventArgs e)
            => AddPotatoClicked?.Invoke(this, EventArgs.Empty);

        private void minusPotato_Click(object sender, EventArgs e)
            => RemovePotatoClicked?.Invoke(this, EventArgs.Empty);

        private void plusCarrot_Click(object sender, EventArgs e)
            => AddCarrotClicked?.Invoke(this, EventArgs.Empty);

        private void minusCarrot_Click(object sender, EventArgs e)
            => RemoveCarrotClicked?.Invoke(this, EventArgs.Empty);

        private void plusOnion_Click(object sender, EventArgs e)
            => AddOnionClicked?.Invoke(this, EventArgs.Empty);

        private void minusOnion_Click(object sender, EventArgs e)
            => RemoveOnionClicked?.Invoke(this, EventArgs.Empty);

        private void plusCabbage_Click(object sender, EventArgs e)
            => AddCabbageClicked?.Invoke(this, EventArgs.Empty);

        private void minusCabbage_Click(object sender, EventArgs e)
            => RemoveCabbageClicked?.Invoke(this, EventArgs.Empty);

        private void plusTomatoes_Click(object sender, EventArgs e)
            => AddTomatoesPackedClicked?.Invoke(this, EventArgs.Empty);

        private void minusTomatoes_Click(object sender, EventArgs e)
            => RemoveTomatoesPackedClicked?.Invoke(this, EventArgs.Empty);

        private void plusPotatoes_Click(object sender, EventArgs e)
            => AddPotatoesPackedClicked?.Invoke(this, EventArgs.Empty);

        private void minusPotatoes_Click(object sender, EventArgs e)
            => RemovePotatoesPackedClicked?.Invoke(this, EventArgs.Empty);

        private void plusCarrots_Click(object sender, EventArgs e)
            => AddCarrotsPackedClicked?.Invoke(this, EventArgs.Empty);

        private void minusCarrots_Click(object sender, EventArgs e)
            => RemoveCarrotsPackedClicked?.Invoke(this, EventArgs.Empty);

        private void leaveToKassaButton_Click(object sender, EventArgs e)
            => LeaveToKassaClicked?.Invoke(this, EventArgs.Empty);

        private void weighting_Click(object sender, EventArgs e)
            => WeighClicked?.Invoke(this, EventArgs.Empty);


        //private void leaveToKassaButton_Click(object sender, EventArgs e)
        //{
        //
        //}
    }   //
}
