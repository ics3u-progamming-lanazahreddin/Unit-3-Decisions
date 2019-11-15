/*
 * Created by: Lana ZE
 * Created on: 15-November-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Pass By Reference
 * This program randomly generates pictures in a picture box when it is clicked
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

namespace PassByRef
{
    public partial class frmPassByRef : Form
    {
        //declare global variable
        Random randomNumGenerator = new Random();

        public frmPassByRef()
        {
            InitializeComponent();
        }


        //Procedure: ChangeCard
        //Input: ref PictureBox aPicturebox , int cardNumber
        //Output:void
        //Description:This procedure takes a Picturebox passed by refrence and a card Number.
        //it assigns the image to a picturbox to the card with a given number
        private void ChangeCard(ref PictureBox aPictureBox, int cardNumber)
        {
            if (cardNumber == 1)
            {
                aPictureBox.Image = Properties.Resources.Front;
            }
            else if (cardNumber == 2)
            {
                aPictureBox.Image = Properties.Resources.JC;
            }
            else if (cardNumber == 3)
            {
                aPictureBox.Image = Properties.Resources.JD;
            }
            else if (cardNumber == 4)
            {
                aPictureBox.Image = Properties.Resources.JH;
            }
            else if (cardNumber == 5)
            {
                aPictureBox.Image = Properties.Resources.JS;
            }
            else if (cardNumber == 6)
            {
                aPictureBox.Image = Properties.Resources.KC;
            }
            else if (cardNumber == 7)
            {
                aPictureBox.Image = Properties.Resources.KD;
            }
            else if (cardNumber == 8)
            {
                aPictureBox.Image = Properties.Resources.KH;
            }
            else if (cardNumber == 9)
            {
                aPictureBox.Image = Properties.Resources.KS;
            }
            else if (cardNumber == 10)
            {
                aPictureBox.Image = Properties.Resources.QC;
            }
            else if (cardNumber == 11)
            {
                aPictureBox.Image = Properties.Resources.QD;
            }
            else if (cardNumber == 12)
            {
                aPictureBox.Image = Properties.Resources.QH;
            }
            else if (cardNumber == 13)
            {
                aPictureBox.Image = Properties.Resources.QS;
            }

        }   
              
            private void PicRandom_Click(object sender, EventArgs e)
        {
            //declare local constants and variables 
            const int MAX_NUM_CARDS = 52;
            int aRandomNumer;

            //Get a random umber between 1 and the maximum
            aRandomNumer = randomNumGenerator.Next(1, MAX_NUM_CARDS + 1);

            //Ckang the card depending on the random selection
            ChangeCard(ref this.picRandom, aRandomNumer);
        }
    }
}
