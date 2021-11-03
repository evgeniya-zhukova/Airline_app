using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineApp
{
    class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;
        private int bookings;

        //constructor
        public Customer(int cId, string fname, string lname, string ph)
        {
            bookings = 0;
            customerId = cId;
            firstName = fname;
            lastName = lname;
            phone = ph;
        }

        //getters
        public int getId() { return customerId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getPhone() { return phone; }
        public void setNumBookings(int numBookings) { bookings += numBookings; }
        public int getNumBookings() { return bookings; }

        //print information about a customer
        public string toString()
        {
            string s = " id: " + customerId;
            s = s + " Name: " + firstName + " " + lastName;
            s = s + " Phone: " + phone;
            s = s + " Bookings: " + bookings;

            return s;
        }
    }
}
