// By: Patrick Warren
// Program 1A
// CIS 200-76
// Fall 2017
// Due: 9/25/2017

// File: Program.cs
// Test program for the Parcel/Package hierarchy.
// GroundPackage, NextDayAirPackage, and TwoDayAirPackage all tested.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ", 
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", 
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321", 
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            
            Letter l1 = new Letter(a1, a3, 0.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.20M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.70M); // Test Letter 3

            
            //Program 1A Test Data
            GroundPackage gp1 = new GroundPackage(a1, a3, 3, 5, 6.9, 7);
            NextDayAirPackage ndap1 = new NextDayAirPackage(a2, a4, 100, 40, 40, 40, 5);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a3, a1, 40, 40.6, 40, 75, 20);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a3, a4, 40, 40, 40, 40, TwoDayAirPackage.Delivery.Saver);
            //Same as tdap1 except it will be Early. 
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a3, a4, 40, 40, 40, 40, TwoDayAirPackage.Delivery.Early);

            List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            Parcel[] parcel = new Parcel[5] { gp1, ndap1, ndap2, tdap1, tdap2 };
            foreach (var p in parcel)
                {
                Console.WriteLine($"Parcel: {p.ToString()}");
                Console.WriteLine("--------------------");
                }
                

            // Add test data to list
            //parcels.Add(l1);
            //parcels.Add(l2);
            //parcels.Add(l3);
            //parcels.Add(gp1);
            //parcels.Add(ndap1);
            //parcels.Add(ndap2);
            //parcels.Add(tdap1);
            //parcels.Add(tdap2);

            //// Display data
            //Console.WriteLine("Program 0 - List of Parcels\n");

            //foreach (Parcel p in parcels)
            //{
            //    Console.WriteLine(p);
            //    Console.WriteLine("--------------------");
            //}
        }
    }
}
