using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineApp
{
    static class Program
    {

        /*
        
        Team:
        Rezwan Tarin
        Farhan Mohamed Thasleem Mohamed
        Peng Qiu
        Evgeniya Zhukova

        */

        [STAThread]
        static void Main()
        {
            AirlineCoordinator aCoord = new AirlineCoordinator(1, 1, 1, 30, 10, 50);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAirlineApp(aCoord));
        }
    }
}