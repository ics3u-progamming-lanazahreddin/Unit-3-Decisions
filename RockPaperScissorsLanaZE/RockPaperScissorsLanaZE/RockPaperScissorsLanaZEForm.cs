/*
 * Created by: Lana ZE
 * Created on: 07/11/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program is a simple game of rock paper scissors, 
 * that generates a random choice once you've chosen yours.
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

namespace RockPaperScissorsLanaZE
{
    public partial class frmRockPaperScissors : Form
    {
        //global consts and random number generator
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random numberGenerator = new Random();
        

        public frmRockPaperScissors()
        {
             InitializeComponent();
            grbComputerChoice.Enabled = false;
            this.lblResult.Hide();
        }

        private void FrmRockPaperScissors_Load(object sender, EventArgs e)
        {

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            //local variables and constants
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;
            int playerChoice, computerChoice;

            //if the player chooses rock, marks it as such internally. 
            //if not, it goes on and checks the other choices to mark it internally. 
            //if the player makes no choice, it automatically assigns rock as the choice
            if (radRockU.Checked == true)
            {
                playerChoice = ROCK;
            }
            else if (radPaperU.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radScissorsU.Checked == true)
            {
                playerChoice = SCISSORS;
            }
            else
            //Chooses rock for you in case of no choice
            {
                radRockU.Checked = true;
                playerChoice = ROCK;
            }

            //This will generate a randomized number that becomes the computer's choice
            computerChoice = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            //1 is for rock, 2 is for paper, 3 is for scissors
            if (computerChoice == 1)
            {
                radRockC.Checked = true;
            }

            if (computerChoice == 2)
            {
                radPaperC.Checked = true;
            }

            if (computerChoice == 3)
            {
                radScissorsC.Checked = true;
            }

            //if the player and computer's choices are the same, then it returns a draw
            if (playerChoice == computerChoice)
            {
                lblResult.Text = "A tie, try again";
                this.lblResult.Show();
            }

            //judges the choices and sees who wins
            if (playerChoice == ROCK)
            {
                if (computerChoice == PAPER)
                {
                    lblResult.Text = "You Lose";
                    this.lblResult.Show();
                }
                else if (computerChoice == SCISSORS)
                {
                    lblResult.Text = "You Win!";
                    this.lblResult.Show();
                }
            }

            if (playerChoice == PAPER)
            {
                if (computerChoice == SCISSORS)
                {
                    lblResult.Text = "You Lose";
                    this.lblResult.Show();
                }
                else if (computerChoice == ROCK)
                {
                    lblResult.Text = "You Win!";
                    this.lblResult.Show();
                }
            }

            if (playerChoice == SCISSORS)
            {
                if (computerChoice == ROCK)
                {
                    lblResult.Text = "You Lose";
                    this.lblResult.Show();
                }
                else if (computerChoice == PAPER)
                {
                    lblResult.Text = "You Win!";
                    this.lblResult.Show();
                }
            }

        }
    
    }
}
