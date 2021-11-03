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
    public partial class FormDeleteCustomer : Form
    {
        AirlineCoordinator aCoord;

        //this variable will be used to remember from where was called this form
        FormMenuCustomer form2Reference;

        //constructor
        public FormDeleteCustomer()
        {
            InitializeComponent();
        }

        //constructor
        public FormDeleteCustomer(AirlineCoordinator aCoord, FormMenuCustomer callerRefValue)
        {
            InitializeComponent();
            this.aCoord = aCoord;
            form2Reference = callerRefValue;
            for (int i = 1; i <= aCoord.getMaxCustomers(); i++)
            {
                if (aCoord.customerExistCheck(i))
                {
                    string result = aCoord.customerList(i); ;
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
                label3.Text = "Please enter a valid choice.";
            }
            //delete customer
            else if (aCoord.deleteCustomer(id))
            {
                label3.Text = "Customer with id " + id + " was deleted successfully.";
                dataGridView1.Rows.Clear();
                for (int i = 1; i <= aCoord.getMaxCustomers(); i++)
                {
                    if (aCoord.customerExistCheck(i))
                    {
                        string result = aCoord.customerList(i); ;
                        dataGridView1.Rows.Add(result);
                    }
                }
            }
            else
            {
                label3.Text = "Customer with id " + id + " was not found.";
            }
        }

        //button Clear ID
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            label3.Text = "";
        }

        //back to caller, close current form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            form2Reference.Show();
            this.Close();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
