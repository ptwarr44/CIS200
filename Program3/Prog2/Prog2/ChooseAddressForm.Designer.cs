namespace UPVApp
    {
    partial class ChooseAddressForm
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
            this.descLabel = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(68, 9);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(120, 13);
            this.descLabel.TabIndex = 0;
            this.descLabel.Text = "Choose Address to Edit:";
            // 
            // addressBox
            // 
            this.addressBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addressBox.FormattingEnabled = true;
            this.addressBox.Location = new System.Drawing.Point(44, 25);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(156, 21);
            this.addressBox.TabIndex = 1;
            this.addressBox.SelectedIndexChanged += new System.EventHandler(this.addressBox_SelectedIndexChanged);
            this.addressBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddressBox_Validating);
            this.addressBox.Validated += new System.EventHandler(this.AddressBox_Validated);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(44, 51);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(124, 51);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ChooseAddressForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 81);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.descLabel);
            this.Name = "ChooseAddressForm";
            this.Text = "ChooseAddressForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.ComboBox addressBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        }
    }