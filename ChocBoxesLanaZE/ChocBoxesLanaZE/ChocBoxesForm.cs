/*
 * Created by: Lana ZE
 * Created on: 07/11/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program gives you a large prize for selling over 20 boxes, 
 * a small prize for selling 10-20 boxes, 
 * and gives you an hounourable mention for anything less than 10 bozes.
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

namespace ChocBoxesLanaZE
{
    public partial class frmChocBoxes : Form
    {
        public frmChocBoxes()
        {
            InitializeComponent();
            //hide the prize label
            this.lblPrize.Hide();
        }
        //declare boxesSold
        int boxesSold;

        private void BtnPrize_Click(object sender, EventArgs e)
        {
            boxesSold = int.Parse(txtNumberSold.Text);
            if (boxesSold > 20)
            {
                lblPrize.Text = "You get a large prize!!!!!";
                this.lblPrize.Show();
            }
            else if (boxesSold < 10)
            {
                lblPrize.Text = "You get an honourable mention!";
                this.lblPrize.Show();
            }
            else
            {
                lblPrize.Text = "You get a small prize!";
                this.lblPrize.Show();
            }
        }   
    }
}
