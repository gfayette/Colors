﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorApp
{
    public partial class Colors : Form
    {

        private Bitmap bm = new Bitmap(1000, 230);
        private Graphics bmG;
        private int red, green, blue;

        public Colors()
        {
            InitializeComponent();
            bmG = Graphics.FromImage(bm);
            DoubleBuffered = true;
            updateBar();
        }

        private void Colors_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void updateColor()
        {
            red = 255 * redBar.Value / 1000;
            green = 255 * greenBar.Value / 1000;
            blue = 255 * blueBar.Value / 1000;

            if (normalizeBox.Checked)
            {
                int rgbMax = Math.Max(red, Math.Max(green, blue));
                if (rgbMax != 0)
                {
                    red = Convert.ToInt32(red * 255f / rgbMax);
                    green = Convert.ToInt32(green * 255f / rgbMax);
                    blue = Convert.ToInt32(blue * 255f / rgbMax);
                }
                else
                {
                    red = 255;
                    green = 255;
                    blue = 255;
                }
            }

            Color newColor = Color.FromArgb(255, red, green, blue);
            bmG.Clear(newColor);
            Invalidate();
        }

        private void updateBar()
        {
            redUpDown.Value = redBar.Value;
            greenUpDown.Value = greenBar.Value;
            blueUpDown.Value = blueBar.Value;
            updateColor();
        }

        private void updateUpDown()
        {
            redBar.Value = (int)redUpDown.Value;
            greenBar.Value = (int)greenUpDown.Value;
            blueBar.Value = (int)blueUpDown.Value;
            updateColor();
        }

        private void redBar_Scroll(object sender, EventArgs e)
        {
            updateBar();
        }

        private void greenBar_Scroll(object sender, EventArgs e)
        {
            updateBar();
        }

        private void blueBar_Scroll(object sender, EventArgs e)
        {
            updateBar();
        }

        private void blueUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateUpDown();
        }

        private void redUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateUpDown();
        }

        private void greenUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateUpDown();
        }

        private void normalizeBox_CheckedChanged(object sender, EventArgs e)
        {
            updateColor();
        }
    }
}
