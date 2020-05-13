using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoshNosh
{
    /// <summary>
    /// Task 3.3 - 3.4
    /// This project displays a menu of Starters, Main Course and Dessert
    /// And works out a users total cost of the entire meal
    /// Author: Shan Ahmed 21813031
    /// </summary>
    /// 

    public partial class Form1 : Form
    {
        double totalcost = 0;
        double startercost = 0;
        double maincoursecost = 0;
        double dessertcost = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void lstStarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstStarter.Text)
            {
                case "Soup of the Day"      : startercost = 5.00; break;
                case "Chilli Fish Cakes"    : startercost = 5.50; break;
                case "Caesar Salad"         : startercost = 4.50; break;
                case "King Prawn CousCous"  : startercost = 6.00; break;
                case "Black Pudding Pate"   : startercost = 4.00; break;
                case "Chicken Liver Toast"  : startercost = 3.50; break;
                case "Prawn Cocktail"       : startercost = 5.50; break;
            }
            totalcost = startercost + maincoursecost + dessertcost;
            lblTotal.Text = "£" + totalcost.ToString("0.00");
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.Text)
            {
                case "Chicken Curry":maincoursecost = 12.50; break;
                case "Beef Lasagna":maincoursecost = 7.50; break;
                case "Shawarma":maincoursecost = 6.00; break;
                case "Steak and Fries": maincoursecost = 9.00; break;
            }

            totalcost = startercost + maincoursecost + dessertcost;
            lblTotal.Text = "£" + totalcost.ToString("0.00");
        }

        private void Dessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Dessert.Text)
            {
                case "Kheer": dessertcost = 4.00; break;
                case "Rasmalai": dessertcost = 3.50; break;
                case "Gajjar Halwa": dessertcost = 5.00; break;
                case "Knafeh": dessertcost = 3.00; break;
            }

            totalcost = startercost + maincoursecost + dessertcost;
            lblTotal.Text = "£" + totalcost.ToString("0.00");
        }
    }
}