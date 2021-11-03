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
    public partial class FormMenuFlight : Form
    {
        AirlineCoordinator aCoord;

        //this variable will be used to remember from where was called this form
        FormAirlineApp formAppReference;

        //constructor
        public FormMenuFlight()
        {
            InitializeComponent();
        }

        //constructor
        public FormMenuFlight(AirlineCoordinator aCoord, FormAirlineApp callerRefValue)
        {
            InitializeComponent();
            this.aCoord = aCoord;
            formAppReference = callerRefValue;
        }

        //call form Add Flight to display 
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddFlight form = new FormAddFlight(aCoord, this);
            form.ShowDialog();
        }

        //call form View Flight to display 
        private void buttonView_Click(object sender, EventArgs e)
        {
            FormViewFlight form = new FormViewFlight(aCoord, this);
            form.ShowDialog();
        }

        //call form View a Particular Flight to display 
        private void buttonPartFl_Click(object sender, EventArgs e)
        {
            FormViewParticularFlight form = new FormViewParticularFlight(aCoord, this);
            form.ShowDialog();
        }

        //call form Delete Flight to display 
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            FormDeleteFlight form = new FormDeleteFlight(aCoord, this);
            form.ShowDialog();
        }

        //back to caller, close current form
        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            formAppReference.Show();
            this.Close();
        }
    }
}
