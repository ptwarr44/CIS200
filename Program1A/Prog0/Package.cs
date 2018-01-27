// By: Patrick Warren
// Program 1A
// CIS 200-76
// Fall 2017
// Due: 9/25/2017

// File: Package.cs
// Package.cs is the base class for all packges
// Takes in two addresses, a length, width, height, and weight
// Package is an abstract class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
    {
    public abstract class Package : Parcel
        {
        //Backing fields
        private double _length;
        private double _width;
        private double _height;
        private double _weight;

        //Precondition: None
        //Postcondition: Package created with the specified values for origin address,
        //               destination address, length, width, height, and weight
        public Package(Address originAddress, Address destAddress, double length, double width,
            double height, double weight)
            : base(originAddress, destAddress)
            {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
            }

        public double Length //Length Property
            {
            //Precondition: None
            //Postcondition: Length will be returned
            get { return _length; }

            //Precondition: Length must be a positive double and not null
            //Postcondition: value of length is set
            set
                {
                if (value > 0)
                    _length = value;
                else
                    throw new ArgumentOutOfRangeException("Package Length", value,
                        "Length must be > 0 and not null");
                }
            }

        public double Width //Width Property
            {
            //Precondition: None
            //Postconditin: Width will be returned
            get { return _width; }

            //Precondition: Width must be a positive double and not null
            //Postcondition: Width will be set to value
            set
                {
                if (value > 0)
                    _width = value;
                else
                    throw new ArgumentOutOfRangeException("Package Width", value,
                        "Width must be > 0 and not null");
                }
            }

        public double Height //Height property
            {
            //Precondition: None
            //Postcondition: Height will be returned
            get { return _height; }

            //Precondition: Height must be > 0 and not null
            //Postcondition: Height will be set to value
            set
                {
                if (value > 0)
                    _height = value;
                else
                    throw new ArgumentOutOfRangeException("Package Height", value,
                        "Height must be > 0 and not null");
                }
            }

        public double Weight //Weight property
            {
            //Precondition: None
            //Postcondition: Weight will be returned
            get { return _weight; }

            //Precondition: Weight must be > 0 and not null
            //Postcondition: Weight is set
            set
                {
                if (value > 0)
                    _weight = value;
                else
                    throw new ArgumentOutOfRangeException("Package Weight", value,
                        "Weight must be > 0 and not null");

                }
            }

        //Precondition: None
        //Postcondition: Formatted string will be returned
        public override String ToString()
            {
            string NL = Environment.NewLine; //Used for a new line

            return $"{NL}{base.ToString()}{NL}" +
                $"{NL}Dimensions:{NL}Length: {Length:N1} in(s){NL}Width: {Width:N1} in(s){NL}" +
                $"Height: {Height:N1} in(s){NL}Weight: {Weight:N1} lb(s){NL}";
            }
        }
    }
