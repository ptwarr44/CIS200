// By: Patrick Warren
// Program 1B
// CIS 200-76
// Fall 2017
// Due: 10/4/2017

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

// For Program 1B, we explore the use of LINQ queries to sort the list of parcels in different ways.
// Each query will have it's own page, including the original printed list.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90222); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Patrick Warren", "8431 Easton Commons Dr", "Apt. B",
                "Louisville", "Ky", 40242); //Test Address 5
            Address a6 = new Address("Stan Lee", "9440 Santa Monica Blvd", "Suite 620",
                 "Beveryly Hills", "CA", 90210); //Test Address 6
            Address a7 = new Address("Eric McDowell", "2940 Yorkshire Blvd", "Louisville",
                "Ky", 40220);
            Address a8 = new Address("Harry Potter", "123 6th St.", "Melbourne",
                "FL", 32904);

            Letter letter1 = new Letter(a1, a2, 4.95M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 14.5);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                90, 8.50M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                130, TwoDayAirPackage.Delivery.Saver);
            Letter letter2 = new Letter(a5, a6, 3.95M);                            // Letter test object
            GroundPackage gp2 = new GroundPackage(a7, a8, 14, 10, 5, 12.5);        // Ground test object
            NextDayAirPackage ndap2 = new NextDayAirPackage(a5, a7, 25, 15, 15,    // Next Day test object
                100.5, 7.50M);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a8, a5, 46.5, 39.5, 28.0, // Two Day test object
                95, TwoDayAirPackage.Delivery.Saver);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);
            parcels.Add(letter2); // Populate list
            parcels.Add(gp2);
            parcels.Add(ndap2);
            parcels.Add(tdap2);

            Console.WriteLine("Original List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
                {
                Console.WriteLine(p);
                Console.WriteLine("====================");
                }
            Pause();

            //Sort the list of Parcels in descending or by Destination Zip
            var destZipDesc =
                from parcel in parcels
                orderby parcel.DestinationAddress.Zip descending
                select parcel;

            //Print list
            Console.WriteLine("Destination Zip Descending List:");
            Console.WriteLine("====================");
            foreach (Parcel parcel in destZipDesc)
                {
                Console.WriteLine(parcel);
                Console.WriteLine("====================");
                }
            Pause();

            //Sort the list of Parcels by cost (ascending)
            var costAsc =
                from parcel in parcels
                orderby parcel.CalcCost() ascending
                select parcel;

            //Print list
            Console.WriteLine("Cost Ascending List:");
            Console.WriteLine("====================");
            foreach (Parcel parcel in costAsc)
                {
                Console.WriteLine(parcel);
                Console.WriteLine("====================");
                }
            Pause();

            //Sort list of Parcels by type (ascending), then cost (descending)
            var parcelTypeCost =
                from parcel in parcels
                orderby parcel.GetType().ToString() ascending, parcel.CalcCost() descending
                select parcel;

            //Print list
            Console.WriteLine("Cost Ascending List:");
            Console.WriteLine("====================");
            foreach (Parcel parcel in parcelTypeCost)
                {
                Console.WriteLine(parcel);
                Console.WriteLine("====================");
                }
            Pause();

            //Select all AirPackages that are heavy and sort by weight (descending)
            var isHeavyDesc =
                from parcel in parcels
                where parcel is AirPackage && ((AirPackage)parcel).IsHeavy()
                orderby ((AirPackage)parcel).Weight descending
                select parcel;

            //Print list
            Console.WriteLine("Cost Ascending List:");
            Console.WriteLine("====================");
            foreach (Parcel parcel in isHeavyDesc)
                {
                Console.WriteLine(parcel);
                Console.WriteLine("====================");
                }
            Pause();
            }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
