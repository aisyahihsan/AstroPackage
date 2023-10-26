using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace astropackage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declaration
            double totalprice, tax, totaltax, totalafter;
            int count=0;
            double discount = 0;
            //calculate mini package
            totalprice = 37.95;

            //calculate prime package
            if(chkSport.Checked == true)
            {
                totalprice = totalprice + 35;
            }

            if (chkDynasty.Checked== true)
            {
                totalprice = totalprice + 32;
            }

            if (chkMovies.Checked== true)
            {
                totalprice = totalprice + 38;
            }

            //count metro package
            if (chkLearning.Checked== true)
            {
                count = count + 1;
            }

            if (chkFun.Checked== true)
            {
                count = count + 1;
            }

            if (chkVariety.Checked == true)
            {
                count = count + 1;
            }

            if (chkNews.Checked == true)
            {
                count = count + 1;
            }

            //calculate metro package
            if( count== 1)
            {
                totalprice = totalprice + 9;
            }

            else if (count== 2)
            {
                totalprice = totalprice + 16;
            }

            else if(count== 3)
            {
                totalprice = totalprice + 21;
            }

            else if (count==4)
            {
                totalprice = totalprice + 26;
            }

            //calculate plus package
            if (chkMustika.Checked == true)
            {
                totalprice = totalprice + 13;
            }

            if (chkMaharaja.Checked == true)
            {
                totalprice = totalprice + 13;
            }

            if (chkEmperor.Checked == true)
            {
                totalprice = totalprice + 22;
            }

            if (chkMetro.Checked == true)
            {
                totalprice = totalprice + 8;
            }

            //calculate extra package
            if (chkPVR.Checked == true)
            {
                totalprice = totalprice + 30;
            }
            //show total price
            txtTotal.Text = totalprice.ToString();

            //calculate & show tax
            tax = totalprice * 0.06;
            txtTax.Text = tax.ToString();

            //calculate & show total with tax
            totaltax = totalprice + tax;
            txtTotalTax.Text = totaltax.ToString();

            //calculate discount price
            if (totaltax >= 120 && totaltax <= 149.99)
            {
                discount = totaltax * 0.07;
            }

            else if (totaltax >= 150 && totaltax <= 159.99)
            {
                discount = totaltax * 0.1;
            }

            else if (totaltax >= 160)
            {
                discount = totaltax * 0.15;
            }

            else
            { }

            //show discount price
            txtDiscount.Text = discount.ToString();

            //calculate total after
            totalafter = totaltax - discount;
            //show total after
            txtTotalAfter.Text = totalafter.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDiscount.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            txtTotalAfter.Clear();
            txtTotalTax.Clear();
            chkDynasty.Checked = false;
            chkEmperor.Checked = false;
            chkFun.Checked = false;
            chkLearning.Checked = false;
            chkMaharaja.Checked = false;
            chkMetro.Checked = false;
            chkMovies.Checked = false;
            chkMustika.Checked = false;
            chkNews.Checked = false;
            chkPVR.Checked = false;
            chkSport.Checked = false;
            chkVariety.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
