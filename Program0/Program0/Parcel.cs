using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
    {
    public abstract class Parcel
        {
        //Backing fields - Address objects
        private Address _oAddress; //Origin Address for package
        private Address _dAddress; //Destination Address for package

        //Precondition: None
        //Postcondition: Parcel is set
        public Parcel(Address oAddress, Address dAddress)
            {
            OriginAddress = oAddress;
            DestinationAddress = dAddress;
            }

        public Address OriginAddress
            {
            //Precondition: None
            //Postcondition: Origin Address returned
            get { return _oAddress; }

            //Precondition: Address set through Address class
            //Postcondition: Address will be set to value
            set
                {
                _oAddress = value;
                }
            }
        public Address DestinationAddress
            {
            //Precondition: None
            //Postcondition: Origin Address returned
            get { return _dAddress; }

            //Precondition: Address set through Address class
            //Postcondition: Address will be set to value
            set
                {
                _dAddress = value;
                }
            }

        //Precondition: None
        //Postcondition: Parcel's cost is returned
        public abstract decimal CalcCost(); //Derived class will calculate the cost on their end

        //Precondition: None
        //Postcondition: String with the Parcel's values are returned
        public override string ToString() =>
            $"From: {OriginAddress}" + Environment.NewLine +
            $"To: {DestinationAddress}";
        }
    }
