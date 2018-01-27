// By: Patrick Warren
// Program 4
// CIS 200-76
// Fall 2017
// Due: 11/27/2017
//
// This class will allow a list of Parcels to be sorted in ascending order by type
// Then sorted in ascending order by Cost within the group.
// It will display all packages ordered in their respective groups

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
    {
    public class AscTypeDescCost : IComparer<Parcel>
        {
        //Precondition: None
        //Postcondition:  When p1 < p2, method returns positive #
        //                When p1 == p2, method returns zero
        //                When p1 > p2, method returns negative #
        public int Compare(Parcel p1, Parcel p2)
            {

            string parcelType1; //Holds the type of type1
            string parcelType2; //Hols the type of type2

            if (p1 == null && p2 == null)
                return 0;

            if (p1 == null)
                return -1;

            if (p2 == null)
                return 1;

            parcelType1 = p1.GetType().ToString(); //Let p1 equal type1
            parcelType2 = p2.GetType().ToString(); //Let p2 equal type2

            //Compare the costs of the types
            if (parcelType1 == parcelType2)
                return (p1.CalcCost()).CompareTo(p2.CalcCost());

            //Return the smaller of the two types
            return parcelType1.CompareTo(parcelType2);
            }
        }
    }
