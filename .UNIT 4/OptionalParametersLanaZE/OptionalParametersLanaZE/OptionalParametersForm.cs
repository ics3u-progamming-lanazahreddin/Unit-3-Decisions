using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionalParametersLanaZE
{
    public partial class frmOptionalParameters : Form
    {
        public frmOptionalParameters()
        {
            InitializeComponent();
            lblExitInfo.Hide();
        }

        string apartmentNum, streetAddress, city, province, postalCode;

        private void Button1_Click(object sender, EventArgs e)
        {
            //reset the labels
            lblExitInfo.Text = "Your Address: ";
            lblEnterInfo.Text = "Enter your info";

            //Converts all the textboxes' content into string variables
            apartmentNum = txtApartmentNum.Text;
            streetAddress = txtStreet.Text;
            city = txtCity.Text;
            province = txtProvince.Text;
            postalCode = txtPostalCode.Text;

            //Checks if any of the required fields are filled in (Everything but apartment number)
            if (streetAddress == " " | streetAddress == "Street Address")
            {
                lblEnterInfo.Text = "Please enter your street address";
            }
            else if (city == " " | city == "City")
            {
                lblEnterInfo.Text = "Please enter your city";
            }
            else if (province == " " | province == "Province")
            {
                lblEnterInfo.Text = "Please enter your province";
            }
            else if (postalCode == " " | postalCode == "Postal Code")
            {
                lblEnterInfo.Text = "Please enter your postal code";
            }
            else if (apartmentNum == " " | apartmentNum == "Apartment Number (Optional)")
            {
                Address(streetAddress, city, province, postalCode);
                lblExitInfo.Show();
            }
            else
            {
                Address(apartmentNum, streetAddress, city, province, postalCode);
                lblExitInfo.Show();
            }
        }

        //Procedure: Address
        //Input: string apartNum, string street, string city, string province, string postal
        //output: void
        //Displays the address information that was inputted
        private void Address(string apartNum, string street, string city, string province, string code)
        {
            lblExitInfo.Text += apartNum + " " + street + " " + city + " " + province + " " + code;
        }

        //Procedure: Address
        //Input: apartNum, string street, string city, string province, string postal
        //output: void
        //Displays the address information that was inputted
        private void Address(string street, string city, string province, string code)
        {
            lblExitInfo.Text += street + " " + city + " " + province + " " + code;
        }
    }
}
