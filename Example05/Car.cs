using Example05.Folder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    internal class Car //class 命名以名詞
    {
        public string _id = "1234-ABCD";
        private string _name; //欄位:底線開頭或小寫

        public void SaySomething()
        {
            Console.WriteLine(this._id);
        }
    }
}