// By: Patrick Warren
// Program 1A
// CIS 200-76
// Fall 2017
// Due: 9/25/2017

// File: AirPackage.cs
// AirPackage is the base class for all air packages
// Asks whethere the package is heavy or not. Calculate extra cost if yes to either and/or both
// AirPackage is an abstract class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
    {
    public abstract class AirPackage : Package
        {
        //Precondition: None
        //Postcondition: AirPackage created with specified values origin address
        //               destination address, length, width, height, and weight
        public AirPackage(Address originAddress, Address destAddress, double length,
            double width, double height, double weight)
            : base(originAddress, destAddress, length, width, height, weight)
            {

            }

        //Precondition: Weight is not empty
        //Postcondition: Determines if the package is heavy
        public bool IsHeavy()
            {
            if (Weight >= 75)
                return true;
            else
                return false;
            }

        //Precondition: Length, Width, and Height are not empty
        //Postcondition: Determines if the package is large
        public bool IsLarge()
            {
            if ((Length + Width + Height) >= 100)
                return true;
            else
                return false;
            }

        //Precondition: None
        //Postcondition: Returns the AirPackage as a string
        public override String ToString()
            {
            string NL = Environment.NewLine; //Used to create a new line

            return $"{NL}{base.ToString()}" +
                $"{NL}{NL}Is the package heavy? {IsHeavy()}" +
                $"{NL}Is the package large? {IsLarge()}";

            }
        }
    }
