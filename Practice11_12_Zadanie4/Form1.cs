using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Practice11_12_Zadanie4;
namespace Practice11_12_Zadanie4
{
    public partial class Form1 : Form
    {
        Athlete sportsmen = new Athlete();
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Мужской");
            comboBox1.Items.Add("Женский");
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Checked();
        }
        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox5.ForeColor = Color.Black;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.ForeColor = Color.Black;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value >= DateTime.Now)
            {
                MessageBox.Show("Выберите дату правильно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sportsmen.Height = Convert.ToDouble(numericUpDown1.Value);
                MessageBox.Show("Идеальный вес = " + sportsmen.CalculateBrok().ToString(), "Расчет идеального веса по формуле брока", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите пол", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sportsmen.Gender = comboBox1.SelectedItem.ToString();
                sportsmen.Height = Convert.ToDouble(numericUpDown1.Value);
                MessageBox.Show("Идеальный вес = " + sportsmen.CalculateCouper().ToString(), "Расчет идеального веса по формуле Куппера", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                sportsmen.Height = Convert.ToDouble(numericUpDown1.Value);
                MessageBox.Show("Идеальный вес = " + sportsmen.CalculateMoxxamed().ToString(), "Расчет идеального веса по формуле брока", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public void Checked()
        {
            string error = "";
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !Regex.IsMatch(textBox1.Text, "^[а - яА-Я]+$"))
            {
                error += "Введите имя правильно";
            }
            else
            {
                sportsmen.Name = textBox1.Text;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text) || !Regex.IsMatch(textBox1.Text, "^[а - яА-Я]+$"))
            {
                error += "\nВведите фамилию правильно";
            }
            else
            {
                sportsmen.Surname = textBox2.Text;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text) || !Regex.IsMatch(textBox1.Text, "^[а - яА-Я]+$"))
            {
                error += "\nВведите отчество правильно";
            }
            else
            {
                sportsmen.LastName = textBox3.Text;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                error += "\nВыберите пол";
            }
            else
            {
                sportsmen.Gender = comboBox1.SelectedItem.ToString();
            }
            if (dateTimePicker1.Value >= DateTime.Now)
            {
                error += "\nВыберите дату правильно";
            }
            else
            {
                sportsmen.DateOfBirthday = dateTimePicker1.Value;
            }
            if (numericUpDown1.Value <= 0)
            {
                error += "\nВыберите рост правильно";
            }
            else
            {
                sportsmen.Height = Convert.ToDouble(numericUpDown1.Value);
            }
            if (numericUpDown2.Value <= 0)
            {
                error += "\nВыберите вес правильно";
            }
            else
            {
                sportsmen.Weight = Convert.ToDouble(numericUpDown2.Value);
            }
            if (string.IsNullOrWhiteSpace(textBox5.Text) || !Regex.IsMatch(textBox1.Text, "^[а - яА-Я]+$"))
            {
                error += "\nВведите вид спорта правильно";
            }
            else
            {
                sportsmen.TypeSport = textBox5.Text;
            }
            if (error == "")
            {
                MessageBox.Show(sportsmen.InfoAthlet(), "Информация о спортсмене", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
