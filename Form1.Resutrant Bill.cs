using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBillCalculator
{
    public partial class Form1 : Form
    { 
        public struct Orders
        {
            public string item;
            public double price;
        }
        const double TAX = 0.10;
        Orders order = new Orders();
        static double subtotal = 0;
        static double totalTaxes = 0;
        static double total = 0;
        string finalBill = "CUSTOMER FINAL BILL: \n";



        public Form1()

        
        {
            InitializeComponent();
        }
        private void getValues(string custOrder)
        {
            order.item = custOrder.Split('$')[0];
            order.price = Convert.ToDouble(custOrder.Split('$')[1]);
            finalBill += "Ordered Item: " + order.item + "\nPrice: " + order.price.ToString("C2") + "\n";
            updateBill();
        }

        private void updateBill()
        {
            subtotal += order.price;
            total += order.price + (order.price * TAX);
            totalTaxes += order.price * TAX;

            RestaurantBill.Items.Clear();
            RestaurantBill.Items.AddRange(finalBill.Split('\n'));
            RestaurantBill.Items.Add("Subtotal: " + subtotal.ToString("C2"));
            RestaurantBill.Items.Add("Tax: " + totalTaxes.ToString("C2"));
            RestaurantBill.Items.Add("Total: " + total.ToString("C2"));
        }

        private void dropdownSelection(object sender, EventArgs e)
        {
            if (sender == cmbMainCourse)
                getValues(cmbMainCourse.SelectedItem.ToString());
            else if (sender == cmbAppetizers)
                getValues(cmbAppetizers.SelectedItem.ToString());
            else if (sender == cmbDesserts)
                getValues(cmbDesserts.SelectedItem.ToString());
            else if (sender == cmbBeverages)
                getValues(cmbBeverages.SelectedItem.ToString());
        }

        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
        
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RestaurantBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            subtotal = 0;
            totalTaxes = 0;
            total = 0;
            finalBill = "CUSTOMER FINAL BILL: \n";
            RestaurantBill.Items.Clear();
        }
    }
}
