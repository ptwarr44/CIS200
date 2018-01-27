// By Patrick Warren
// Program 1A
// CIS 200-76
// Fall 2017
// Due: 9/25/2017

// File: GroundPackage.cs
//GroundPackage extends Package and returns a formatted string with
//cost based on the values of the package.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
    {
    public class GroundPackage : Package
        {
        public GroundPackage(Address originAddress, Address destAddress, double length,
            double width, double height, double weight)
            : base (originAddress, destAddress, length, width, height, weight)
            {}

        //Copied from Prog4 V2 per Dr. Wright's instructions
        public int ZoneDistance
            {
            // Precondition:  None
            // Postcondition: The ground package's zone distance is returned.
            //                The zone distance is the positive difference between the
            //                first digit of the origin zip code and the first
            //                digit of the destination zip code.
            get
                {
                const int FIRST_DIGIT_FACTOR = 10000; // Denominator to extract 1st digit
                int diff;                             // Calculated zone difference

                diff = (OriginAddress.Zip / FIRST_DIGIT_FACTOR) - (DestinationAddress.Zip / FIRST_DIGIT_FACTOR);

                return Math.Abs(diff); // Absolute value in case negative
                }
            }
        //Precondition: None
        //Postcondition: GroundPackage cost returned
        public override decimal CalcCost()
            {
            const double DIM_FACTOR = .20;   // Dimension coefficient in cost equation
            const double WEIGHT_FACTOR = .5; // Weight coefficient in cost equation

            return (decimal)(DIM_FACTOR * (Length + Width + Height) + WEIGHT_FACTOR * (ZoneDistance + 1) * Weight);
            }

        //Precondition: None
        //Postcondition: String with GroundPackage data returned
        public override String ToString()
            {
            string NL = Environment.NewLine; //Used to create a new line

            return $"Ground Package{NL}{base.ToString()}" +
                $"Cost: {CalcCost():C}";
            }
        }
    }
