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
    public partial class Form2 : Form
    {
        bool click = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 35;
            int y = 7;
            Func<int, int, int> func = (X, Y) => X * Y;
            label3.Text += func(x , y) + " Км";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            click = true;
            Close();
            Form form = new Form3();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            click = true;
            Close();
            Application.OpenForms[0].Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !click)
            {
                Application.Exit();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            click = false;
        }
    }

}
