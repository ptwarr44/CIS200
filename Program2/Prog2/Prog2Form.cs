/* Patrick Warren
 * Program 2
 * CIS 200-76
 * Due: 10/23/2017
 * 
 * Main form for Program 2. This will let you select an about menu, exit, insert address and parcel
 * and list the address and parcel. Will show a running total at the bottom of parcel list
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private UserParcelView upv; //Will hold all addresses and parcels

        //Precondition: None
        //Postcondition: Program runs and initializes all addresses and parcels
        public Prog2Form()
        {
            InitializeComponent(); 

            upv = new UserParcelView(); //Instantiate UserParcelView
            
            // Test Data - Magic Numbers OK
            upv.AddAddress("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            upv.AddAddress("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90222); // Test Address 2
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            upv.AddAddress("Patrick Warren", "8431 Easton Commons Dr", "Apt. B",
                "Louisville", "Ky", 40242); //Test Address 5
            upv.AddAddress("Stan Lee", "9440 Santa Monica Blvd", "Suite 620",
                 "Beveryly Hills", "CA", 90210); //Test Address 6
            upv.AddAddress("Eric McDowell", "2940 Yorkshire Blvd", "Louisville",
                "Ky", 40220);
            upv.AddAddress("Harry Potter", "123 6th St.", "Melbourne",
                "FL", 32904);

            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(1), 4.95M);                            // Letter test object
            upv.AddGroundPackage(upv.AddressAt(2), upv.AddressAt(3), 14, 10, 5, 14.5);        // Ground test object
            upv.AddNextDayAirPackage(upv.AddressAt(0), upv.AddressAt(2), 25, 15, 15,    // Next Day test object
                90, 8.50M);
            upv.AddTwoDayAirPackage(upv.AddressAt(3), upv.AddressAt(0), 46.5, 39.5, 28.0, // Two Day test object
                130, TwoDayAirPackage.Delivery.Saver);
            upv.AddLetter(upv.AddressAt(4), upv.AddressAt(5), 3.95M);                            // Letter test object
            upv.AddGroundPackage(upv.AddressAt(6), upv.AddressAt(7), 14, 10, 5, 12.5);        // Ground test object
            upv.AddNextDayAirPackage(upv.AddressAt(4), upv.AddressAt(6), 25, 15, 15,    // Next Day test object
                100.5, 7.50M);
            upv.AddTwoDayAirPackage(upv.AddressAt(7), upv.AddressAt(4), 46.5, 39.5, 28.0, // Two Day test object
                95, TwoDayAirPackage.Delivery.Saver);

            }

        //Precondition: None
        //Postcondition: Shows the about page
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
            {
            string NL = Environment.NewLine;
            MessageBox.Show($"Program 2{NL}Student: Patrick Warren{NL}Class: CIS200-76{NL}Due: 10/23/2017");
            }

        //Precondition: None
        //Postcondition: Shows form for and creates address 
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
            {

            AddressForm afrm = new AddressForm();

            DialogResult result = afrm.ShowDialog(); //Shows address dialog box

            if (result == DialogResult.OK)
                {
                upv.AddAddress(afrm.NameValue, afrm.AddressOne, afrm.AddressTwo, afrm.City, afrm.StateIndex, afrm.Zip);
                }

            afrm.Dispose(); //Resources are released

            }

        //Precondition: Origin address, destination address, and fixed cost must have values
        //Postconditon: Shows form and creates a letter
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
            {
            LetterForm lfrm = new LetterForm(upv.AddressList); //New LetterForm object

            DialogResult result = lfrm.ShowDialog();

            if (result == DialogResult.OK)
                {
                upv.AddLetter(upv.AddressAt(lfrm.OriginValue), upv.AddressAt(lfrm.DestValue),
                   decimal.Parse(lfrm.FixedCost));
                }
            lfrm.Dispose();
            }

        //Precondition: None
        //Postcondition: Form is closed
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        //Precondition: List address is clicked
        //Postcondition: List of addresses is displayed
        private void listAddress_Click(object sender, EventArgs e)
            {
            StringBuilder result = new StringBuilder(); //Will hold the addresses for viewing

            string NL = Environment.NewLine; //Creates new lines

            //For each address, display it's contents.
            foreach (Address address in upv.addresses)
                result.Append($"{address}{NL}--------------------------------------------{NL}");

            repDisplay.Text = $"Addresses:{NL}{NL}{result.ToString()}";
            }

        //Precondition: List parcel button is clicked
        //Postcondition: List of parcels is displayed
        private void listParcel_Click(object sender, EventArgs e)
            {
            StringBuilder result = new StringBuilder(); //Will hold the parcels for viewing
            decimal totalCost = 0; //Running total of parcel costs

            string NL = Environment.NewLine; // Creates new lines

            //For each parcel, display its contents
            foreach (Parcel parcel in upv.parcels)
                result.Append($"{parcel}{NL}--------------------------------------------{NL}");
            for (int count = 0; count < upv.parcels.Count; count++)
                totalCost += upv.parcels[count].CalcCost();

            repDisplay.Text = $"Parcels:{NL}{NL}{result.ToString()}{NL}Total Cost: {totalCost:C2}";
            }
        }
}
