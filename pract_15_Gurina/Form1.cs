using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract_15_Gurina
{
    public partial class Form1 : Form
    {
        private PochtAdress adress;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public string Proverka()
        {
            string mess = "";
            // проверка на заполненность
            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty || textBox4.Text == String.Empty)
            {
                mess = "Не все строки заполнены!";
            }
            else
            {
                // проверка на буквы
                string st = textBox1.Text;
                foreach (char c in st)
                {
                    if (!char.IsLetter(c))
                    {
                        mess = "В поле Улица должны быть только буквы!";
                        return mess;
                    }
                }
                // проверка на буквы
                string ct = textBox2.Text;
                foreach (char c in ct)
                {
                    if (!char.IsLetter(c))
                    {
                        mess = "В поле Город должны быть только буквы!";
                        return mess;
                    }
                }
                // проверка на цифры
                string pch = textBox3.Text;
                foreach (char c in pch)
                {
                    if (!char.IsNumber(c) || pch.Length != 6)
                    {
                        mess = "Почтовый индекс должен содержать шесть цифр!";
                        return mess;
                    }
                }
                // проверка на буквы
                string str = textBox4.Text;
                foreach (char c in str)
                {
                    if (!char.IsLetter(c))
                    {
                        mess = "В поле Страна должны быть только буквы!";
                        return mess;
                    }
                }
            }
            return mess;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string otvet = Proverka();

            if (otvet == String.Empty)
            {
                // создание нового объекта
                adress = new PochtAdress(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                MessageBox.Show("Адрес создан: " + adress.ToString());
            }
            else
            {
                MessageBox.Show(otvet);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (adress != null)
            {
                string otvet = Proverka();
                // проверка создан ли адрес
                if (otvet == String.Empty)
                {
                    // обновление адреса объекта
                    adress.UpdatingAddres(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                    MessageBox.Show("Адрес создан: " + adress.ToString());
                }
                else
                {
                    MessageBox.Show(otvet);
                }
            }
            else
            {
                MessageBox.Show("Адрес не создан.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (adress != null)
            {
                adress = null;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                MessageBox.Show("Адрес удален.");
            }
            else
            {
                MessageBox.Show("Адрес не создан.");
            }
        }
    }
}
