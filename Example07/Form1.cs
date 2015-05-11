using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example07
{
    public partial class Form1 : Form
    {
        private Car tiida;

        public Form1()
        {
            InitializeComponent();
            tiida = new Car();
        }

        private void setSpeedbutton1_Click(object sender, EventArgs e)
        {
            int speed = int.Parse(speedTextBox.Text);
            tiida.Speed = speed;
            MessageBox.Show(tiida.Speed.ToString());
        }
    }
}