using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineApp
{
    public partial class FormAddCustomer : Form
    {
        AirlineCoordinator aCoord;

        //this variable will be used to remember from where was called this form
        FormMenuCustomer formMenuCustReference;

        //constructor
        public FormAddCustomer()
        {
            InitializeComponent();
        }

        //constructor
        public FormAddCustomer(AirlineCoordinator aCoord, FormMenuCustomer callerRefValue)
        {
            InitializeComponent();
            this.aCoord = aCoord;
            formMenuCustReference = callerRefValue;
        }

        //button Submit
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string fname = textBox2.Text;
            string lname = textBox3.Text;
            string phone = textBox1.Text;
            //check if strings not empty
            if (fname != "" && lname != "" && phone != "")
            {
                aCoord.addCustomer(fname, lname, phone);
                label5.Text = "Customer " + fname + " " + lname + " was added successfully.";
            }
            else
            {
                label5.Text = "Customer " + fname + " " + lname + " was not added.";
            }
        }

        //button Clear ID
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label5.Text = "";
        }

        //back to caller, close current form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            formMenuCustReference.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
