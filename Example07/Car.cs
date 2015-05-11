using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example07
{
    internal class Car
    {
        private int _speed;

        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value < 0)
                    this._speed = 0;
                else if (value > 100)
                    this._speed = 100;
                else
                    _speed = value;
            }
        }
    }
}