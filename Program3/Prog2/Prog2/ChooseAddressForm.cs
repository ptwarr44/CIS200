// By: Patrick Warren
// Program 3
// CIS 200-76
// Fall 2017
// Due: 11/08/2017

// This form has been created for the purpose of changing addresses.
// When opened, it will ask you to select an address from the list.
// You may not continue until you have selected at least one address.
// Once selected, it will open up the Address form so you may edit the address.
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
    [Serializable]
    public partial class ChooseAddressForm : Form
        {

        //Precondition: 
        //Postcondition: GUI is displayed
        private List<Address> addressList;  // List of addresses used to fill combo boxes
        public int chosenIndex; // Stores current index

        public ChooseAddressForm(List<Address> addresses)
            {
            InitializeComponent();
            addressList = addresses;

            foreach (Address address in addresses)
                addressBox.Items.Add(address.Name.ToString());
            }

        //Precondition: OK button clicked
        //Postcondition: Form stays open if input invalid
        private void okBtn_Click(object sender, EventArgs e)
            {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
            }

        //Precondition: Combo box selected
        //Postcondition: Index changed to a different address
        private void addressBox_SelectedIndexChanged(object sender, EventArgs e)
            {
            chosenIndex = addressBox.SelectedIndex; //Index for address list.
            }

        //Precondition: Cancel button clicked
        //Postcondition: Application form closed
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
            {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
            }

        //Precondition: Focus taken away from addressBox
        //Postcondition: If invalid selection, focus stays on addressBox
        private void AddressBox_Validating(object sender, CancelEventArgs e)
            {
            ComboBox addressCBO = sender as ComboBox;

            if (addressCBO.SelectedIndex == -1)
                {
                e.Cancel = true;
                errorProvider.SetError(addressCBO, "Must provide a selection");
                }
            }

        // Precondition:  Validating of sender not cancelled, so data OK
        //                sender is Control
        // Postcondition: Error provider cleared and focus allowed to change
        private void AddressBox_Validated(object sender, EventArgs e)
            {
            // Downcast to sender as Control, so make sure you obey precondition!
            Control addressControl = sender as Control; // Cast sender as Control

            errorProvider.SetError(addressControl, "");
            }
        }
    }
