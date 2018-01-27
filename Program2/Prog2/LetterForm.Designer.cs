namespace UPVApp
    {
    partial class LetterForm
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
            this.originLabel = new System.Windows.Forms.Label();
            this.destLabel = new System.Windows.Forms.Label();
            this.fixCostLabel = new System.Windows.Forms.Label();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.originComboBox = new System.Windows.Forms.ComboBox();
            this.destComboBox = new System.Windows.Forms.ComboBox();
            this.fixedCostText = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(42, 20);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(78, 13);
            this.originLabel.TabIndex = 0;
            this.originLabel.Text = "Origin Address:";
            // 
            // destLabel
            // 
            this.destLabel.AutoSize = true;
            this.destLabel.Location = new System.Drawing.Point(16, 58);
            this.destLabel.Name = "destLabel";
            this.destLabel.Size = new System.Drawing.Size(104, 13);
            this.destLabel.TabIndex = 1;
            this.destLabel.Text = "Destination Address:";
            // 
            // fixCostLabel
            // 
            this.fixCostLabel.AutoSize = true;
            this.fixCostLabel.Location = new System.Drawing.Point(61, 91);
            this.fixCostLabel.Name = "fixCostLabel";
            this.fixCostLabel.Size = new System.Drawing.Size(59, 13);
            this.fixCostLabel.TabIndex = 2;
            this.fixCostLabel.Text = "Fixed Cost:";
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(19, 129);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 3;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(179, 129);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // originComboBox
            // 
            this.originComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originComboBox.FormattingEnabled = true;
            this.originComboBox.Location = new System.Drawing.Point(126, 17);
            this.originComboBox.Name = "originComboBox";
            this.originComboBox.Size = new System.Drawing.Size(128, 21);
            this.originComboBox.TabIndex = 5;
            this.originComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.originComboBox_Validating);
            this.originComboBox.Validated += new System.EventHandler(this.originComboBox_Validated);
            // 
            // destComboBox
            // 
            this.destComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destComboBox.FormattingEnabled = true;
            this.destComboBox.Location = new System.Drawing.Point(126, 55);
            this.destComboBox.Name = "destComboBox";
            this.destComboBox.Size = new System.Drawing.Size(128, 21);
            this.destComboBox.TabIndex = 6;
            this.destComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.destComboBox_Validating);
            this.destComboBox.Validated += new System.EventHandler(this.destComboBox_Validated);
            // 
            // fixedCostText
            // 
            this.fixedCostText.Location = new System.Drawing.Point(126, 88);
            this.fixedCostText.Name = "fixedCostText";
            this.fixedCostText.Size = new System.Drawing.Size(128, 20);
            this.fixedCostText.TabIndex = 7;
            this.fixedCostText.Validating += new System.ComponentModel.CancelEventHandler(this.fixedCostText_Validating);
            this.fixedCostText.Validated += new System.EventHandler(this.fixedCostText_Validated);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(278, 160);
            this.Controls.Add(this.fixedCostText);
            this.Controls.Add(this.destComboBox);
            this.Controls.Add(this.originComboBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.fixCostLabel);
            this.Controls.Add(this.destLabel);
            this.Controls.Add(this.originLabel);
            this.Name = "LetterForm";
            this.Text = "Letter";
            this.Activated += new System.EventHandler(this.LetterForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.Label destLabel;
        private System.Windows.Forms.Label fixCostLabel;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ComboBox originComboBox;
        private System.Windows.Forms.ComboBox destComboBox;
        private System.Windows.Forms.TextBox fixedCostText;
        private System.Windows.Forms.ErrorProvider errorProvider;
        }
    }