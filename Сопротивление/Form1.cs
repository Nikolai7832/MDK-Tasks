using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{

    public partial class Form1 : Form
    {
        int t = 6 * 60;
        int q = 210;
        int r = 14;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Func<int, int, int, int> func = (T, Q, R) => Q * R/ T;
            label3.Text += func(t, q, r) + " В";
        }

    }
}
