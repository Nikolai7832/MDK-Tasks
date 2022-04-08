using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                CabValue.Checker(textBox1.Text) &&
                CabValue.Checker(textBox2.Text) &&
                CabValue.Checker(textBox3.Text)
               )
            {
                label4.Text += $"\n {CabValue.Value(textBox1.Text, textBox2.Text, textBox3.Text)}" ;
            }
        }


    }
    public class CabValue
    {
        public delegate bool Checkers(string str);
        static public bool Checker(string str)
        {
            try 
            {
                Double.Parse(str);
                if (Double.Parse(str) < 0)
                    throw new Exception();
                    return true; }

            catch (Exception ex)
            {
                ex = new Exception(
                       "Введенное значение не должно содержать " +
                       "\n1. Букв" +
                       "\n2. Знаков, кроме разделяющей целую и дробнуб часть запятой" +
                       "\n3. Не должно быть пустым" +
                       "\n4. Не должно быть отрицательным");
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        static public double Value(string str1, string str2, string str3)
        {
            return (Double.Parse(str1) * Double.Parse(str2) + Double .Parse(str3));
        }

    }

}
