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

// Sean Woods
// March/6th/2024
// Cash register for a fast food store
namespace Cash_Register
{
    public partial class cashRegister : Form
    {
        double burgerPrice = 3.50; //settings variables
        double fryPrice = 1.00;
        double drinkPrice = 2.50;
        int numOfBurgers = 0;
        int numOfFries = 0;
        int numOfDrinks = 0;
        double subtotal = 0;
        double tax = 0;
        double total = 0;
        double taxRate = 0.13;
        double tendered;
        double change;


        public cashRegister()
        {

            InitializeComponent();
        }





        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.ding); //PLay sound for when any button is pressed

            player.Play();
               
                try
                {
                    numOfBurgers = Convert.ToInt32(burgersInputTextBox.Text); //Calculating the total of the order and printing it to screen
                    numOfFries = Convert.ToInt32(friesInputTextBox.Text);
                    numOfDrinks = Convert.ToInt32(drinksInputTextBox.Text);

                    subtotal = (numOfBurgers * burgerPrice) + (numOfFries * fryPrice) + (numOfDrinks * drinkPrice);
                    tax = subtotal * taxRate;
                    total = subtotal + tax;

                    subtotalOutputLabel.Text = $"{subtotal.ToString(".00")}";
                    taxOutputLabel.Text = $"{tax.ToString("C")}";
                    totalOutputLabel.Text = $"{total.ToString("C")}";

                    calculateChangeButton.Enabled = true;
                }
                catch
                {
                    subtotalOutputLabel.Text = $"ERROR"; // erroring out the program
                    taxOutputLabel.Text = $"ERROR";
                    totalOutputLabel.Text = $"ERROR";
                }
            
            if (numOfBurgers == 0 && numOfDrinks == 0 && numOfFries == 0)
            {
                calculateChangeButton.Enabled = false; //if nothing id ordered locking all buttons
                printButton.Enabled = false;
                subtotalOutputLabel.Text = $"";
                taxOutputLabel.Text = $"";
                totalOutputLabel.Text = $"";
            }
        }

        private void buttonCalculateChange_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.ding); //adding sounds

            player.Play();

            try
            {
                tendered = Convert.ToDouble(textBoxTenderedInput.Text); //Calculating amount of change and erroring if tendered is below the total price

                change = tendered - total;

                changeOutputLabel.Text = $"{change.ToString("C")}";

                if(tendered > total||tendered == total)
                {
                    printButton.Enabled = true;
                }

                if (tendered < total)
                {
                    changeOutputLabel.Text = $"INSUFICENT FUNDS";
                    printButton.Enabled = false;
                }
            }
            catch
            {
                changeOutputLabel.Text = $"INCORRECT CURRENCEY"; //erroring if numbers are not entered
            }

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.ding); //adding sounds
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.printerSound2);
            SoundPlayer player3 = new SoundPlayer(Properties.Resources.explosion1);

            player.Play();

            Refresh();
            Thread.Sleep(750);
          
            player2.Play();

            receiptOutputLabel.AutoSize = true; //printing receipt

            receiptOutputLabel.Text = $"Big Boy Burger Inc.";
            Refresh();
            Thread.Sleep(1000);
            receiptOutputLabel.Text += $"\n\nOrder Number 385";
            Refresh();
            Thread.Sleep(1000);
            receiptOutputLabel.Text += $"\nDate November 13 4329";
            Refresh();
            Thread.Sleep(1000);

            if (numOfBurgers > 0) //printing if there is a order of burgers
            {
               receiptOutputLabel.Text += $"\n\nHamburgers x{numOfBurgers} @{numOfBurgers * burgerPrice}";
            }

            if(numOfBurgers == 0) //not printing if there is no order of burgers
            {
               receiptOutputLabel.Text += $"";
            }

            Refresh();
            Thread.Sleep(1000);

            if (numOfFries > 0) //printing if there is a order of fries
            {
               receiptOutputLabel.Text += $"\nFries x{numOfFries} @{numOfFries * fryPrice}";
            }

            if (numOfFries == 0) //not printing if there is no order of fries
            {
               receiptOutputLabel.Text += $"";
            }
                  
            Refresh();
            Thread.Sleep(1000);
             
            if (numOfDrinks > 0) //printing if there is a order of fries
            {
               receiptOutputLabel.Text += $"\nDrinks x{numOfDrinks} @{numOfDrinks * drinkPrice}";
            }

            if (numOfDrinks == 0) //not printing if there is no order of drinks
            {
               receiptOutputLabel.Text += $"";
            }

            Refresh(); //printing the totals
            Thread.Sleep(1000);
            receiptOutputLabel.Text += $"\n\nSubtotal {subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptOutputLabel.Text += $"\nTax {tax.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptOutputLabel.Text += $"\nTotal {total.ToString("C")}";          
            Refresh();
            Thread.Sleep(1000);
            receiptOutputLabel.Text += $"\n\nTendered {tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            receiptOutputLabel.Text += $"\nChange {change.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);

            player2.Stop();

            if (numOfBurgers == 99999 &&numOfDrinks == 99999 && numOfFries == 99999) //easter egg
            {                
                player3.Play();
                receiptOutputLabel.Text = $"Hello Will";
                receiptOutputLabel.Text += $"\nYour immense size";
                receiptOutputLabel.Text += $"\nHas reached a scale";
                receiptOutputLabel.Text += $"\nWhere it is starting";
                receiptOutputLabel.Text += $"\nTo lag out the simulation of life";
                receiptOutputLabel.Text += $"\nPlease stop consuming so much food";
            }
            
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            numOfBurgers = 0; //restting all variables
            numOfFries = 0;
            numOfDrinks = 0;
            subtotal = 0;
            tax = 0;
            total = 0;
            tendered = 0;
            change = 0;
            receiptOutputLabel.Text = $"";
            receiptOutputLabel.BackColor = Color.White;
            receiptOutputLabel.AutoSize = false;
            burgersInputTextBox.Text = $"";
            friesInputTextBox.Text = $"";
            drinksInputTextBox.Text = $"";            
            subtotalOutputLabel.Text = $"";
            taxOutputLabel.Text = $"";
            totalOutputLabel.Text =$"";
            textBoxTenderedInput.Text = $"";
            changeOutputLabel.Text = $"";
        }


    }
}
