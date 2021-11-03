using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineApp
{
    class FlightManager
    {
        private static int currentFlightNumber;
        private int maxFlights;
        private int numFlights;
        private Flight[] flightList;

        public FlightManager(int ccn, int max)
        {
            currentFlightNumber = ccn;
            maxFlights = max;
            numFlights = 0;
            flightList = new Flight[maxFlights];
        }

        //add flight to flight list
        public bool addFlight(string origin, string destination, int maxSeats)
        {
            if (numFlights >= maxFlights) { return false; }
            Flight f = new Flight(currentFlightNumber, origin, destination, maxSeats);
            currentFlightNumber++;
            flightList[numFlights] = f;
            numFlights++;
            return true;
        }

        //add passenger to flight
        public bool addPasseng(int fid, Customer cid)
        {
            return flightList[findFlight(fid)].addPassenger(cid);
        }

        public int findFlight(int fid)
        {
            for (int x = 0; x < numFlights; x++)
            {
                if (flightList[x].getFlightNumber() == fid)
                    return x;
            }
            return -1;
        }

        public bool flightExists(int fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) { return false; }
            return true;
        }

        public Flight getFlight(int fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) { return null; }
            return flightList[loc];
        }

        public bool deleteFlight(int fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) { return false; }
            flightList[loc] = flightList[numFlights - 1];
            numFlights--;
            return true;
        }

        public int getAvailableSeats(int fid)
        {
            return flightList[findFlight(fid)].getAvailablSeats();
        }

        public int getMaxFlight()
        {
            return maxFlights;
        }

        //print information about particular flight
        public string getParticularFlight(int fid)
        {
            string s = "Flight:";
            s += flightList[findFlight(fid)].getFlightNumber() + ", from " + flightList[findFlight(fid)].getOrigin() + " to " + flightList[findFlight(fid)].getDestination();
            s += " " + flightList[findFlight(fid)].getPassengerList();
            return s;
        }

        //print flight list one by one row (in purposes to use dataGridView in Forms)
        public string getFlightList(int fid)
        {
            string s = "id: ";
                s = s + flightList[findFlight(fid)].getFlightNumber() + ", from " + flightList[findFlight(fid)].getOrigin() + " to " + flightList[findFlight(fid)].getDestination();
            return s;
        }
    }
}
