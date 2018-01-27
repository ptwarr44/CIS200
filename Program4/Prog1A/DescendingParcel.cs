// By: Patrick Warren
// Program 4
// CIS 200-76
// Fall 2017
// Due: 11/27/2017
//
// This class will allow a list of Parcels to be sorted in descending order

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
    {
    public class DescendingParcel : IComparer<Parcel>
        {
        //Precondition: None
        //Postcondition:  When p1 < p2, method returns positive #
        //                When p1 == p2, method returns zero
        //                When p1 > p2, method returns negative #
        public int Compare(Parcel p1, Parcel p2)
            {
            if (p1 == null && p2 == null)
                return 0;

            if (p1 == null)
                return -1;

            if (p2 == null)
                return 1;

            //Return the list in descending order
            return (-1)*(p1.DestinationAddress.Zip).CompareTo(p2.DestinationAddress.Zip);

            }
        }
    }
