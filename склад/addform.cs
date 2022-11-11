using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace склад
{
    public partial class addform : Form
    {
        private sclad scl;

        public addform()
        {
            InitializeComponent();
            scl = new sclad();
            comboBox1.SelectedItem = "Медь";
            

        }
        public addform(sclad resurs)
            : this()
        {
            textBox1.Text = resurs.name;
            textBox4.Text = resurs.raz;
            comboBox1.SelectedItem = resurs.mater;
            numericUpDown2.Value = (decimal)resurs.kol;
            numericUpDown1.Value = (decimal)resurs.min;
            PriceBox.Text = Convert.ToString(resurs.price);
            textBox3.Text = Convert.ToString(resurs.fulprice);



        }
        public sclad sclad => scl;
        private void addform_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(numericUpDown2.Value);
            double pr1 = double.Parse(PriceBox.Text);
            double pr2 = pr1 * num1;
            textBox3.Text = Convert.ToString(pr2);
            if (textBox1.Text != "")
            {
                button1.Enabled = true;
            }else button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scl.name = textBox1.Text;
            scl.raz = ($"{textBox4.Text} cm");

            scl.mater = comboBox1.Text;
            double num1 = Convert.ToDouble(numericUpDown2.Value);
            scl.kol = num1;
            scl.min = numericUpDown1.Value;
            double pr1 = double.Parse(PriceBox.Text);
            double pr2 = pr1 * num1;
            textBox3.Text = Convert.ToString(pr2);
            scl.fulprice = pr2;
            scl.price = int.Parse(PriceBox.Text);






            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = PriceBox.Text;
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(numericUpDown2.Value);
            double pr1 = 0;
            double.TryParse(PriceBox.Text,out pr1);
            double pr2 = pr1 * num1;
            textBox3.Text = Convert.ToString(pr2);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(numericUpDown2.Value);
            double pr1 = double.Parse(PriceBox.Text);
            double pr2 = pr1 * num1;
            textBox3.Text = Convert.ToString(pr2);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void PriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
