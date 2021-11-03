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
    public partial class FormViewParticularFlight : Form
    {

        AirlineCoordinator aCoord;

        //this variable will be used to remember from where was called this form
        FormMenuFlight formMenuFlighrReference;

        //constructor
        public FormViewParticularFlight()
        {
            InitializeComponent();
        }

        //constructor 
        public FormViewParticularFlight(AirlineCoordinator aCoord, FormMenuFlight callerRefValue)
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

        //button Submit
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int id;
            //check if input not integer
            if (!int.TryParse(textBox2.Text, out id))
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Rows.Add("Please enter a valid choice.");
            }
            //check if flight exist
            else if (aCoord.flightExistCheck(id))
            {
                    dataGridView2.Rows.Clear();
                    string result = aCoord.viewParticularFlight(id); 
                    dataGridView2.Rows.Add(result);
            }
            else
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Rows.Add("The flight does not exist.");
            }
        }

        //button Clear ID
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            dataGridView2.Rows.Clear();
        }

        //back to caller, close current form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            formMenuFlighrReference.Show();
            this.Close();
        }

        private void ViewParticularFlightForm_Load(object sender, EventArgs e)
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
