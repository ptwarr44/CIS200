namespace UPVApp
    {
    partial class AddressForm
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameAddBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressAddBox = new System.Windows.Forms.TextBox();
            this.addressTwoAddBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.cityLabal = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.Location = new System.Drawing.Point(27, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // nameAddBox
            // 
            this.nameAddBox.Location = new System.Drawing.Point(82, 13);
            this.nameAddBox.Name = "nameAddBox";
            this.nameAddBox.Size = new System.Drawing.Size(132, 20);
            this.nameAddBox.TabIndex = 1;
            this.nameAddBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameBoxValidating);
            this.nameAddBox.Validated += new System.EventHandler(this.NameBoxValidated);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addressLabel.Location = new System.Drawing.Point(17, 45);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(64, 17);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address:";
            // 
            // addressAddBox
            // 
            this.addressAddBox.Location = new System.Drawing.Point(82, 40);
            this.addressAddBox.Name = "addressAddBox";
            this.addressAddBox.Size = new System.Drawing.Size(132, 20);
            this.addressAddBox.TabIndex = 3;
            this.addressAddBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddressBoxValidating);
            this.addressAddBox.Validated += new System.EventHandler(this.AddressBoxValidated);
            // 
            // addressTwoAddBox
            // 
            this.addressTwoAddBox.Location = new System.Drawing.Point(82, 68);
            this.addressTwoAddBox.Name = "addressTwoAddBox";
            this.addressTwoAddBox.Size = new System.Drawing.Size(132, 20);
            this.addressTwoAddBox.TabIndex = 4;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(82, 94);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(132, 20);
            this.cityBox.TabIndex = 5;
            this.cityBox.Validating += new System.ComponentModel.CancelEventHandler(this.CityBoxValidating);
            this.cityBox.Validated += new System.EventHandler(this.CityBoxValidated);
            // 
            // cityLabal
            // 
            this.cityLabal.AutoSize = true;
            this.cityLabal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cityLabal.Location = new System.Drawing.Point(46, 97);
            this.cityLabal.Name = "cityLabal";
            this.cityLabal.Size = new System.Drawing.Size(35, 17);
            this.cityLabal.TabIndex = 6;
            this.cityLabal.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stateLabel.Location = new System.Drawing.Point(36, 124);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(45, 17);
            this.stateLabel.TabIndex = 7;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.zipLabel.Location = new System.Drawing.Point(49, 150);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(32, 17);
            this.zipLabel.TabIndex = 8;
            this.zipLabel.Text = "Zip:";
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(82, 147);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(132, 20);
            this.zipBox.TabIndex = 9;
            this.zipBox.Validating += new System.ComponentModel.CancelEventHandler(this.ZipCodeValidating);
            this.zipBox.Validated += new System.EventHandler(this.ZipCodeValidated);
            // 
            // stateComboBox
            // 
            this.stateComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "AK",
            "AL",
            "AR",
            "AZ",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "IA",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "MA",
            "MD",
            "ME",
            "MI",
            "MN",
            "MO",
            "MS",
            "MT",
            "NC",
            "ND",
            "NE",
            "NH",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VA",
            "VT",
            "WA",
            "WI",
            "WV",
            "WY"});
            this.stateComboBox.Location = new System.Drawing.Point(82, 120);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(132, 24);
            this.stateComboBox.Sorted = true;
            this.stateComboBox.TabIndex = 10;
            this.stateComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.StateValidating);
            this.stateComboBox.Validated += new System.EventHandler(this.StateValidated);
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(36, 188);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(86, 25);
            this.OKBtn.TabIndex = 11;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(128, 188);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(86, 25);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(240, 223);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabal);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.addressTwoAddBox);
            this.Controls.Add(this.addressAddBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameAddBox);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddressForm";
            this.Text = "Address";
            this.TopMost = true;
            this.Enter += new System.EventHandler(this.okBtn_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameAddBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressAddBox;
        private System.Windows.Forms.TextBox addressTwoAddBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label cityLabal;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox zipBox;
        internal System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        }
    }