using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
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
        bool modeOn;
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
        private void ModeChange()
        {
            if (modeOn ==false)
            {
                foreach (var textBox in this.Controls.OfType<TextBox>())
                {
                    textBox.BackColor = Color.Gray;

                    textBox.ForeColor = Color.FromArgb(Color.White.ToArgb()^0xffffff);
                    //textBox.Font = new Font(textBox.Font, FontStyle.Bold);
                }
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.BackColor = Color.Gray;
                    button.ForeColor = Color.FromArgb(Color.White.ToArgb()^0xffffff);
                    //button.Font = new Font(button.Font, FontStyle.Bold);
                }
                foreach (var lable in this.Controls.OfType<Label>())
                {
                    lable.ForeColor = Color.White;
                }
                this.BackColor =Color.Black;
                #region menuItems 
                menuStrip1.BackColor = Color.Black;
                menuStrip1.ForeColor = Color.FromArgb(Color.Black.ToArgb()^0xffffff);
                menuItem_Options.BackColor = Color.Black;
                menuItem_Options.ForeColor = Color.FromArgb(Color.Black.ToArgb()^0xffffff);
                menuItem_Languanges.BackColor = Color.Black;
                menuItem_Languanges.ForeColor = Color.FromArgb(Color.Black.ToArgb()^0xffffff);
                menuItem_Customize.BackColor = Color.Black;
                menuItem_Customize.ForeColor = Color.FromArgb(Color.Black.ToArgb()^0xffffff);
                menuItem_Modes.BackColor = Color.Black;
                menuItem_Modes.ForeColor = Color.FromArgb(Color.Black.ToArgb()^0xffffff);
                languages_English.BackColor = Color.Black;
                languages_English.ForeColor = Color.FromArgb(Color.Black.ToArgb()^0xffffff);
                languages_French.BackColor = Color.Black;
                languages_French.ForeColor = Color.FromArgb(Color.Black.ToArgb()^0xffffff);
                languages_German.BackColor = Color.Black;
                languages_German.ForeColor = Color.FromArgb(Color.Black.ToArgb()^0xffffff);
                customize_Background.BackColor = Color.Black;
                customize_Background.ForeColor = Color.FromArgb(Color.Black.ToArgb()^0xffffff);
                customize_Buttons.BackColor = Color.Black;
                customize_Buttons.ForeColor = Color.FromArgb(Color.Black.ToArgb()^0xffffff);
                customize_Lable.BackColor = Color.Black;
                customize_Lable.ForeColor = Color.FromArgb(Color.Black.ToArgb()^0xffffff);
                customize_Textboxes.BackColor = Color.Black;
                customize_Textboxes.ForeColor = Color.FromArgb(Color.Black.ToArgb()^0xffffff);
                #endregion
                modeOn = true;
            }
            else
            {
                foreach (var textBox in this.Controls.OfType<TextBox>())
                {
                    textBox.BackColor = Color.White;

                    textBox.ForeColor = Color.FromArgb(Color.White.ToArgb()^0xffffff);
                    textBox.Font = new Font(textBox.Font, FontStyle.Bold);
                }
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.BackColor = Color.White;
                    button.ForeColor = Color.FromArgb(Color.White.ToArgb()^0xffffff);
                    button.Font = new Font(button.Font, FontStyle.Bold);
                }
                foreach (var lable in this.Controls.OfType<Label>())
                {
                    lable.ForeColor = Color.Black;
                }
                this.BackColor =Color.White;
                menuStrip1.BackColor = Color.White;
                menuStrip1.ForeColor = Color.FromArgb(Color.White.ToArgb()^0xffffff);
                menuItem_Options.BackColor = Color.White;
                menuItem_Options.ForeColor = Color.FromArgb(Color.White.ToArgb()^0xffffff);
                menuItem_Languanges.BackColor = Color.White;
                menuItem_Languanges.ForeColor = Color.FromArgb(Color.White.ToArgb()^0xffffff);
                menuItem_Customize.BackColor = Color.White;
                menuItem_Customize.ForeColor = Color.FromArgb(Color.White.ToArgb()^0xffffff);
                menuItem_Modes.BackColor = Color.White;
                menuItem_Modes.ForeColor = Color.FromArgb(Color.White.ToArgb()^0xffffff);


                modeOn = false;
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
                double blackHolemass = double.Parse(textBox_eHorizoninput.Text)* Math.Pow(10, double.Parse(textBox_horizonPower.Text));
                double eventHorizon = Astro_Math.Calculate.EventHorizon(blackHolemass);
                double round = Math.Round(eventHorizon, 3);
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

        private void customize_Background_Click(object sender, EventArgs e)
        {
            DialogResult colorResult = colorDialog1.ShowDialog();
            if (colorResult == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                menuStrip1.BackColor = colorDialog1.Color;
                menuStrip1.ForeColor = Color.FromArgb(colorDialog1.Color.ToArgb()^0xffffff);
            }
        }

        private void customize_Buttons_Click(object sender, EventArgs e)
        {
            DialogResult colorResult = colorDialog1.ShowDialog();
            if (colorResult == DialogResult.OK)
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.BackColor = colorDialog1.Color;
                    button.ForeColor = Color.FromArgb(colorDialog1.Color.ToArgb()^0xffffff);
                    button.Font = new Font(button.Font, FontStyle.Bold);
                }

            }
        }

        private void customize_Lable_Click(object sender, EventArgs e)
        {
            DialogResult colorResult = colorDialog1.ShowDialog();
            if (colorResult == DialogResult.OK)
            {
                foreach (var lable in this.Controls.OfType<Label>())
                {
                    lable.ForeColor = colorDialog1.Color;
                }

            }
        }

        private void customize_Textboxes_Click(object sender, EventArgs e)
        {
            DialogResult colorResult = colorDialog1.ShowDialog();
            if (colorResult == DialogResult.OK)
            {
                foreach (var textBox in this.Controls.OfType<TextBox>())
                {
                    textBox.BackColor = colorDialog1.Color;

                    textBox.ForeColor = Color.FromArgb(colorDialog1.Color.ToArgb()^0xffffff);
                    textBox.Font = new Font(textBox.Font, FontStyle.Bold);
                }

            }
        }
        private void menuItem_Modes_Click(object sender, EventArgs e)
        {
            ModeChange();
        }

        #endregion


    }
}
