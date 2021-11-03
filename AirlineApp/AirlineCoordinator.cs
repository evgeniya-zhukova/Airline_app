using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineApp
{
    public class AirlineCoordinator
    {
        FlightManager flManager;
        CustomerManager custManager;
        BookingManager bkManager;

        //constructor
        public AirlineCoordinator(int custIdSeed, int flIdSeed, int bkId, int maxCust, int maxFlights, int maxBooking)
        {
            flManager = new FlightManager(flIdSeed, maxFlights);
            custManager = new CustomerManager(custIdSeed, maxCust);
            bkManager = new BookingManager(bkId, maxBooking);
        }

        public bool addFlight(string origin, string destination, int maxSeats)
        {
            return flManager.addFlight(origin, destination, maxSeats);
        }

        public bool addCustomer(string fname, string lname, string phone)
        {
            return custManager.addCustomer(fname, lname, phone);
        }

        public bool addBooking(int fid, int cid)
        {
            return bkManager.addBooking(flManager.getFlight(fid), custManager.getCustomer(cid));
        }

        public bool addPassenger(int fid, int cid)
        {
            return flManager.addPasseng(fid, custManager.getCustomer(cid));
        }

        public string flightList(int id)
        {
            return flManager.getFlightList(id);
        }

        public string customerList(int id)
        {
            return custManager.getCustomerList(id);
        }

        public string bookingList(int id)
        {
            return bkManager.getBookingList(id);
        }

        public bool deleteCustomer(int id)
        {
            return custManager.deleteCustomer(id);
        }

        public bool deleteFlight(int fid)
        {
            return flManager.deleteFlight(fid);
        }

        public bool deleteBooking(int fid)
        {
            return bkManager.deleteBooking(fid);
        }

        public bool customerExistCheck(int id)
        {
            return custManager.customerExist(id);
        }

        public bool flightExistCheck(int id)
        {
            return flManager.flightExists(id);
        }

        public bool bookingExistCheck(int id)
        {
            return bkManager.bookingExists(id);
        }

        public string viewParticularFlight(int id)
        {
            return flManager.getParticularFlight(id);
        }

        public int getEmptySeats(int fid)
        {
            return flManager.getAvailableSeats(fid);
        }

        public int getMaxFlights()
        {
            return flManager.getMaxFlight();
        }

        public int getMaxCustomers()
        {
            return custManager.getMaxCustomer();
        }

        public int getMaxBookings()
        {
            return bkManager.getMaxBooking();
        }
    }
}
