using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        double BurgerPrice = 3.50;
        double FryPrice = 1.00;
        double DrinkPrice = 2.50;
        int numOfBurgers = 0;
        int numOfFries = 0;
        int numOfDrinks = 0;
        double subtotal = 0;
        double tax = 0;
        double total = 0;
        double taxRate = 0.13;
        double tendered;
        double change;


        public Form1()
        {

            InitializeComponent();
        }





        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.ding);

            player.Play();
               
                try
                {
                    numOfBurgers = Convert.ToInt32(textBoxBurgersInput.Text);
                    numOfFries = Convert.ToInt32(textBoxFriesInput.Text);
                    numOfDrinks = Convert.ToInt32(textBoxDrinksInput.Text);

                    subtotal = (numOfBurgers * BurgerPrice) + (numOfFries * FryPrice) + (numOfDrinks * DrinkPrice);
                    tax = subtotal * taxRate;
                    total = subtotal + tax;

                    labelSubtotalOutput.Text = $"{subtotal.ToString(".00")}";
                    labelTaxOutput.Text = $"{tax.ToString("C")}";
                    labelTotalOutput.Text = $"{total.ToString("C")}";

                    buttonCalculateChange.Enabled = true;
                }
                catch
                {
                    labelSubtotalOutput.Text = $"ERROR";
                    labelTaxOutput.Text = $"ERROR";
                    labelTotalOutput.Text = $"ERROR";
                }
            
            if (numOfBurgers == 0 && numOfDrinks == 0 && numOfFries == 0)
            {
                buttonCalculateChange.Enabled = false;
                buttonPrint.Enabled = false;
                labelSubtotalOutput.Text = $"";
                labelTaxOutput.Text = $"";
                labelTotalOutput.Text = $"";
            }
        }

        private void buttonCalculateChange_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.ding);

            player.Play();

            try
            {
                tendered = Convert.ToDouble(textBoxTenderedInput.Text);

                change = tendered - total;

                labelChangeOutput.Text = $"{change.ToString("C")}";

                if(tendered > total||tendered == total)
                {
                    buttonPrint.Enabled = true;
                }

                if (tendered < total)
                {
                    labelChangeOutput.Text = $"INSUFICENT FUNDS";
                    buttonPrint.Enabled = false;
                }
            }
            catch
            {
                labelChangeOutput.Text = $"INCORRECT CURRENCEY";
            }

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.ding);
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.printerSound2);
            SoundPlayer player3 = new SoundPlayer(Properties.Resources.explosion1);

            player.Play();

            Refresh();
            Thread.Sleep(750);
          
            player2.Play();

            labelReceiptOutput.AutoSize = true;

            labelReceiptOutput.Text = $"Big Boy Burger Inc.";
            Refresh();
            Thread.Sleep(1000);
            labelReceiptOutput.Text += $"\n\nOrder Number 385";
            Refresh();
            Thread.Sleep(1000);
            labelReceiptOutput.Text += $"\nDate November 13 4329";
            Refresh();
            Thread.Sleep(1000);

            if (numOfBurgers > 0)
            {
               labelReceiptOutput.Text += $"\n\nHamburgers x{numOfBurgers} @{numOfBurgers * BurgerPrice}";
            }

            if(numOfBurgers == 0)
            {
               labelReceiptOutput.Text += $"";
            }

            Refresh();
            Thread.Sleep(1000);

            if (numOfFries > 0)
            {
               labelReceiptOutput.Text += $"\nFries x{numOfFries} @{numOfFries * FryPrice}";
            }

            if (numOfFries == 0)
            {
               labelReceiptOutput.Text += $"";
            }
                  
            Refresh();
            Thread.Sleep(1000);
             
            if (numOfDrinks > 0)
            {
               labelReceiptOutput.Text += $"\nDrinks x{numOfDrinks} @{numOfDrinks * DrinkPrice}";
            }

            if (numOfDrinks == 0)
            {
               labelReceiptOutput.Text += $"";
            }

            Refresh();
            Thread.Sleep(1000);
            labelReceiptOutput.Text += $"\n\nSubtotal {subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            labelReceiptOutput.Text += $"\nTax {tax.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            labelReceiptOutput.Text += $"\nTotal {total.ToString("C")}";          
            Refresh();
            Thread.Sleep(1000);
            labelReceiptOutput.Text += $"\n\nTendered {tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            labelReceiptOutput.Text += $"\nChange {change.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);

            player2.Stop();

            if (numOfBurgers == 99999 &&numOfDrinks == 99999 && numOfFries == 99999)
            {                
                player3.Play();
                labelReceiptOutput.Text = $"Hello Will";
                labelReceiptOutput.Text += $"\nYour immense size";
                labelReceiptOutput.Text += $"\nHas reached a scale";
                labelReceiptOutput.Text += $"\nWhere it is starting";
                labelReceiptOutput.Text += $"\nTo lag out the simulation of life";
                labelReceiptOutput.Text += $"\nPlease stop consuming so much food";
            }
            
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            numOfBurgers = 0;
            numOfFries = 0;
            numOfDrinks = 0;
            subtotal = 0;
            tax = 0;
            total = 0;
            tendered = 0;
            change = 0;
            labelReceiptOutput.Text = $"";
            labelReceiptOutput.BackColor = Color.White;
            labelReceiptOutput.AutoSize = false;
            textBoxBurgersInput.Text = $"";
            textBoxFriesInput.Text = $"";
            textBoxDrinksInput.Text = $"";            
            labelSubtotalOutput.Text = $"";
            labelTaxOutput.Text = $"";
            labelTotalOutput.Text =$"";
            textBoxTenderedInput.Text = $"";
            labelChangeOutput.Text = $"";
        }
    }
}
