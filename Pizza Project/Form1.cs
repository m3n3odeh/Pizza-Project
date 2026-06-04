using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        float GetSelectedSizePrice()
        {
            if(rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            if(rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }
            if(rbLarge.Checked)
            {
                return Convert.ToSingle(rbLarge.Tag);
            }
            return 0;
        }

        float CalculateToppingsPrice()
        {
            float ToppingsPrice = 0;
            if (chkChees.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkChees.Tag);
            }
            if (chkOnion.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if (chkMushroom.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkMushroom.Tag);
            }
            if (chkOlivs.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkOlivs.Tag);
            }
            if (chkTomatos.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkTomatos.Tag);
            }
            if (chkGreen.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkGreen.Tag);
            }
            return ToppingsPrice;
        }
            
        float GetSelectedCrustPrice()
        {
            if(rbThin.Checked)
                return Convert.ToSingle(rbThin.Tag);
            else
                return Convert.ToSingle(rbThick.Tag);
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();
        }
      
        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }
        
        void UpdateSize()
        {
            UpdateTotalPrice();
            //UpdateTotalPrice_Function
            if (rbSmall.Checked)
            {
                laSize.Text = "Small";
                return;
            }
            if(rbMedium.Checked)
            {
                laSize.Text = "Medium";
                return;

            }
            if (rbLarge.Checked)
            {
                laSize.Text = "Large";
                return;

            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if(rbThick.Checked)
            {
                laCrustType.Text = "Thick Crust";
                return;
            }
            if(rbThin.Checked)
            {
                laCrustType.Text = "Thin Crust";
                return;
            }
        }
      
        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";
            if(chkChees.Checked)
            {
                sToppings += "Extra Chees";
            }
            if(chkOnion.Checked)
            {
                sToppings += ", Onion";
            }
            if(chkMushroom.Checked)
            {
                sToppings += ", Mushroom";
            }
            if(chkOlivs.Checked)
            {
                sToppings += ", Olives";
            }
            if(chkTomatos.Checked)
            {
                sToppings += ", Tomatos";
            }
            if(chkGreen.Checked)
            {
                sToppings += ", Green Paper";
            }
            if(sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length-1).Trim();
            }if(sToppings == "")
            {
                sToppings = "No Toppings!!";
            }
            laToppings.Text = sToppings;
        }

        void UpdateWheretoEate()
        {
            if (rbeatin.Checked)
                laWhereEat.Text = "Eat in";
            else
                laWhereEat.Text = "Tack Out";
        }

        void ResetForm()
        {
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            gbToppings.Enabled = true;
            gbeat.Enabled = true;
            //--------------
            chkChees.Checked = false;
            chkMushroom.Checked = false;
            chkOnion.Checked = false;
            chkTomatos.Checked = false;
            chkOlivs.Checked = false;
            chkGreen.Checked = false;
            //--------------
            btnorder.Enabled = true;
            rbMedium.Checked = true;
            rbeatin.Checked =  true;
            rbThin.Checked = true;
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWheretoEate();
            UpdateTotalPrice();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order!", "Confirm"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Order Placed Successfuly:::");
                btnorder.Enabled = false;
                gbSize.Enabled = false;
                gbCrust.Enabled = false;
                gbToppings.Enabled = false;
                gbeat.Enabled = false;
            }
            else
            {
                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            //Update_Size_Function
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        { //Update_Size_Function
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            //Update_Size_Function
            UpdateSize();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            //Update_Crust
            UpdateCrust();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            //Update_Crust
            UpdateCrust();

        }

        private void chkChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            if(laToppings.Text != "No Toppings!!")
            {
                laToppings.ForeColor = Color.DarkBlue;
                
            }
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlivs_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreen_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbeatin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWheretoEate();
        }

        private void rbtakeout_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWheretoEate();
        }

        private void btnresetForm_Click(object sender, EventArgs e)
        {
            //Reset Function
            ResetForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
            UpdateOrderSummary();
        }
    }
}
