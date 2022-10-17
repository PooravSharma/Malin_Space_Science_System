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
            textBox_sVelocityoutput.Clear();
            double oWavelength = double.Parse(textBox_Owavelengthinput.Text);
            double rWavelength = double.Parse(textBox_Rwavelengthinput.Text);
            double starVelocity = Astro_Math.Calculate.Star_Velocity(rWavelength, oWavelength);
            textBox_sVelocityoutput.Text = starVelocity.ToString();
        }
        private void button_sDistance_Click(object sender, EventArgs e)
        {

        }

        private void button_kConvert_Click(object sender, EventArgs e)
        {

        }

        private void button_eHorizon_Click(object sender, EventArgs e)
        {

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
