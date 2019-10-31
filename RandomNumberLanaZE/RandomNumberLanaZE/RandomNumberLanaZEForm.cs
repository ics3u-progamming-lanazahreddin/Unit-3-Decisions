/*
 * Created by: Lana ZE
 * Created on: 31-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Random Number
 * This program genrates a random number between 1 andf 10
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

namespace RandomNumberLanaZE
{
    public partial class frmRandomNumber : Form
    {
        public frmRandomNumber()
        {
            InitializeComponent();
        }

        private void FrmRandomNumber_Load(object sender, EventArgs e)
        {

        }

        private void BtnGetNum_Click(object sender, EventArgs e)
        {
            //declare variables and constants 
            const int MIN_NUM = 1;
            const int MAX_NUM = 10;
            int aRandomNumber;
            Random randomNumberGenerator = new Random();

            //get the random number
            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            //assign the random number to the label
            lblAnswer2.Text = Convert.ToString(aRandomNumber);

        }
    }
}
