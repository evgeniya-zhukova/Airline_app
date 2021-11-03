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
    public partial class FormViewCustomer : Form
    {
        AirlineCoordinator aCoord;

        //this variable will be used to remember from where was called this form
        FormMenuCustomer formMenuCustReference;

        //constructor
        public FormViewCustomer()
        {
            InitializeComponent();
        }

        //constructor
        public FormViewCustomer(AirlineCoordinator aCoord, FormMenuCustomer callerRefValue)
        {
            InitializeComponent();
            this.aCoord = aCoord;
            formMenuCustReference = callerRefValue;
            for (int i = 1; i <= aCoord.getMaxCustomers(); i++)
            {
                if (aCoord.customerExistCheck(i))
                {
                    string result = aCoord.customerList(i); ;
                    dataGridView1.Rows.Add(result);
                }
            }
        }

        //back to caller, close current form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            formMenuCustReference.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
