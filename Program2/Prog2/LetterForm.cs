// By: Patrick Warren
// Program 2
// CIS 200-76
// Fall 2017
// Due: 10/23/2017
 
/*
 * Holds the letter form class. You will be able to add a previously stored origin address and desitination
 * address in order to ship. You will also need to enter a fixed cost for this shipment.
 * This fixed cost will be added to the running total.
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
    public partial class LetterForm : Form
        {
        private List<Address> listAddresses; //Holds a list of addresses
        public LetterForm(List<Address> addresses)
            {
            InitializeComponent();
            listAddresses = addresses;
            }

        //Precondition: Form is loaded
        //Postcondition: Addresses are populated in combo boxes
        internal void LetterForm_Activated(object sender, EventArgs e)
            {
            //Steps through and adds each address to the origin and destination
            //combo boxes
            foreach (Address address in listAddresses)
                {
                originComboBox.Items.Add(address.Name);
                destComboBox.Items.Add(address.Name);
                }
            }

        internal int OriginValue
            {
            //Precondition: None
            //Postcondition: Text in originComboBox is returned
            get { return originComboBox.SelectedIndex; }

            //Precondition: None
            //Postcondition: Text in originComboBox is returned
            set { originComboBox.SelectedIndex = value; }
            }

        internal int DestValue 
            {
            //Precondition: None
            // Postcondition: Text in destComboBox is returned
            get { return destComboBox.SelectedIndex; }

            //Precondition: None
            //Postcondition: Text in destComboBox is set to specified value
            set { destComboBox.SelectedIndex = value; }
            }

        internal string FixedCost
            {
            //Precondition: None
            //Postcondition: Fixed cost is returned
            get { return fixedCostText.Text; }

            //Precondition: Number greater than 0
            //Postcondition: Sets fixed cost to value
            set
                {
                    fixedCostText.Text = value;
                }
            }

        //Precondition: None
        //Postcondition: Input in the originComboBox is being validated
        private void originComboBox_Validating(object sender, CancelEventArgs e)
            {
            if (originComboBox.SelectedIndex == -1) //If nothing is selected
                e.Cancel = true;

            errorProvider.SetError(originComboBox, "Select an origin address!");
            originComboBox.SelectAll();
            }

        //Precondition: Combo box validated
        //Postcondition: Allows user to select another entry
        private void originComboBox_Validated(object sender, EventArgs e)
            {
            errorProvider.SetError(originComboBox, ""); //Clears error
            }

        //Precondition: None
        //Postcondition: Input in the destComboBox is being validated
        private void destComboBox_Validating(object sender, CancelEventArgs e)
            {
            if (destComboBox.SelectedIndex == -1) //If nothing is selected
                e.Cancel = true;

            errorProvider.SetError(destComboBox, "Select an destination address!");
            destComboBox.SelectAll();
            }

        //Precondition: Combo box validated
        //Postcondition: Allows user to select another entry
        private void destComboBox_Validated(object sender, EventArgs e)
            {
            errorProvider.SetError(destComboBox, ""); //Clears error
            }

        //Precondition: None
        //Postcondition: Input in the fixedCostText is being validated
        private void fixedCostText_Validating(object sender, CancelEventArgs e)
            {
            decimal value; //Represents the value of the decimal entered
            if (!decimal.TryParse(fixedCostText.Text, out value))
                e.Cancel = true;

            errorProvider.SetError(fixedCostText, "Enter a valid decimal number!");
            fixedCostText.SelectAll();
            }

        //Precondition: None
        //Postcondition: Allows user to select another entry
        private void fixedCostText_Validated(object sender, EventArgs e)
            {
            errorProvider.SetError(fixedCostText, "");
            }
        //Precondition: OK button clicked
        //Postcondition: Letter added to list of parcels
        private void okBtn_Click(object sender, EventArgs e)
            {
            if (originComboBox.SelectedIndex == destComboBox.SelectedIndex)
                MessageBox.Show("Please make sure the origin and destination addresses do not match!");
            else if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
            }

        //Precondition: Cancel button clicked
        //Postcondition: Form closed without adding letter
        private void CancelBtn_Click(object sender, EventArgs e)
            {
            this.DialogResult = DialogResult.Cancel;
            }
        }
    }