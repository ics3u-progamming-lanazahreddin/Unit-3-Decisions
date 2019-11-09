using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassByValueLanaZE
{
    public partial class frmPassByVaue : Form
    {
        public frmPassByVaue()
        {
            InitializeComponent();
        }


        private void ConvertToFahr(decimal celsiusTemp)
        {
            //variables
            decimal fahrenheitTemp;

            //Calculations for Cel to Fahr
            fahrenheitTemp = celsiusTemp * (decimal)9 / (decimal)5 + 32;

            //Display the conversion
            lblA.Text = "Here is your temperature in degrees Fahrenheit: " + fahrenheitTemp;
        }
        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //variables
            decimal userTemp;

            //Make userTemp into your input for temperature
            userTemp = Convert.ToDecimal(txtTemp.Text);

            //Call the procedure
            this.ConvertToFahr(userTemp);
        }
    }
}
