using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class Mortgage : Form
    {
        int year, month;
        double yearrate, monthrate, loan, remonth, allinterest, reall, a;
        public Mortgage()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                year = Convert.ToInt32(YeartextBox.Text);
                month = year * 12;
                loan = Convert.ToDouble(LoantextBox.Text);
                loan *= 10000;
                yearrate = Convert.ToDouble(RatetextBox.Text);
                yearrate /= 100;
                monthrate = yearrate / 12;
                if (!avecappi.Checked && !avecap.Checked)
                {
                    MessageBox.Show("请勾选还款方式!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (avecappi.Checked)
                {
                    a = Math.Pow((1 + monthrate), month);
                    remonth = (loan * monthrate * a) / (a - 1);
                    allinterest = remonth * month - loan;
                    reall = remonth * month;
                    MonthtextBox.Text = Convert.ToString(remonth);
                    InteresttextBox.Text = Convert.ToString(allinterest);
                    AlltextBox.Text = Convert.ToString(reall);
                }
                if (avecap.Checked)
                {
                    allinterest = (month + 1) * loan * monthrate / 2;
                    reall = allinterest + loan;
                    remonth = reall / month;
                    MonthtextBox.Text = Convert.ToString(remonth);
                    InteresttextBox.Text = Convert.ToString(allinterest);
                    AlltextBox.Text = Convert.ToString(reall);
                }
            }
            catch
            {
                if (YeartextBox.Text == "" || LoantextBox.Text == "" || RatetextBox.Text == "")
                {
                    MessageBox.Show("请填写基本信息!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_recalculate_Click(object sender, EventArgs e)
        {
            YeartextBox.Text = "";
            LoantextBox.Text = "";
            RatetextBox.Text = "";
            MonthtextBox.Text = "";
            InteresttextBox.Text = "";
            AlltextBox.Text = "";
        }
    }
}
