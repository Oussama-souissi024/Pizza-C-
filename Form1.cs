using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Pizza_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float GetSelectedSizePrice()
        {
            if (radioSmall.Checked)
                return Convert.ToSingle(radioSmall.Tag);
            else if (radioMedium.Checked)
                return Convert.ToSingle(radioMedium.Tag);
            else
                return Convert.ToSingle(radioLarge.Tag);
        }

        float GetSelectedCrustPrice()
        {
            if (radioCrustThin.Checked)
                return Convert.ToSingle(radioCrustThin.Tag);

            else
                return Convert.ToSingle(radioCrustThink.Tag);
        }

        float GetSelectedToppingsPrice()
        {
            float ToppingFinalyPrice = 0;
            if (checkBoxExtraChees.Checked)
                ToppingFinalyPrice += Convert.ToSingle(checkBoxExtraChees.Tag);

            if (checkBoxGreenPeppers.Checked)
                ToppingFinalyPrice += Convert.ToSingle(checkBoxGreenPeppers.Tag);

            if (checkBoxMushrooms.Checked)
                ToppingFinalyPrice += Convert.ToSingle(checkBoxMushrooms.Tag);

            if (checkBoxOlives.Checked)
                ToppingFinalyPrice += Convert.ToSingle(checkBoxOlives.Tag);

            if (checkBoxOnion.Checked)
                ToppingFinalyPrice += Convert.ToSingle(checkBoxOnion.Tag);

            if (checkBoxTomatoes.Checked)
                ToppingFinalyPrice += Convert.ToSingle(checkBoxTomatoes.Tag);

            return ToppingFinalyPrice;

        }

        float CalculateTotalPrice()
        {
            return GetSelectedCrustPrice() + GetSelectedSizePrice() + GetSelectedToppingsPrice();
        }

        void ResetForm()
        {
            //Reset GroupBox
            groupBoxSize.Enabled = true;
            groupBoxCrust.Enabled = true;
            groupBoxToppings.Enabled = true;
            groupBoxWhereToEat.Enabled = true;

            //Reset Size
            radioMedium.Checked = true;

            //Reset Topping
            checkBoxExtraChees.Checked = false;
            checkBoxGreenPeppers.Checked = false;
            checkBoxMushrooms.Checked = false;
            checkBoxOlives.Checked = false;
            checkBoxOnion.Checked = false;
            checkBoxTomatoes.Checked = false;

            //Reset Crust Type
            radioCrustThin.Checked = true;

            //Reset Where To Eat
            radioButtonEatIn.Checked = true;

            //Reset Order Button
            buttonOrderPizza.Enabled = true;

        }

        void UpdateTotalPrice(decimal NumberOfPizzas = 1)
        {
            labelTotalePrice.Text = ((decimal)CalculateTotalPrice()*NumberOfPizzas).ToString() + "$";
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateTopping();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (radioCrustThin.Checked)
            {
                labelCrustType.Text = "Thin Crust";
                return;
            }
            if (radioCrustThink.Checked)
            {
                labelCrustType.Text = "Think Crust";
                return;
            }

        }

        void UpdateTopping()
        {
            UpdateTotalPrice();
            string TotalToppings = "";

            if (checkBoxExtraChees.Checked)
                TotalToppings += "Extra Chees";

            if (checkBoxMushrooms.Checked)
                TotalToppings += ", Mushrooms";

            if (checkBoxTomatoes.Checked)
                TotalToppings += ", Tomatoes";

            if (checkBoxOnion.Checked)
                TotalToppings += ", Onion";

            if (checkBoxOlives.Checked)
                TotalToppings += ",Olives";

            if (checkBoxGreenPeppers.Checked)
                TotalToppings += ", GreenPeppers";

            if (TotalToppings.StartsWith(","))
                TotalToppings = TotalToppings.Substring(1, TotalToppings.Length - 1).Trim();

            if (TotalToppings == "")
                TotalToppings = "No Toppings";

            labelToppings.Text = TotalToppings;
        }

        void UpdateSize()
        {
            UpdateTotalPrice();
            if (radioSmall.Checked)
            {
                labelSize.Text = "Small";
                return;
            }

            if (radioMedium.Checked)
            {
                labelSize.Text = "Medium";
                return;
            }

            if (radioLarge.Checked)
            {
                labelSize.Text = "Large";
                return;
            }
        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (radioCrustThin.Checked)
            {
                labelWhereToEat.Text = "Eat In.";
                return;
            }

            if (radioCrustThink.Checked)
            {
                labelWhereToEat.Text = "Take Out.";
                return;
            }

            void buttonOrderPizza_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Confir your order", "Confirm", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    buttonOrderPizza.Enabled = false;
                    groupBoxSize.Enabled = false;
                    groupBoxCrust.Enabled = false;
                    groupBoxToppings.Enabled = false;
                    groupBoxWhereToEat.Enabled = false;
                }
                //else
            }
        }

        private void buttonResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void buttonOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonOrderPizza.Enabled = false;
                groupBoxSize.Enabled = false;
                groupBoxToppings.Enabled = false;
                groupBoxCrust.Enabled = false;
                groupBoxWhereToEat.Enabled = false;

            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void radioSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radioMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radioLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radioCrustThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void radioCrustThink_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void checkBoxExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void checkBoxMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void checkBoxTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void checkBoxOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void checkBoxOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void checkBoxGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void radioButtonEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void radioButtonTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal Number = numericUpDown1.Value;
            UpdateTotalPrice(Number);
        }
    }
}
