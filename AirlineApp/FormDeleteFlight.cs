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
    public partial class FormDeleteFlight : Form
    {
        AirlineCoordinator aCoord;

        //this variable will be used to remember from where was called this form
        FormMenuFlight formMenuFlighrReference;

        //constructor
        public FormDeleteFlight()
        {
            InitializeComponent();
        }

        //constructor
        public FormDeleteFlight(AirlineCoordinator aCoord, FormMenuFlight callerRefValue)
        {
            InitializeComponent();
            this.aCoord = aCoord;
            formMenuFlighrReference = callerRefValue;
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
            label3.Text = "";
        }

        //button Submit
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int id;
            //check if input not integer
            if (!int.TryParse(textBox2.Text, out id))
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Please enter a valid choice.";
            }
            //delete flight
            else if (aCoord.deleteFlight(id))
            {
                label3.ForeColor = Color.Green;
                label3.Text = "Flight with id " + id + " deleted.";
                dataGridView1.Rows.Clear();
                for (int i = 1; i <= aCoord.getMaxFlights(); i++)
                {
                    if (aCoord.flightExistCheck(i))
                    {
                        string result = aCoord.flightList(i); ;
                        dataGridView1.Rows.Add(result);
                    }
                }
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Flight with id " + id + " was not found.";
            }
        }

        //back to caller, close current form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            formMenuFlighrReference.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DeleteFlightForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
