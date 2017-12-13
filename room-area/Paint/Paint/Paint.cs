using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Single width, lenght, height, area, volume, paint;

            width = Convert.ToSingle(txtWidth.Text);
            height = Convert.ToSingle(txtHeight.Text);
            lenght = Convert.ToSingle(txtLength.Text);

            area = width * lenght;
            volume = width * height * lenght;
            paint = (width * height + lenght * height) * 2 / 14;

            //based on 14meters square per liter

            lblArea.Text = "The floor area is " + Convert.ToString(area) + " m2";
            lblVolume.Text = "The volume of the room is " + Convert.ToString(volume) + " m3";
            lblPaint.Text = Convert.ToString(paint) + " liters of paint needed to paint the room";
        }
    }
}
