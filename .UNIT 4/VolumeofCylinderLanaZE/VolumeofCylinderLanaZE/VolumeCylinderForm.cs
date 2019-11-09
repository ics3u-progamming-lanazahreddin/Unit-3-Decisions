using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeofCylinderLanaZE
{
    public partial class frmVolumeCylinder : Form
    {
        public frmVolumeCylinder()
        {
            InitializeComponent();
            //hide the label before the volume is calculated
            lblVol.Hide();
        }

        //Function: Calculate Volume
        //Input: decimal Height, decimal Radius
        //Output: decimal
        //Description: Calculates Volume
        private decimal CalculateVolume(decimal height, decimal radius)
        {
            decimal volume;

            //formula for cylindrical volume is Pi(h)(r^2)
            volume = (decimal)Math.PI * height * radius * radius;

            //round it off to 2 decimal points
            volume = Math.Round(volume, 2);

            return volume;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //Display the volume
            lblVol.Text = "Volume = " + Convert.ToString
                (CalculateVolume(decimal.Parse(txtHeight.Text), decimal.Parse(txtRadius.Text)));
            lblVol.Show();
        }
    }
}
