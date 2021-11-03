using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineApp
{
    class Flight
    {
        private int flightNumber;
        private string origin;
        private string destination;
        private int maxSeats;
        private int numPassengers;
        private Customer[] passengers;

        //constructor
        public Flight(int fn, string or, string dest, int mSeats)
        {
            maxSeats = mSeats;
            flightNumber = fn;
            origin = or;
            destination = dest;
            numPassengers = 0;
            passengers = new Customer[maxSeats];
        }

        //getters
        public int getFlightNumber() { return flightNumber; }
        public string getOrigin() { return origin; }
        public string getDestination() { return destination; }
        public int getMaxSeats() { return maxSeats; }
        public int getNumPassengers() { return numPassengers; }

        public bool addPassenger(Customer c)
        {
            if (numPassengers >= maxSeats) { return false; }
            passengers[numPassengers] = c;
            passengers[numPassengers].setNumBookings(1);
            numPassengers++;
            maxSeats--;
            return true;
        }

        public int findPassenger(int custId)
        {
            for (int x = 0; x < maxSeats; x++)
            {
                if (passengers[x].getId() == custId)
                    return x;
            }
            return -1;
        }

        public bool removePassenger(int custId)
        {
            int loc = findPassenger(custId);
            if (loc == -1) return false;
            passengers[loc] = passengers[numPassengers - 1];
            numPassengers--;
            maxSeats++;
            return true;
        }

        public int getAvailablSeats()
        {
            int places = getMaxSeats() - getNumPassengers();
            return places;
        }

        //print passenger list
        public string getPassengerList()
        {
            string s = "Passengers on flight: ";
            for (int x = 0; x < numPassengers; x++)
            {
                s = s + " " + passengers[x].toString();
            }
            if (numPassengers == 0)
            {
                s += "There are no passengers.";
            }
            return s;
        }

        //print information about a flight
        public string toString()
        {
            string s = " Flight Number: " + flightNumber;
            s = s + " Origin: " + origin;
            s = s + " Destination: " + destination;
            s = s + " Number of Passengers: " + numPassengers;
            s = s + " Available seats: " + maxSeats;
            s = s + getPassengerList();
            return s;
        }
    }
}
