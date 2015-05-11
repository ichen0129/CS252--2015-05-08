using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    internal class Employee
    {
        /*
        private int salary;

        public void 設定薪水(int 薪水) //方法
        {
            if (薪水 <= 22000)
                this.salary = 22000;
            else if (薪水 >= 60000)
                this.salary = 60000;
            else
                this.salary = 薪水;
        }

        public int 取得薪水() //方法
        {
            return this.salary;
        }*/

        private int _salary; //變數
        private string _姓名;
        private int _benefit;
        private int _totalsalary;

        public int Totalsalary
        {
            get
            {
                _totalsalary = this._baseSalary + this._benefit;
                return _totalsalary;
            }
        }

        public int Benefit
        {
            get { return _benefit; }
            set
            {
                if (value <= 5000)
                    this._benefit = 5000;
                else if (value >= this._baseSalary)
                    this._benefit = 5000;
                else
                    this._benefit = value;
            }
        }

        private int _baseSalary;

        public int BaseSalary
        {
            get { return _baseSalary; }
            set
            {
                if (value <= 22000)
                    this._baseSalary = 22000;
                else if (value >= 60000)
                    this._baseSalary = 60000;
                else
                    this._baseSalary = value;
            }
        }

        public string 姓名
        {
            get { return _姓名; }
            set { _姓名 = value; }
        }

        public int salary //屬性:把方法封裝
        {
            set
            {
                if (value <= 22000)
                    this._salary = 22000;
                else if (value >= 60000)
                    this._salary = 60000;
                else
                    this._salary = value;
            }

            get
            {
                return this._salary;
            }
        }
    }
}