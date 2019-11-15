/*
 * Created by: Lana ZE
 * Created on: 15-11-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Percentage Program
 * This program gives you the percentage value of a number grade (4++ to 0----)
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

namespace SwitchLanaZE
{
    public partial class frmSwitch : Form
    {
        public frmSwitch()
        {
            InitializeComponent();
            lblPercentage.Hide();
        }

        //variables
        string level;
        int percentGrade;

        //Function: Percent
        //Input: string level
        //Output: int percentage
        //Description: Takes in a number grade and converts it into a percentage
        private int Percent(string level)
        {
            int percentage;

            //this will look at the string value that was passed
            //and then convert percentage to the string's associated mark
            switch (level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 85;
                    break;
                case "4-":
                    percentage = 80;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;
                default:
                    percentage = -1;
                    break;
            }

            //returns the actual value after the function is called
            return percentage;
        }

            private void BtnConvert_Click(object sender, EventArgs e)
        {
            level = txtLevel.Text;
            percentGrade = Percent(level);
            lblPercentage.Text = Convert.ToString(percentGrade);
            lblPercentage.Show();
        }
    }
}
