using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace PlanBottler
{
    /// <summary>
    /// Main Form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Main : Form
    {
        private readonly DrinkMachine drinkMachine;
        private CultureInfo cultureInfo = new CultureInfo("de-DE");

        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            this.InitializeComponent();
            this.drinkMachine = new DrinkMachine();
            this.drinkMachine.Fill();
            this.txtPrice.Enabled = false;
            this.txtTotal.Enabled = false;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BindingSource bs = new BindingSource
            {
                DataSource = this.drinkMachine.GetDrinkTypes(),
            };
            this.cbxDrinkType.DataSource = bs;
            this.cbxDrinkType.ValueMember = "Key";
            this.cbxDrinkType.DisplayMember = "Value";
        }

#pragma warning disable SA1300 // Element should begin with upper-case letter
        /// <summary>
        /// Handles the SelectedIndexChanged event of the cbxDrinkType control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cbxDrinkType_SelectedIndexChanged(object sender, EventArgs e)
#pragma warning restore SA1300 // Element should begin with upper-case letter
        {
            KeyValuePair<string, string> selectedItem = (KeyValuePair<string, string>)this.cbxDrinkType.SelectedItem;

            BindingSource bs = new BindingSource
            {
                DataSource = this.drinkMachine.GetDrinkSubTypes(selectedItem.Key),
            };

            this.cbxDrinkSubType.DataSource = bs;
            this.cbxDrinkSubType.ValueMember = "Key";
            this.cbxDrinkSubType.DisplayMember = "Value";

            if (this.cbxDrinkType.SelectedIndex == 0)
            {
                this.cbxDrinkSubType.Enabled = false;
            }
            else
            {
                this.cbxDrinkSubType.Enabled = true;
            }
        }

#pragma warning disable SA1300 // Element should begin with upper-case letter
        /// <summary>
        /// Handles the SelectedIndexChanged event of the cbxDrinkSubType control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cbxDrinkSubType_SelectedIndexChanged(object sender, EventArgs e)
#pragma warning restore SA1300 // Element should begin with upper-case letter
        {
            KeyValuePair<string, string> selectedItem = (KeyValuePair<string, string>)this.cbxDrinkSubType.SelectedItem;

            BindingSource bs = new BindingSource
            {
                DataSource = this.drinkMachine.GetDrinks(selectedItem.Key),
            };
            this.cbxDrink.DataSource = bs;
            this.cbxDrink.ValueMember = "Key";
            this.cbxDrink.DisplayMember = "Value";

            if (this.cbxDrinkSubType.SelectedIndex == 0)
            {
                this.cbxDrink.Enabled = false;
            }
            else
            {
                this.cbxDrink.Enabled = true;
            }
        }

#pragma warning disable SA1300 // Element should begin with upper-case letter
        /// <summary>
        /// Handles the SelectedIndexChanged event of the cbxDrink control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cbxDrink_SelectedIndexChanged(object sender, EventArgs e)
#pragma warning restore SA1300 // Element should begin with upper-case letter
        {
            KeyValuePair<string, string> selectedItem = (KeyValuePair<string, string>)this.cbxDrink.SelectedItem;

            var count = this.drinkMachine.GetDrinkCount(selectedItem.Key);

            BindingSource bs = new BindingSource
            {
                DataSource = count,
            };
            this.cbxCount.DataSource = bs;
            this.cbxCount.ValueMember = "Key";
            this.cbxCount.DisplayMember = "Value";

            if (this.cbxDrink.SelectedIndex == 0)
            {
                this.cbxCount.Enabled = false;
            }
            else
            {
                this.cbxCount.Enabled = true;
            }

            var drink = this.drinkMachine.GetDrink(selectedItem.Key);
            if (drink != null)
            {
                this.txtPrice.Text = drink.Price.ToString("C", this.cultureInfo);
            }
        }

        /// <summary>
        /// Fills the drink count automatically.
        /// </summary>
        private void FillDrinkCountAutomatically()
        {
            KeyValuePair<string, string> selectedSubTypeItem = (KeyValuePair<string, string>)this.cbxDrinkSubType.SelectedItem;
            KeyValuePair<string, string> selectedItem = (KeyValuePair<string, string>)this.cbxDrink.SelectedItem;

            BindingSource bs = new BindingSource
            {
                DataSource = this.drinkMachine.GetDrinkCount(selectedSubTypeItem.Key, selectedItem.Value),
            };
            this.cbxCount.DataSource = bs;
            this.cbxCount.ValueMember = "Key";
            this.cbxCount.DisplayMember = "Value";

            if (this.cbxDrink.SelectedIndex == 0)
            {
                this.cbxCount.Enabled = false;
            }
            else
            {
                this.cbxCount.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cbxCount control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
#pragma warning disable SA1300 // Element should begin with upper-case letter
        private void cbxCount_SelectedIndexChanged(object sender, EventArgs e)
#pragma warning restore SA1300 // Element should begin with upper-case letter
        {
            KeyValuePair<string, string> selectedItem = (KeyValuePair<string, string>)this.cbxCount.SelectedItem;
            KeyValuePair<string, string> selectedDrinkItem = (KeyValuePair<string, string>)this.cbxDrink.SelectedItem;

            if (this.cbxCount.SelectedIndex == 0)
            {
                this.cbxCount.Enabled = false;
            }
            else
            {
                this.cbxCount.Enabled = true;
            }

            var drink = this.drinkMachine.GetDrink(selectedDrinkItem.Key);
            if (drink != null)
            {
                var price = drink.Price;
                int count = int.Parse(selectedItem.Key);
                var total = count * price;
                this.txtTotal.Text = total.ToString("C", this.cultureInfo);
            }
        }
    }
}
