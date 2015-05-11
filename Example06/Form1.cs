using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example06
{
    public partial class Form1 : Form
    {
        private Employee zoe; //定義一個員工的參考

        //一個類別的建構式
        //建構式不用void
        //建構式跟類別同名
        public Form1()
        {
            InitializeComponent();
            zoe = new Employee();
        }

        private void setSalaryButton1_Click(object sender, EventArgs e)
        {
            int 薪水 = int.Parse(salaryTextBox.Text);
            /*
             if (薪水 <= 22000)
                 zoe.salary = 22000;
             else if (薪水 >= 60000)
                 zoe.salary = 60000;
             else
                 zoe.salary = 薪水;
             MessageBox.Show(zoe.salary.ToString());
             */

            //zoe.設定薪水(薪水);
            //MessageBox.Show(zoe.取得薪水().ToString());

            //屬性
            zoe.salary = 薪水; //呼叫set
            MessageBox.Show(zoe.salary.ToString());
        }

        private void setSalaryButton2_Click(object sender, EventArgs e)
        {
            int 薪水 = int.Parse(salaryTextBox.Text);

            //zoe.salary = 薪水;
            //MessageBox.Show(zoe.salary.ToString());

            //zoe.設定薪水(薪水);
            //MessageBox.Show(zoe.取得薪水().ToString());

            //屬性
            zoe.salary = 薪水;
            MessageBox.Show(zoe.salary.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void setSalarySbutton3_Click(object sender, EventArgs e)
        {
            int baseSalary = int.Parse(baseSalaryTextBox.Text);
            int benefit = int.Parse(benefitTextBox.Text);
            zoe.BaseSalary = baseSalary;
            zoe.Benefit = benefit;
            MessageBox.Show(zoe.Totalsalary.ToString());
        }
    }
}