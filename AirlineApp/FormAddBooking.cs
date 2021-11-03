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
    public partial class FormAddBooking : Form
    {
        AirlineCoordinator aCoord;

        //this variable will be used to remember from where was called this form
        FormMenuBooking formMenuBookReference;

        //constructor
        public FormAddBooking()
        {
            InitializeComponent();
        }

        //constructor
        public FormAddBooking(AirlineCoordinator aCoord, FormMenuBooking callerRefValue)
        {
            InitializeComponent();
            this.aCoord = aCoord;
            formMenuBookReference = callerRefValue;
            for (int i = 1; i <= aCoord.getMaxCustomers(); i++)
            {
                if (aCoord.customerExistCheck(i))
                {
                    string result = aCoord.customerList(i); ;
                    dataGridView2.Rows.Add(result);
                }
            }
            for (int i = 1; i <= aCoord.getMaxFlights(); i++)
            {
                if (aCoord.flightExistCheck(i))
                {
                    string result = aCoord.flightList(i); ;
                    dataGridView1.Rows.Add(result);
                }
            }
        }

        //button Clear ID
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox4.Text = "";
            label4.Text = "";
            label5.Text = "";
        }

        //button Submit
        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            int flightId, customerId;

            //check if input not integer
            if (!int.TryParse(textBox2.Text, out flightId))
            {
                label4.Text = "Please enter a valid choice.";
            }
            //check if input not integer
            if (!int.TryParse(textBox4.Text, out customerId))
            {
                label5.Text = "Please enter a valid choice.";
            }
            //check if customer ID, flight ID exist and empty seats > 0
            if (aCoord.customerExistCheck(customerId) && aCoord.flightExistCheck(flightId)
                && (aCoord.getEmptySeats(flightId) > 0) && aCoord.addBooking(flightId, customerId)
                && aCoord.addPassenger(flightId, customerId))
            {
                label4.Text = "Booking was added successful.";
            }
            else
            {
                label4.Text = "Booking was not added.";
            }
        }

        //back to caller, close current form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            formMenuBookReference.Show();
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
