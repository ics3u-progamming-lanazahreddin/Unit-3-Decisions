/*
 * Created by: Lana ZE
 * Created on: 09/11/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Perfect Squares
 * This program that displays all the perfect squares 
 * under a number chosen by the user
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectSquaresWWhileLoopLanaZE
{
    public partial class frmPSWWL : Form
    {
        public frmPSWWL()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //variables
            int endingValue;
            int value = 1;
            double sqrtAsDouble;
            int sqrtAsInt;

            lstSquares.Items.Clear();
            endingValue = Convert.ToInt32(nudEndValue.Value);

            while (value <= endingValue)
            {
                sqrtAsDouble = Math.Sqrt(value);
                sqrtAsInt = Convert.ToInt32(sqrtAsDouble);

                if (sqrtAsInt == sqrtAsDouble)
                {
                    this.lstSquares.Items.Add(value + " is a perfect square");
                    this.Refresh();
                }
                value = value + 1;
            }

        }
    }
}
