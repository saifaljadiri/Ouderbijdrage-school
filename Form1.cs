using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ouderbijdrage_school
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Peildatum_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private int CalcAge(DateTime dateBorn, DateTime toDate)
        {
            TimeSpan diffDate = toDate - dateBorn;
            return Convert.ToInt16(Math.Floor(diffDate.TotalDays / 365));
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            double basisbedrag = 50;
            double kindtot10 = 25;
            double kindouderdan = 37;

            double total = basisbedrag;

            string geselecteerdeGezinSoort = comboBox1.Items[this.comboBox1.SelectedIndex].ToString();
            string eengezin = comboBox1.Items[0].ToString();
            DateTime geboortedatum1 = dateTimePicker1.Value;
            DateTime geboortedatum2 = dateTimePicker4.Value;
            DateTime geboortedatum3 = dateTimePicker6.Value;

            DateTime peildatum = dateTimePicker2.Value;
            TimeSpan leeftijd1 = peildatum - geboortedatum1;
            TimeSpan leeftijd2 = peildatum - geboortedatum2;
            TimeSpan leeftijd3 = peildatum - geboortedatum3;

            if (CalcAge(geboortedatum1, peildatum) < 10)
            {
                total += kindtot10;
            }
            else
            {
                total += kindouderdan;
            }

            if (CalcAge(geboortedatum2, peildatum) < 10)
            {
                total += kindtot10;
            }
            else
            {
                total += kindouderdan;
            }

            if (CalcAge(geboortedatum3, peildatum) < 10)
            {
                total += kindtot10;
            }
            else
            {
                total += kindouderdan;
            }

            if (total > 150)
            {
                total = 150;
            }

            if (geselecteerdeGezinSoort == eengezin)
            {
                total *= 0.75;
            }

            textBox1.Text = Convert.ToString(total);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker4.Text = "";
            dateTimePicker6.Text = "";

        }
    }
}
