using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form3 : Form
    {
        bool click = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 28;
            int y = 17;
            Func<int, int, int> func = (X, Y) => X * Y;
            label3.Text += func(x, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            click = true;
            Close();
            Application.OpenForms[0].Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            click = true;
            Close();
            Form form = new Form2();
            form.Show();
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !click)
            {
                Application.Exit();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            click = false;
        }
    }
}
