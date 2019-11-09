/*
 * Created by: Lana ZE
 * Created on: 09-11-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
 * This program that averages out the number after being given multiple inputs.
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

namespace RunningAverageLanaZE
{
    public partial class frmRunningAverage : Form
    {
        public frmRunningAverage()
        {
            InitializeComponent();
            lblCalculations.Hide();

        }

        //variables
        int numbersCount = 0;
        int number = 0;
        int sum = 0;
        double average = 0;

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //this will let us divide by the number of all numbers inputted
            numbersCount++;

            //get the number from the nud
            number = (int)nudNumbers.Value;

            //add the inputted number into the total
            sum += number;

            //caluclate the average of every number inputted
            average = sum / numbersCount;

            //Change the label's text
            lblCalculations.Text = "Your average is " + Convert.ToString(Math.Round(average, 2));

            //When you wanna reset
            if (number == -1)
            {
                //resetting all variables
                numbersCount = 0;
                number = 0;
                sum = 0;
                average = 0;

                //Hiding the label once again
                lblCalculations.Hide();
            }
            else
            {
                //Show the label and subsequently the average
                lblCalculations.Show();
            }
        }
    }
}
