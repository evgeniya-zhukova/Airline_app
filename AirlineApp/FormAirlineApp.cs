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
    public partial class FormAirlineApp : Form
    {
        AirlineCoordinator aCoord;

        //constructor
        public FormAirlineApp()
        {
            InitializeComponent();
        }

        //constructor
        public FormAirlineApp(AirlineCoordinator aCoord)
        {
            this.aCoord = aCoord;
            InitializeComponent();
        }

        //call Customer Menu to display 
        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            FormMenuCustomer form = new FormMenuCustomer(aCoord, this);
            form.Show();
        }

        //call Flight Menu to display
        private void buttonFlights_Click(object sender, EventArgs e)
        { 
            FormMenuFlight form = new FormMenuFlight(aCoord, this);
            form.Show();
        }

        //call Booking Menu to display
        private void buttonBookings_Click(object sender, EventArgs e)
        { 
            FormMenuBooking form = new FormMenuBooking(aCoord, this);
            form.Show();
        }

        //buton Exit
        private void buttonExit_Click(object sender, EventArgs e)
        {
            //closes current form
            this.Close(); 
            //terminates application
            Application.Exit(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}