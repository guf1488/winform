using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // ekz
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            if (textBox1.Text.Length < 6 || textBox1.Text.Length > 12)
            {
                result = "Неверная длина пароля";
                MessageBox.Show(result);
                return;
            }
            bool checkDigit = false;
            bool checkNum = false;
            foreach (var item in textBox1.Text)
            {
                checkDigit = checkDigit || char.IsDigit(item);
            }
            foreach (var item in textBox1.Text)
            {
                checkNum = checkNum || char.IsLetter(item);
            }
            if (!(checkNum && checkDigit))
            {
                result += "В пароле только буквы или только цифры";
                MessageBox.Show(result);
            }


            if (string.Equals(textBox1.Text, textBox2.Text))
            {
                result += "Пароли одинаковые";
                MessageBox.Show(result);
            }
            else
            {
                result += "Пароли не одинаковые";
                MessageBox.Show(result);
            }

            
        }
    }
}
