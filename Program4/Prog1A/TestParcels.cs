// By: Patrick Warren
// Program 4
// CIS 200-76
// Fall 2017
// Due: 11/27/2017

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

// Added in 4 more address and 6 more parcels. 
// This program will first print the list as is, then in ascending order,
// and lastly in descending order.

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
                "Beverly Hills", "CA", 90210); // Test Address 2
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

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            Letter letter2 = new Letter(a5, a6, 6M);                            // Letter test object
            GroundPackage gp2 = new GroundPackage(a8, a7, 20, 15, 10, 15.5);        // Ground test object
            NextDayAirPackage ndap2 = new NextDayAirPackage(a6, a7, 30, 20, 20,    // Next Day test object
                90, 7.50M);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a7, a5, 50, 45, 35, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            NextDayAirPackage ndap3 = new NextDayAirPackage(a2, a7, 20, 10, 10,    // Next Day test object
                80, 7.50M);
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a8, a1, 40, 35, 25, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list - 10 Parcel Objects
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);
            parcels.Add(letter2);
            parcels.Add(gp2);
            parcels.Add(ndap2);
            parcels.Add(tdap2);
            parcels.Add(ndap3);
            parcels.Add(tdap3);

            //Main list
            Console.WriteLine("Original List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            //Ascending Order
            parcels.Sort(); // sorts parcels - natural order
            Console.WriteLine("Ascending List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
                {
                Console.WriteLine(p);
                Console.WriteLine("====================");
                }
            Pause();

            //Descending list
            parcels.Sort(new DescendingParcel()); //Sort in descending order
            Console.WriteLine("Descending List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
                {
                Console.WriteLine(p);
                Console.WriteLine("====================");
                }
            Pause();

            //Ascending Type Descending Cost Order
            parcels.Sort(new AscTypeDescCost()); // Sort parcels first in ascending order by type.
                                                 // Then sort in descending order by cost
            Console.WriteLine("Ascending Type Descending Cost:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
                {
                Console.WriteLine(p);
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
