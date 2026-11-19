using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daro_1stLabExam
{
    public partial class Form1 : Form
    {

        private double total_Danielle = 0.0;
        private double total_Edward = 0.0;
        private double total_Fatima = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void getSalesPerson_Amount(string salesInitial, double salesAmount)
        {
            if (salesInitial == "D")
            {
                total_Danielle += salesAmount;
                label4.Text = $"Updated Total Sales:\nDanielle: ₱{total_Danielle}";
            }
            else if (salesInitial == "E")
            {
                total_Edward += salesAmount;
                label4.Text = $"Updated Total Sales:\nEdward: ₱{total_Edward}";
            }
            else if (salesInitial == "F")
            {
                total_Fatima += salesAmount;
                label4.Text = $"Updated Total Sales:\nFatima: ₱{total_Fatima}";
            }
            else
            {
                label4.Text = "Invalid Sales Person Initial.";
            }
        }
        private void clearEntry()
        {
            label4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double saleAmount))
            {
                getSalesPerson_Amount(textBox1.Text, saleAmount);
            }
            else
            {
                label4.Text = "Please enter a valid number for the sale amount.";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 summary = new Form2(total_Danielle, total_Edward, total_Fatima);
            summary.ShowDialog(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
