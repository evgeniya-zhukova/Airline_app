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

        Rezwan Tarin
        ID: 101198704

        Farhan Mohamed Thasleem Mohamed
        ID: 101177621

        Peng Qiu
        ID: 101230649

        Evgeniya Zhukova
        ID: 101239316

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