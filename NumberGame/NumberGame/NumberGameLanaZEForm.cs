/*
 * Created by: Lana ZE
 * Created on: 1-november-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Number Game
 * This program asks the user to guess a randomly generated number
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
using System.Media;

namespace NumberGame
{
    public partial class frmNumberGame : Form
    {
        //declare global variables and constants
        int randomNumber;
        Random numberGenerator = new Random();
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 10;

        public frmNumberGame()
        {
            InitializeComponent();
            randomNumber = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //turns the user's guess into a value
            int Guess = int.Parse(txtA.Text);

            //check if the user's guess right
            if (Guess == randomNumber)
            {
                lblA2.Text = "You guessed it right!";
            }
            else
            {
                lblA2.Text = "oops, your guess was wrong!";
            }
                


        }
    }
}
