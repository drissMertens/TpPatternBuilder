using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpPatternBuilder;

namespace TpPatternBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Technicien technicien = new Technicien();
            MonteurTour monteurTour1 = new MonteurTour1();
            MonteurTour monteurTour2 = new MonteurTour2();

            technicien.setMonteurTour(monteurTour1);
            technicien.construireTour();

            Tour tour = technicien.getTour();

            tour.Informations();

            Console.ReadKey();
        }
    }
}