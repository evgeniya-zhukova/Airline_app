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
    public partial class FormViewBooking : Form
    {
        AirlineCoordinator aCoord;

        //this variable will be used to remember from where was called this form
        FormMenuBooking formMenuBookReference;

        //constructor
        public FormViewBooking()
        {
            InitializeComponent();
        }

        //constructor
        public FormViewBooking(AirlineCoordinator aCoord, FormMenuBooking callerRefValue)
        {
            InitializeComponent();
            this.aCoord = aCoord;
            formMenuBookReference = callerRefValue;
            for (int i = 1; i <= aCoord.getMaxBookings(); i++)
            {
                if (aCoord.bookingExistCheck(i))
                {
                    string result = aCoord.bookingList(i); ;
                    dataGridView1.Rows.Add(result);
                }
            }
        }

        //back to caller, close current form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            formMenuBookReference.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
