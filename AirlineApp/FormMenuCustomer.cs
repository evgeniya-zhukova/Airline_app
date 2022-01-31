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
    public partial class FormMenuCustomer : Form
    {
        AirlineCoordinator aCoord;

        //this variable will be used to remember from where was called this form
        FormAirlineApp formAppReference;

        //constructor
        public FormMenuCustomer()
        {
            InitializeComponent();
        }

        //constructor
        public FormMenuCustomer(AirlineCoordinator aCoord, FormAirlineApp callerRefValue)
        {
            InitializeComponent();
            this.aCoord = aCoord;
            formAppReference = callerRefValue;
        }

        //call form Add Customer to display 
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            FormAddCustomer form = new FormAddCustomer(aCoord, this);
            form.Show();
            //hide current form
            this.Hide();
        }

        //call form View Customers to display
        private void buttonViewCustomers_Click(object sender, EventArgs e)
        { 
            FormViewCustomer form = new FormViewCustomer(aCoord, this);
            form.Show();
            //hide current form
            this.Hide();
        }

        //call form Delete Customers to display
        private void buttonDeleteCustomers_Click(object sender, EventArgs e)
        {
            FormDeleteCustomer form = new FormDeleteCustomer(aCoord, this);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
