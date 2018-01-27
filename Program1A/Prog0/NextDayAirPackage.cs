// By: Patrick Warren
// Program 1A
// CIS 200-76
// Fall 2017
// Due: 9/25/2017

// File: NextDayAirPackage.cs
// NextDayAirPackage extends AirPackage and computes the cost of the 
// package with an express fee. Express fee is hard-coded


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
    {
    public class NextDayAirPackage : AirPackage
        {
        private decimal _expressFee; //Backing field

        //Precondition: None
        //Postconditon: All fields for NextDayAirPackage returned
        public NextDayAirPackage(Address originAddress, Address destAddress, double length,
            double width, double height, double weight, decimal expressFee)
            : base(originAddress, destAddress, length, width, height, weight)
            {
            _expressFee = expressFee;
            }

        //Precondition: Not empty and non-negative
        //Postcondition: Express Fee returned
        public decimal ExpressFee
            {
            get
                {
                if (_expressFee >= 0)
                    return _expressFee;
                else
                    throw new ArgumentOutOfRangeException("Express Fee", _expressFee, "Must be non-negative.");
                }
            }

        //Precondition: None
        //Postcondition: NextDayAirPackage cost returned
        public override decimal CalcCost()
            {
            const double WEIGHT_SIZE_CHARGE = .25; //Used for both weight and size
            const double DIM_FACTOR = .40; //Dimension factor
            const double WEIGHT_FACTOR = .30; //Weight factor

            //If-Else to determine if there should be a weight/size charge based on 
            //if the package is heavy and/or large
            if (this.IsHeavy() == false && this.IsLarge() == false)
                return ((decimal)(DIM_FACTOR * (Length + Width + Height) + WEIGHT_FACTOR * Weight) + ExpressFee);
            else if (this.IsHeavy() == true && this.IsLarge() == false)
                {
                return ((decimal)(DIM_FACTOR * (Length + Width + Height) + WEIGHT_FACTOR * 
                    (WEIGHT_SIZE_CHARGE * Weight)) + ExpressFee);
                }
            else if (this.IsHeavy() == false && this.IsLarge() == true)
                {
                return ((decimal)(DIM_FACTOR * (WEIGHT_SIZE_CHARGE *(Length + Width + Height)) 
                    + WEIGHT_FACTOR * Weight) + ExpressFee);
                }
            else
                return ((decimal)(DIM_FACTOR * (WEIGHT_SIZE_CHARGE * (Length + Width + Height))
                    + WEIGHT_FACTOR * (WEIGHT_SIZE_CHARGE * Weight)) + ExpressFee);
            }

        //Precondition: None
        //Postcondition: NextDayAirPackage values returned as a string
        public override String ToString()
            {
            string NL = Environment.NewLine;
            return $"Next Day Air Package{base.ToString()}{NL}" +
                $"Express Fee: {ExpressFee:C} (Already added to Cost)" +
                $"{NL}Cost: {CalcCost():C}";
            }
        }
    }
