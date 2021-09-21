using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teamProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        { // After the calculate button has been clicked, this method will check what type of pizza the user choose and call the other methods to calculate the price and the calories
            if (rbMargherita.Checked == true)
            {
                int price = 12;
                int calories = 276;

                int totalPrice = toppingsPrice(price);
                int totalCalories = toppingsCalories(calories);

                priceTextBox.Text = Convert.ToString(totalPrice);
                caloriesTextBox.Text = Convert.ToString(totalCalories);
                BackgroundImage = Image.FromFile(@"C:/Users/Sonic/source/repos/teamProject1/margherita.jpg");
               
            }

            if (rbCheese.Checked == true)
            {
                int price = 10;
                int calories = 200;

                int totalPrice = toppingsPrice(price);
                int totalCalories = toppingsCalories(calories);

                priceTextBox.Text = Convert.ToString(totalPrice);
                caloriesTextBox.Text = Convert.ToString(totalCalories);
                BackgroundImage = Image.FromFile(@"C:/Users/Sonic/source/repos/teamProject1/cheese.jpg");

            }
            if (rbVeggie.Checked == true)
            {
                int price = 11;
                int calories = 240;

                int totalPrice = toppingsPrice(price);
                int totalCalories = toppingsCalories(calories);

                priceTextBox.Text = Convert.ToString(totalPrice);
                caloriesTextBox.Text = Convert.ToString(totalCalories);
                BackgroundImage = Image.FromFile(@"C:/Users/Sonic/source/repos/teamProject1/veggie.jpg");

            }
            if (rbMeetlover.Checked == true)
            {
                int price = 13;
                int calories = 300;

                int totalPrice = toppingsPrice(price);
                int totalCalories = toppingsCalories(calories);

                priceTextBox.Text = Convert.ToString(totalPrice);
                caloriesTextBox.Text = Convert.ToString(totalCalories);

                BackgroundImage = Image.FromFile(@"C:/Users/Sonic/source/repos/teamProject1/meetlover.jpg");
            }
        }

        private int checkedCheckBoxes() // When called, this method will count the topping boxes checked and return the value when called
        {
            int counter = 0;
            if (cheeseBox.Checked == true)
            {
                counter++;
            }
            if (veggieBox.Checked == true)
            {
                counter++;
            }
            if (pineappleBox.Checked == true)
            {
                counter++;
            }
            if (pepperBox.Checked == true)
            {
                counter++;
            }

            return counter;
        }
        private int toppingsPrice(int price) // When called, this method will receive a price and calcualte the total price depending on the amount of toppings added
        {
            int checkedBoxes = checkedCheckBoxes();
            int addDollars = 1 * checkedBoxes;
            price = price + addDollars;
            return price;
            
        }

        private int toppingsCalories(int calories) // When called, this method will receive an amount of calories and calcualte the total calories depending on the amount of toppings added
        {
            int checkedBoxes = checkedCheckBoxes();
            int addCalories = 20 * checkedBoxes;
            calories = calories + addCalories;
            return calories;

        }

        private void rbMeetlover_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCheese_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbVeggie_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
