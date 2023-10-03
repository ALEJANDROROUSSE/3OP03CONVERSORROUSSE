using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3OP03CONVERSORROUSSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float cent = float.Parse(this.gradoscelsius.Text);
            float fahrenheit = (cent * 9 / 5) + 32;
            this.gradosfahrenheit.Text = fahrenheit.ToString();
        }
    }
}
