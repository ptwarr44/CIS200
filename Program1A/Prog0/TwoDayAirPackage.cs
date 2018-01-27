// By: Patrick Warren
// Program 1A
// CIS 200-76
// Fall 2017
// Due: 9/25/2017

// File: TwoDayAirPackage.cs
// TwoDayAirPackage extends AirPackage
// Computes the cost of the package based on a Early and Saver Enumerator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
    {
    public class TwoDayAirPackage : AirPackage
        {
        //Enumerator for delivery type. Saver is a 10% discount
        public enum Delivery { Early, Saver };

        //Precondition: None
        //Postcondition: TwoDayAirPackage created with specified values
        public TwoDayAirPackage(Address originAddress, Address destAddress, double length, double width,
            double height, double weight, Delivery delivery)
            : base(originAddress, destAddress, length, width, height, weight)
            {
            DeliveryType = delivery;
            }

        //Precondition: None
        //Postcondition: DeliveryType is set and returned
        public Delivery DeliveryType
            {
            //Precondition: None
            //Postcondition: DeliveryType returned
            get;
            //Precondition: None
            //Postcondition: Specified value is set.
            set;
            }

        //Precondition: Nothing is empty
        //Postconditon: Calculate Cost for TwoDayAirPackage returned. 
        //              If Saver, base cost will be multiplied by .90
        public override decimal CalcCost()
            {
            const decimal SAVER_CALC = .90M; //Used for the Saver value
            const double WEIGHT_SIZE_CHARGE = .25; //Used for both weight and size
            const double DIM_FACTOR = .40; //Dimension factor
            const double WEIGHT_FACTOR = .30; //Weight factor

            //Saver will be 90% of the base cost, else base cost.
            if (DeliveryType == Delivery.Saver)
                {
                return (SAVER_CALC * ((decimal)(DIM_FACTOR * (WEIGHT_SIZE_CHARGE * (Length + Width + Height))
                    + WEIGHT_FACTOR * (WEIGHT_SIZE_CHARGE * Weight))));
                }
            else 
                {
                return ((decimal)(DIM_FACTOR * (WEIGHT_SIZE_CHARGE * (Length + Width + Height))
                    + WEIGHT_FACTOR * (WEIGHT_SIZE_CHARGE * Weight)));
                }
            }

        //Precondition: None
        //Postcondition: TwoDayAirPackage will be returned as a formatted string
        public override string ToString()
            {
            String NL = Environment.NewLine;
            return $"Two Day Air Package" +
                $"{NL}{base.ToString()}" +
                $"{NL}Delivery Type: {DeliveryType}" +
                $"{(DeliveryType == Delivery.Saver ? " - 10% Discount on Total Cost!" : " - No Discount")}" +
                $"{NL}Cost: {CalcCost():C}";
            }
        }
    }
