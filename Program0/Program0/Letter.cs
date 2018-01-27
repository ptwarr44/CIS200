using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
    {
    public class Letter : Parcel
        {
        //Backing fields
        public Address _oAddress;
        public Address _dAddress;
        public decimal _fixedCost; //Holds fixed cost of letter

        //Precondition: None
        //Postcondition: Letter object is set
        public Letter(Address oAddress, Address dAddress, decimal fixedCost)
            : base(oAddress, dAddress)
            {
            FixedCost = fixedCost;
            }


        private decimal FixedCost
            {
            //Precondition: None
            //Postcondition: Fixed Cost of letter returned
            get { return _fixedCost; }

            //Precondition: value > 0
            //Postcondition: Fixed Cost is set to value
            set
                {
                if (value > 0)
                    _fixedCost = value;
                else
                    throw new ArgumentOutOfRangeException("Please enter a fixed cost greater than 0");
                }
            }

        //Precondition: Fixed cost entered is valid
        //Postcondition: Fixed cost is calculated
        public override decimal CalcCost() => FixedCost;

        //Precondition: None
        //Postcondition: ToString method for Letter objects returned
        public override string ToString() =>
            $"{base.ToString()}" +
            $"Letter Total Cost: {FixedCost:C2}" + Environment.NewLine +
            $"--------------------" + Environment.NewLine;
        }


    }
