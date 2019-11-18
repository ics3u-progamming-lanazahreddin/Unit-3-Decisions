/*
 * Created by: Lana ZE
 * Created on: 18-november-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - New Walking Man
 * This program will change an image of a person walking to make it seem as if it was animated once you click 
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

namespace NewWalkingManLanaZE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //hide the instructions label
            lblInstructions.Hide();
        }

        private void GeneratePictureBoxes()
        {
            GeneratePictureBox(61, 78);
            GeneratePictureBox(464, 78);
            GeneratePictureBox(61, 358);
            GeneratePictureBox(61, 358);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //display the instructions label
            lblInstructions.Show();

            //
        }
    }
}
