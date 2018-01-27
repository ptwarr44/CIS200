using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
    {
    public class Address
        {
        //Backing fields
        private string _name; //Holds the name for the package destination
        private string _addressOne; //Address line 1
        private string _addressTwo; //Address line 2
        private string _city; //Holds the city
        private string _state; //Holds the state
        private int _zipCode; //This will hold the destination zip code

        //Validation fields for zip code
        private const int MIN_ZIP = 00000; //Min zip code
        private const int MAX_ZIP = 99999; //Max zip code

        //Precondition: none
        //Postcondition: The Address will be set with Address2 as a empty string
        public Address(string name, string addressOne, string city, string state, int zipCode)
            : this(name, addressOne, "", city, state, zipCode)
            { }

        //Precondition: None
        //Postcondition: Address will be set
        public Address(string name, string addressOne, string addressTwo, string city, string state, int zipCode)
            {
            Name = name;
            Address1 = addressOne;
            Address2 = addressTwo;
            City = city;
            State = state;
            Zip = zipCode;
            }

        public string Name
            {
            //Precondition: None
            //Postcondition: Name will be returned
            get { return _name; }
            //Precondition: Name must not be empty
            //Postcondition: Name set to specified value
            set
                {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Valid name must be given.", "name");
                else
                    _name = value;
                }
            }
        public string Address1
            {
            //Precondition: None
            //Postcondition: Address 1 will be returned
            get { return _addressOne; }

            //Precondition: Address 1 should not be empty
            //Postcondition: Address 1 set to specified value
            set
                {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Address should not be empty.", "address");
                else
                    _addressOne = value;
                }
            }
        public string Address2
            {
            //Precondition: None
            //Postcondition: Address 2 will be returned
            get { return _addressTwo; }

            //Precondition: Address 2 is optional. Can either be filled in or not.
            //Postcondition: Address 2 set to specified value
            set
                {
                _addressTwo = value;
                }
            }
        public string City
            {
            //Precondition: None
            //Postcondition: City will be returned
            get { return _city; }

            //Precondition: City should not be empty
            //Postcondition: City set to specified value
            set
                {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("City should not be empty.", "city");
                else
                    _city = value;
                }
            }
        public string State
            {
            //Precondition: None
            //Postcondition: City will be returned
            get { return _state; }

            //Precondition: City should not be empty
            //Postcondition: City set to specified value
            set
                {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("State should not be empty.", "state");
                else
                    _state = value;
                }
            }

        public int Zip
            {
            //Precondition: None
            //Postcondition: Zipcode will be returned
            get { return _zipCode; }

            //Precondition: MIN_ZIP <= value <= MAX_ZIP
            //Postcondition: Zipcode will be set to value
            set
                {
                if ((value < MIN_ZIP) || (value > MAX_ZIP))
                    throw new ArgumentOutOfRangeException("zipcode", "Please enter a valid Zip Code.");
                else
                    _zipCode = value;
                }
            }

        //Precondition: None
        //Postcondition: Returns the formatted string of all the values entered.
        //               Address2 will be empty if nothing is entered.
        public override string ToString() =>
            $"{Name}" + Environment.NewLine +
            $"{Address1}" + Environment.NewLine +
            $"{(string.IsNullOrWhiteSpace(Address2) ? null : (Address2 + Environment.NewLine))}" +
            $"{City}, {State} {Zip:D5}" + Environment.NewLine; //Output for ToString() : Address
        }
    }
