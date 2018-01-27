/* Patrick Warren
 * Program0
 * Due: 09/11/17
 * Section: CIS 200-76
 * 
 * Program uses three classes (so far) - Address, Parcel, and Letter. It will take in two addresses
 * and calculate how much a letter will cost to send it (hard coded value for now). If the 2nd address 
 * is not present, the line will be null on return. Printed to Console.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
    {
    class Program
        {
        static void Main()
            {
            //All address objects (4 total)
            //2nd address missing
            Address address1 = new Address("Patrick Warren", "3132 Hunsinger BLVD", "Louisville", "KY", 40220);
            //2nd address present
            Address address2 = new Address("Emily Rixman", "8431 Easton Commons Dr", "Apt. B", "Louisville", "KY", 40242); 
            //2nd address missing
            Address address3 = new Address("Andrew Wright", "1111 Newfound Way", "Louisville", "KY", 304);
            //2nd address present
            Address address4 = new Address("Rob Barker", "2234 Holiday Inn Ct", "Room 241", "New York", "NY", 2);
            //2nd address missing
            Address address5 = new Address("Kenneth Clark", "12345 Westport Rd", "New York", "NY", 0);

            //All letter objects (3 total)
            Letter letter1 = new Letter(address1, address2, 5);
            Letter letter2 = new Letter(address3, address4, 10);
            Letter letter3 = new Letter(address4, address1, 30.5M);
            Letter letter4 = new Letter(address5, address3, 10.4567M); //Price should round to nearest 0.

            //New Parcel List to hold all Letters
            List<Parcel> list = new List<Parcel>();
            list.Add(letter1);
            list.Add(letter2);
            list.Add(letter3);
            list.Add(letter4);


            //Output List to console
            list.ForEach(Console.WriteLine);
            }
        }
    }
