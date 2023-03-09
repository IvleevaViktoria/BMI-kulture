using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void qqq(object sender, EventArgs e)
        {
            woman.BorderStyle = BorderStyle.None;
            man.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.Gainsboro;
            woman.BackColor = Color.WhiteSmoke;
        }

        private void qq(object sender, EventArgs e)
        {
            man.BorderStyle = BorderStyle.None;
            woman.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.WhiteSmoke;
            woman.BackColor = Color.Gainsboro;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Weights = Convert.ToDouble(weight.Text);
            double Heights = Convert.ToDouble(height.Text);
            Heights = Heights / 100;
            double BMI = Math.Round(Weights / (Heights * Heights),1);
            label8.Visible = true;

            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            strel.Visible = true;
            shkal.Visible = true;
            if (BMI < 18.5)
            {
                picture.Image = Properties.Resources.bmi_underweight_icon;
                BMItext.Text = "Недовес";
                strelka.Location = new Point(0, 0);
                var x = strelka.Location.X + BMI;
                strelka.Location = new Point((int)x, strelka.Location.Y);
            }
            else if (BMI < 24.9)
            {
                picture.Image = Properties.Resources.bmi_healthy_icon;
                BMItext.Text = "Здоровый";
                strelka.Location = new Point(15, 0);
                var x = strelka.Location.X + BMI;
                strelka.Location = new Point((int)x, strelka.Location.Y);
            }
            else if (BMI < 29.9)
            {
                picture.Image = Properties.Resources.bmi_overweight_icon;
                BMItext.Text = "Перевес";
                strelka.Location = new Point(60, 0);
                var x = strelka.Location.X + BMI;
                strelka.Location = new Point((int)x, strelka.Location.Y);
            }
            else if (BMI > 30)
            {
                picture.Image = Properties.Resources.bmi_obese_icon;
                BMItext.Text = "Ожирение";
                strelka.Location = new Point(110, 0);
                var x = strelka.Location.X + BMI;
                strelka.Location = new Point((int)x, strelka.Location.Y);
            }
            bmmi.Text = BMI.ToString();
            bmmi.Size = picture.Size;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
