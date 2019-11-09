using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedLoopsLanaZE
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            //variables
            string character;
            string character2;
            int counter;
            int counter2;

            //clear the list
            lstUnicode.Items.Clear();

            //This will caculate the unicode characters and their values from A to Z
            for (counter = 65; counter <= 90; counter++)
            {
                //This will caculate the unicode characters and their values from a to z
                for (counter2 = 97; counter2 <= 122; counter2++)
                {
                    character = Char.ConvertFromUtf32(counter);
                    character2 = Char.ConvertFromUtf32(counter2);
                    lstUnicode.Items.Add(character + "->" + character2);
                }
            }
        }
    }
}
