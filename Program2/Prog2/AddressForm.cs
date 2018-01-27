// By: Patrick Warren
// Program 2
// CIS 200-76
// Fall 2017
// Due: 10/23/2017
 
/*
 * Users will be able to add in a custom address using this form. Validation is enforced so Name, Address One,
 * City, State and Zip Code are mandatory to save an address. Address Two is optional.
 * 
 * The user will be able to use the newly added addresses to create a letter
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
    public partial class AddressForm : Form
        {

        public AddressForm()
            {
            InitializeComponent();
            }

        public String NameValue
            {

            //Precondition: None
            //Postcondition: Name entered is returned
            get { return nameAddBox.Text; }

            //Preconditions: None
            //Postcondition: Name is set to specified value
            set
                {
                nameAddBox.Text = value;
                }
            }

        public String AddressOne
            {
            //Precondition: None
            //Postcondition: First address is returned
            get { return addressAddBox.Text; }

            //Precondition: None
            //Postcondition: First address is set to specified value
            set
                {
                addressAddBox.Text = value;
                }
            }

        public String AddressTwo
            {
            //Precondition: None
            //Postcondition: Address two is returned
            get { return addressTwoAddBox.Text; }

            //Precondition: None
            //Postcondition: Address two set to specified value
            set
                {
                addressTwoAddBox.Text = value;
                }
            }

        public String City
            {
            //Precondition: None
            //Postcondition: City is returned
            get { return cityBox.Text; }

            //Precondition: None
            //PostconditioN: City is set to specified value
            set
                {
                cityBox.Text = value;
                }
            }

        public string StateIndex
            {
            //Precondition: State chosen
            //Postcondition: State is returned
            get { return stateComboBox.Text; }
            }

        public int Zip
            {
            //Precondition: None
            //Postcondition: Zip is returned
            get { return int.Parse(zipBox.Text); }

            //Precondtion: None
            //Postcondition: Zip is set
            set
                {
                if (int.TryParse(zipBox.Text, out int result))
                    result = value;
                }
            }

        // Preconditions: Focus is shifting from nameAddBox
        // Postconditions: If invalid, focus remains and error provider
        //                 highlights the field
        private void NameBoxValidating(object sender, CancelEventArgs e)
            {
            if (nameAddBox.TextLength == 0)
                {
                e.Cancel = true;
                errorProvider1.SetError(nameAddBox, "Must provide a name!");
                nameAddBox.SelectAll();
                }
            }
        // Preconditions: Validating of name text box is cancelled
        // Postconditions: Error provider cleared and focus allowed to change
        private void NameBoxValidated(object sender, EventArgs e)
            {
            errorProvider1.SetError(nameAddBox, "");
            }

        // Preconditions: Focus is shifting from addressAddBox
        // Postconditions: If invalid, focus remains and error provider
        //                 highlights the field
        private void AddressBoxValidating(object sender, CancelEventArgs e)
            {
            if (addressAddBox.TextLength == 0)
                {
                e.Cancel = true;
                errorProvider1.SetError(addressAddBox, "Must provide an address!");
                addressAddBox.SelectAll(); //Select all text
                }
            }

        // Preconditions: Validating of name text box is cancelled
        // Postconditions: Error provider cleared and focus allowed to change
        private void AddressBoxValidated(object sender, EventArgs e)
            {
            errorProvider1.SetError(addressAddBox, "");
            }

        // Preconditions: Focus is shifting from cityBox
        // Postconditions: If invalid, focus remains and error provider
        //                 highlights the field
        private void CityBoxValidating(object sender, CancelEventArgs e)
            {

            if (cityBox.TextLength == 0)
                {
                e.Cancel = true;
                errorProvider1.SetError(cityBox, "Must provide a city!");
                cityBox.SelectAll(); //Select all text
                }
            }

        // Preconditions: Validating of name text box is cancelled
        // Postconditions: Error provider cleared and focus allowed to change
        private void CityBoxValidated(object sender, EventArgs e)
            {
            errorProvider1.SetError(cityBox, "");
            }

        //Precondition: Focus is shifting from cityBox
        // Postconditions: If invalid, focus remains and error provider
        //                 highlights the field
        private void StateValidating(object sender, CancelEventArgs e)
            {
            if (stateComboBox.SelectedIndex == -1)
                e.Cancel = true;

            errorProvider1.SetError(stateComboBox, "Must select a state!");
            stateComboBox.SelectAll(); //Select all text
            }

        //Precondtiion: Validating of name Combo box is cancelled
        //Postcondition: Error provider cleared and focus allowed to change
        private void StateValidated(object sender, EventArgs e)
            {
            errorProvider1.SetError(stateComboBox, "");
            }

        //Precondition: Focus is shifting from cityBox
        // Postconditions: If invalid, focus remains and error provider
        //                 highlights the field
        private void ZipCodeValidating(object sender, CancelEventArgs e)
            {
            int zip; //Zip code
            bool isValid = true; //Is zip code valid?

            //If it is not a number and not between 0 & 99999, it is invalid
            if ((!int.TryParse(zipBox.Text, out zip)) && (zip < 00000 || zip > 99999))
                isValid = false;

            //Validation passed
            if (!isValid)
                {
                e.Cancel = true;
                errorProvider1.SetError(zipBox, "Must enter a zip code!");
                zipBox.SelectAll();
                }
            }

        //Precondtiion: Validating of name Combo box is cancelled
        //Postcondition: Error provider cleared and focus allowed to change
        private void ZipCodeValidated(object sender, EventArgs e)
            {
            errorProvider1.SetError(zipBox, "");
            }

        //Precondition: OK Button is clicked
        //Postcondition: Address added to the list of addresses
        private void okBtn_Click(object sender, EventArgs e)
            {
            if (ValidateChildren())
            this.DialogResult = DialogResult.OK;
            }

        //Precondition: Cancel button is clicked
        //Postcondition: Form closed
        private void cancelBtn_Click(object sender, EventArgs e)
            {
            this.DialogResult = DialogResult.Cancel;
            }

        }
    }
