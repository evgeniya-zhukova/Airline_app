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
    public partial class FormMenuBooking : Form
    {
        AirlineCoordinator aCoord;

        //this variable will be used to remember from where was called this form
        FormAirlineApp formAppReference;

        //constructor
        public FormMenuBooking()
        {
            InitializeComponent();
        }

        //constructor
        public FormMenuBooking(AirlineCoordinator aCoord, FormAirlineApp callerRefValue)
        {
            InitializeComponent();
            this.aCoord = aCoord;
            formAppReference = callerRefValue;
        }

        //call form Add Booking to display 
        private void buttonAddBooking_Click(object sender, EventArgs e)
        {
            FormAddBooking form = new FormAddBooking(aCoord, this);
            form.Show();
            //hide current form
            this.Hide();
        }

        //call form View Bookings to display 
        private void buttonViewBookings_Click(object sender, EventArgs e)
        {
            FormViewBooking form = new FormViewBooking(aCoord, this);
            form.Show();
            //hide current form
            this.Hide();
        }

        //call form Delete Bookings to display 
        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            FormDeleteBooking form = new FormDeleteBooking(aCoord, this);
            form.Show();
            //hide current form
            this.Hide();
        }

        //back to caller, close current form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            formAppReference.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
