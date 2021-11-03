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
    public partial class FormAddFlight : Form
    {
        AirlineCoordinator aCoord;

        //this variable will be used to remember from where was called this form
        FormMenuFlight formMenuFlighrReference;

        //constructor
        public FormAddFlight()
        {
            InitializeComponent();
        }

        //constructor
        public FormAddFlight(AirlineCoordinator aCoord, FormMenuFlight callerRefValue)
        {
            InitializeComponent();
            this.aCoord = aCoord;
            formMenuFlighrReference = callerRefValue;
        }

        //button Submit
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int maxSeats;
            string origin = textBox2.Text;
            string destination = textBox3.Text;
            //check if input not integer and strings not empty
            if (int.TryParse(textBox1.Text, out maxSeats) && (maxSeats > 0) && origin != "" && destination != "")
            {
                aCoord.addFlight(origin, destination, maxSeats);
                label5.Text = "Flight was added successfully.";
            }
            else
            {
                label5.Text = "Flight was not added.";
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
        private void buttonBackToFlight_Click(object sender, EventArgs e)
        {
            formMenuFlighrReference.Show();
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
