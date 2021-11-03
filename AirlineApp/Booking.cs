using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineApp
{
    class Booking
    {
        private int bookingId;
        private string date;
        private Flight f;
        private Customer c;

        //constructor
        public Booking(int bn, Flight fid, Customer cid)
        {
            bookingId = bn;
            date = DateTime.Now.ToString(@"MM\/dd\/yyyy");
            this.f = fid;
            this.c = cid;
        }

        //getters
        public int getBookingId() { return bookingId; }
        public string getDate() { return date; }

        //print information about a booking
        public string toString()
        {
            string s = bookingId + ", date " + date + " " + f.toString();
            return s;
        }
    }
}
