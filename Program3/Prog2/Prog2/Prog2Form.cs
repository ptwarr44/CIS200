// By: Patrick Warren
// Program 3
// CIS 200-76
// Fall 2017
// Due: 11/08/2017


// File: Prog2Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Address and
// Letter items, and a Report menu with List Addresses and List Parcels
// items.
//
// With Program 3, we will add serialization in order to Open and Save As with files. 
// The user will also be able to edit addresses that have been saved in the file.
// I'd like to point out that I sent a letter to John Cleese via this program

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace UPVApp
{
    [Serializable]
    public partial class Prog2Form : Form
        {
        private UserParcelView upv; // The UserParcelView

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test addresses are
        //                added to the list of addresses
        public Prog2Form()
            {
            InitializeComponent();

            //All test data is commented out. It has been saved to Prog3Data.dat
            upv = new UserParcelView();

            //// Test Data - Magic Numbers OK
            //upv.AddAddress("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
            //    "  Louisville   ", "  KY   ", 40202); // Test Address 1
            //upv.AddAddress("Jane Doe", "987 Main St.",
            //    "Beverly Hills", "CA", 90210); // Test Address 2
            //upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
            //    "El Paso", "TX", 79901); // Test Address 3
            //upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
            //    "Portland", "ME", 04101); // Test Address 4
            //upv.AddAddress("John Doe", "111 Market St.", "",
            //    "Jeffersonville", "IN", 47130); // Test Address 5
            //upv.AddAddress("Jane Smith", "55 Hollywood Blvd.", "Apt. 9",
            //    "Los Angeles", "CA", 90212); // Test Address 6
            //upv.AddAddress("Captain Robert Crunch", "21 Cereal Rd.", "Room 987",
            //    "Bethesda", "MD", 20810); // Test Address 7
            //upv.AddAddress("Vlad Dracula", "6543 Vampire Way", "Apt. 1",
            //    "Bloodsucker City", "TN", 37210); // Test Address 8

            //upv.AddLetter(upv.AddressAt(0), upv.AddressAt(1), 3.95M);                     // Letter test object
            //upv.AddLetter(upv.AddressAt(2), upv.AddressAt(3), 4.25M);                     // Letter test object
            //upv.AddGroundPackage(upv.AddressAt(4), upv.AddressAt(5), 14, 10, 5, 12.5);    // Ground test object
            //upv.AddGroundPackage(upv.AddressAt(6), upv.AddressAt(7), 8.5, 9.5, 6.5, 2.5); // Ground test object
            //upv.AddNextDayAirPackage(upv.AddressAt(0), upv.AddressAt(2), 25, 15, 15,      // Next Day test object
            //    85, 7.50M);
            //upv.AddNextDayAirPackage(upv.AddressAt(2), upv.AddressAt(4), 9.5, 6.0, 5.5,   // Next Day test object
            //    5.25, 5.25M);
            //upv.AddNextDayAirPackage(upv.AddressAt(1), upv.AddressAt(6), 10.5, 6.5, 9.5,  // Next Day test object
            //    15.5, 5.00M);
            //upv.AddTwoDayAirPackage(upv.AddressAt(4), upv.AddressAt(6), 46.5, 39.5, 28.0, // Two Day test object
            //    80.5, TwoDayAirPackage.Delivery.Saver);
            //upv.AddTwoDayAirPackage(upv.AddressAt(7), upv.AddressAt(0), 15.0, 9.5, 6.5,   // Two Day test object
            //    75.5, TwoDayAirPackage.Delivery.Early);
            //upv.AddTwoDayAirPackage(upv.AddressAt(5), upv.AddressAt(3), 12.0, 12.0, 6.0,  // Two Day test object
            //    5.5, TwoDayAirPackage.Delivery.Saver);
            }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
            {
            string NL = Environment.NewLine; // Newline shorthand

            MessageBox.Show($"Program 3{NL}By: Patrick Warren{NL}CIS 200-76{NL}Fall 2017",
                "About Program 3");
            }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        // Precondition:  Insert, Address menu item activated
        // Postcondition: The Address dialog box is displayed. If data entered
        //                are OK, an Address is created and added to the list
        //                of addresses
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
            {
            AddressForm addressForm = new AddressForm();    // The address dialog box form
            DialogResult result = addressForm.ShowDialog(); // Show form as dialog and store result
            int zip; // Address zip code

            if (result == DialogResult.OK) // Only add if OK
                {
                if (int.TryParse(addressForm.ZipText, out zip))
                    {
                    upv.AddAddress(addressForm.AddressName, addressForm.Address1,
                        addressForm.Address2, addressForm.City, addressForm.State,
                        zip); // Use form's properties to create address
                    }
                else // This should never happen if form validation works!
                    {
                    MessageBox.Show("Problem with Address Validation!", "Validation Error");
                    }
                }

            addressForm.Dispose(); // Best practice for dialog boxes
                                   // Alternatively, use with using clause as in Ch. 17
            }

        // Precondition:  Report, List Addresses menu item activated
        // Postcondition: The list of addresses is displayed in the addressResultsTxt
        //                text box
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
            {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            string NL = Environment.NewLine;            // Newline shorthand

            result.Append("Addresses:");
            result.Append(NL); // Remember, \n doesn't always work in GUIs
            result.Append(NL);

            foreach (Address a in upv.AddressList)
                {
                result.Append(a.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
                }

            reportTxt.Text = result.ToString();

            // -- OR --
            // Not using StringBuilder, just use TextBox directly

            //reportTxt.Clear();
            //reportTxt.AppendText("Addresses:");
            //reportTxt.AppendText(NL); // Remember, \n doesn't always work in GUIs
            //reportTxt.AppendText(NL);

            //foreach (Address a in upv.AddressList)
            //{
            //    reportTxt.AppendText(a.ToString());
            //    reportTxt.AppendText(NL);
            //    reportTxt.AppendText("------------------------------");
            //    reportTxt.AppendText(NL);
            //}

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
            }

        // Precondition:  Insert, Letter menu item activated
        // Postcondition: The Letter dialog box is displayed. If data entered
        //                are OK, a Letter is created and added to the list
        //                of parcels
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
            {
            LetterForm letterForm; // The letter dialog box form
            DialogResult result;   // The result of showing form as dialog
            decimal fixedCost;     // The letter's cost

            if (upv.AddressCount < LetterForm.MIN_ADDRESSES) // Make sure we have enough addresses
                {
                MessageBox.Show("Need " + LetterForm.MIN_ADDRESSES + " addresses to create letter!",
                    "Addresses Error");
                return; // Exit now since can't create valid letter
                }

            letterForm = new LetterForm(upv.AddressList); // Send list of addresses
            result = letterForm.ShowDialog();

            if (result == DialogResult.OK) // Only add if OK
                {
                if (decimal.TryParse(letterForm.FixedCostText, out fixedCost))
                    {
                    // For this to work, LetterForm's combo boxes need to be in same
                    // order as upv's AddressList
                    upv.AddLetter(upv.AddressAt(letterForm.OriginAddressIndex),
                        upv.AddressAt(letterForm.DestinationAddressIndex),
                        fixedCost); // Letter to be inserted
                    }
                else // This should never happen if form validation works!
                    {
                    MessageBox.Show("Problem with Letter Validation!", "Validation Error");
                    }
                }

            letterForm.Dispose(); // Best practice for dialog boxes
                                  // Alternatively, use with using clause as in Ch. 17
            }

        // Precondition:  Report, List Parcels menu item activated
        // Postcondition: The list of parcels is displayed in the parcelResultsTxt
        //                text box
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
            {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            decimal totalCost = 0;                      // Running total of parcel shipping costs
            string NL = Environment.NewLine;            // Newline shorthand

            result.Append("Parcels:");
            result.Append(NL); // Remember, \n doesn't always work in GUIs
            result.Append(NL);

            foreach (Parcel p in upv.ParcelList)
                {
                result.Append(p.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
                totalCost += p.CalcCost();
                }

            result.Append(NL);
            result.Append($"Total Cost: {totalCost:C}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
            }

        //Precondition: Open menu item selected
        //Postcondition: File selected by the user is opened
        private void openMenuStripItem_Click(object sender, EventArgs e)
            {
            BinaryFormatter bireader = new BinaryFormatter(); //Holds instructions to serialize and deserialize an object
            DialogResult result;
            string serialFile;
            FileStream input = null; // Maintains connection to file

            using (OpenFileDialog chooser = new OpenFileDialog())
                {
                result = chooser.ShowDialog();
                serialFile = chooser.FileName;
                }
            //Checks validation of file
            if (result == DialogResult.OK)
                {
                
                //Error if file not valid
                if (serialFile == string.Empty)
                    {
                    MessageBox.Show("Is that a file? No.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else
                    {
                    try
                        {

                        //Creates new filestream
                        input = new FileStream(serialFile, FileMode.Open, FileAccess.Read);

                        //Deserialize current file
                        upv = (UserParcelView)bireader.Deserialize(input);
                        }
                    catch (IOException)
                        {
                        MessageBox.Show("Error Opening File", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    catch (SerializationException)
                        {
                        MessageBox.Show("Error Reading from File", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    //Closes file at the end
                    finally
                        {
                        //Close file stream
                        if (input != null)
                            input.Close();
                            
                        }
                    }
                }

            }

        //Precondition: Save menu item selected
        //Postcondition: New input saved to selected file
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter biformatter = new BinaryFormatter(); //Holds instructions to serialize and deserialize an object
            DialogResult result;
            string serialFile;
            FileStream output = null; // Maintains connection to file

            using (SaveFileDialog chooser = new SaveFileDialog())
                {
                result = chooser.ShowDialog();
                serialFile = chooser.FileName;
                }

            if (result == DialogResult.OK)
                {
                //If file name is empty, do not accept
                if (serialFile == string.Empty)
                    {
                    MessageBox.Show("Invalid File Name", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else
                    {
                    try
                        {
                        //If pass, save file
                        output = new FileStream(serialFile, FileMode.Open, FileAccess.Write);
                        biformatter.Serialize(output, upv);
                        }
                    catch (IOException)
                        {
                        MessageBox.Show("Error Opening File", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    catch (SerializationException)
                        {
                        MessageBox.Show("Error Writing to File", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    finally
                        {
                        //Close FileStream
                        if (output != null)
                            output.Close();
                        }
                    }
                }
            }

        //Precondition: User clicks Edit > Address
        //Postcondition: ChooseAddressForm is displayed
        private void addressToolStripMenuItemOne_Click(object sender, EventArgs e)
            {
            ChooseAddressForm chooseForm = new ChooseAddressForm(upv.AddressList); //Send list of addresses
            DialogResult result = chooseForm.ShowDialog(); //Result is shown
            int addressIndex; //Used for index position

            if (result == DialogResult.OK)
                {
                addressIndex = chooseForm.chosenIndex; //Inherit index from ChooseAddressForm
                AddressForm addressEdit = new AddressForm(); // Opens new address form to edit selected address

                //Fill in form with selected address
                addressEdit.AddressName = upv.AddressList[addressIndex].Name;
                addressEdit.Address1 = upv.AddressList[addressIndex].Address1;
                addressEdit.Address2 = upv.AddressList[addressIndex].Address2;
                addressEdit.City = upv.AddressList[addressIndex].City;
                addressEdit.State = upv.AddressList[addressIndex].State;
                addressEdit.ZipText = upv.AddressList[addressIndex].Zip.ToString();

                DialogResult editResult = addressEdit.ShowDialog(); //Stores result from addressEdit

                //Fill in form with selected address
                if (editResult == DialogResult.OK)
                    {
                    upv.AddressList[addressIndex].Name = addressEdit.AddressName;
                    upv.AddressList[addressIndex].Address1 = addressEdit.Address1;
                    upv.AddressList[addressIndex].Address2 = addressEdit.Address2;
                    upv.AddressList[addressIndex].City = addressEdit.City;
                    upv.AddressList[addressIndex].State = addressEdit.State;
                    upv.AddressList[addressIndex].Zip = Convert.ToInt32(addressEdit.ZipText);
                    }
                }
            
            }
        }
}