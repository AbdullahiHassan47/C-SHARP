using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaki_zaaha12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cal_Price_Click(object sender, EventArgs e)
        {
            String food1, food2;
            double price1, price2, tips, salesTax, totalAmount, netAmount, Amount;

            const double SALES_TAX_RATE = 5;
            double TipsRate = double.Parse(Txt_TipsRate.Text);

            try
            {
                price1 = double.Parse(Txt_PriceFood1.Text);
                price2 = double.Parse(Txt_Price_Food2.Text);


                Amount = price1 + price2;


                salesTax = Amount * (SALES_TAX_RATE / 100);
                tips  = Amount * (TipsRate / 100);

                totalAmount = Amount + salesTax + tips;
                netAmount = totalAmount - salesTax - tips;

                LbL_SalesTax.Text = salesTax.ToString("c");
                Lbl_TipsAmount.Text = tips.ToString("c");
                Lbl_TotalAmount.Text = totalAmount.ToString("c");
                Lbl_NetAmount.Text = netAmount.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void Lbl_TotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_TipsAmount_Click(object sender, EventArgs e)
        {

        }

        private void LbL_SalesTax_Click(object sender, EventArgs e)
        {

        }

        private void Txt_PriceFood2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Food2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Price_Food2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Txt_Food1.Text = "";
            Txt_Food2.Text = "";
            Txt_PriceFood1.Text = "";
            Txt_Price_Food2.Text = "";
            Txt_TipsRate.Text = "";
            LbL_SalesTax.Text = "";
            Lbl_TipsAmount.Text = "";
            Lbl_TotalAmount.Text = "";
            Lbl_NetAmount.Text = "";
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void Txt_Food1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_NetAmount_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
