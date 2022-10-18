using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Astro_Math;

namespace Malin_Space_Science_System
{
    public partial class Malin_Space_Science_System : Form
    {
        public Malin_Space_Science_System()
        {
            InitializeComponent();
        }

        #region Methods 
        private void FilterTarget(TextBox t, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && t.Text.IndexOf('.') !=-1)
            {
                e.Handled =true;
                return;
            }
            if (!Char.IsDigit(ch) && ch !=8 && ch != 46)
            {
                e.Handled = true;
            }
            
        }
        #endregion

        #region Buttons
        private void button_sVelocity_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Owavelengthinput.Text)&&!string.IsNullOrEmpty(textBox_Owavelengthinput.Text))
            {
                textBox_sVelocityoutput.Clear();
                double oWavelength = double.Parse(textBox_Owavelengthinput.Text);
                double rWavelength = double.Parse(textBox_Rwavelengthinput.Text);
                double starVelocity = Astro_Math.Calculate.Star_Velocity(rWavelength, oWavelength);
                textBox_sVelocityoutput.Text = starVelocity.ToString() + " m/s";
            }
            else
            {
                MessageBox.Show("Please fill both input boxes", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button_sDistance_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Owavelengthinput.Text))
            {
                double distance = Astro_Math.Calculate.Star_Distance(double.Parse(textBox_sDistanceinput.Text));
                textBox_sDistanceoutput.Text = distance.ToString() + " parsec";
            }
            else
            {
                MessageBox.Show("Parallax Angle input box is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button_kConvert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Celciusinput.Text))
            {
                double kelvin = Astro_Math.Calculate.TemperatueChange(double.Parse(textBox_Celciusinput.Text));
                textBox__Kelvinoutput.Text = kelvin.ToString() + " degrees K";
            }
            else
            {
                MessageBox.Show("Celcius input box is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_eHorizon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_eHorizoninput.Text) && !string.IsNullOrEmpty(textBox_horizonPower.Text))
            {
                double blackHolemass = double.Parse(textBox_eHorizoninput.Text)* Math.Pow(10,double.Parse(textBox_horizonPower.Text));
                double eventHorizon = Astro_Math.Calculate.EventHorizon(blackHolemass);
                double round = Math.Round(eventHorizon,3);
                textBox_eHorizonoutput.Text = round.ToString() + " meters"; 
            }
            else
            {
                MessageBox.Show("Celcius input box is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox_Owavelengthinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            FilterTarget(textBox_Owavelengthinput, e);
        }

        private void textBox_Rwavelengthinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            FilterTarget(textBox_Rwavelengthinput, e);
        }
        #endregion

    }
}
