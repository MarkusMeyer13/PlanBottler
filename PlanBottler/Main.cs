using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            this.InitializeComponent();
            this.drinkMachine = new DrinkMachine();
            this.drinkMachine.Fill();
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
    }
}
