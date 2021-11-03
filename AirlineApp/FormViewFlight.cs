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
    public partial class FormViewFlight : Form
    {

        AirlineCoordinator aCoord;

        //this variable will be used to remember from where was called this form
        FormMenuFlight formMenuFlighrReference;

        //constructor
        public FormViewFlight()
        {
            InitializeComponent();
        }

        //constructor
        public FormViewFlight(AirlineCoordinator aCoord, FormMenuFlight callerRefValue)
        {
            InitializeComponent();
            this.aCoord = aCoord;
            formMenuFlighrReference = callerRefValue;
            for (int i = 1; i <= aCoord.getMaxFlights(); i++) {
                if (aCoord.flightExistCheck(i))
                {
                    string result = aCoord.flightList(i); ;
                    dataGridView1.Rows.Add(result);
                }
            }
        }

        //back to caller, close current form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            formMenuFlighrReference.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
