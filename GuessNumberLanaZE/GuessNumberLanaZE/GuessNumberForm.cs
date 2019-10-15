/*
     * Created by: Lana ZE
     * Created on: 30-09-2019
     * Created for: ICS3U Programming
     * Daily Assignment – Day #16 - Guess Number
     * This program asks the user to guess a number between 1 and 10.
     * If they get it right, a question mark is displayed, and a correct sound is displayed.
     * If they get it wrong, an X is displayed and an incorrect sound is displayed. The number that is generated in random.
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

namespace GuessNumberLanaZE
{
    public partial class frmGuessNumber : Form
    {
        public frmGuessNumber()
        {
            InitializeComponent();
            // hide the picture boxes and the answer label
            lblA.Hide();
            picRight.Hide();
            picWrong.Hide();
        }

        //The number the user has to guess
        const int Answer = 7;

        private void FrmGuessNumber_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuess_Click(object sender, EventArgs e)
        {
            // turn the number entered by the user into a value
            int Guess = int.Parse(txtNumGuess.Text);

            //compares the user's number with the computer's number
            if (Guess == Answer)
            {
                //this shows a checkmark and an affirmation of success if you got it right
                this.picRight.Show();
                this.picWrong.Hide();
                lblA.Text = "Ding ding, you got it right!";
                this.lblA.Show();
                //this is the code for playing sound
                SoundPlayer CorrectSound = new SoundPlayer(@"right.wav");
                CorrectSound.Play();
            }

            else
            {
                //this shows a red x and tells you that you got the answer wrong
                this.picWrong.Show();
                this.picRight.Hide();
                lblA.Text = "Dong dong, you got it wrong";
                this.lblA.Show();
                //this is the code for playing sound, where the files are in the debug folder of this program
                SoundPlayer WrongSound = new SoundPlayer(@"wrong.wav");
                WrongSound.Play();
            }
        }


    }
}

