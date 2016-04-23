namespace tecGUI
{
    partial class TEC
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
            this.submitButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.givenNamesLabel = new System.Windows.Forms.Label();
            this.givenNamesTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.employeeIdLabel = new System.Windows.Forms.Label();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.taxFileLabel = new System.Windows.Forms.Label();
            this.TaxFileTextBox = new System.Windows.Forms.TextBox();
            this.taxTableComboBox = new System.Windows.Forms.ComboBox();
            this.taxTableLabel = new System.Windows.Forms.Label();
            this.bsbLabel = new System.Windows.Forms.Label();
            this.bsbTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.accoutnNumberTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.postcodeLabel = new System.Windows.Forms.Label();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.empBasisComboBox = new System.Windows.Forms.ComboBox();
            this.employBasisLabel = new System.Windows.Forms.Label();
            this.employCatComboBox = new System.Windows.Forms.ComboBox();
            this.employmentCatLabel = new System.Windows.Forms.Label();
            this.empStatusComboBox = new System.Windows.Forms.ComboBox();
            this.empStatusLabel = new System.Windows.Forms.Label();
            this.payslipComboBox = new System.Windows.Forms.ComboBox();
            this.payslipLabel = new System.Windows.Forms.Label();
            this.qualificationLabel = new System.Windows.Forms.Label();
            this.qualificationTextBox = new System.Windows.Forms.TextBox();
            this.expDatePicker = new System.Windows.Forms.DateTimePicker();
            this.expiresCheckBox = new System.Windows.Forms.CheckBox();
            this.qualAddButton = new System.Windows.Forms.Button();
            this.qualListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(482, 448);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(125, 25);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(110, 24);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(205, 22);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(17, 24);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // givenNamesLabel
            // 
            this.givenNamesLabel.AutoSize = true;
            this.givenNamesLabel.Location = new System.Drawing.Point(326, 24);
            this.givenNamesLabel.Name = "givenNamesLabel";
            this.givenNamesLabel.Size = new System.Drawing.Size(93, 17);
            this.givenNamesLabel.TabIndex = 4;
            this.givenNamesLabel.Text = "Given Names";
            // 
            // givenNamesTextBox
            // 
            this.givenNamesTextBox.Location = new System.Drawing.Point(437, 24);
            this.givenNamesTextBox.Name = "givenNamesTextBox";
            this.givenNamesTextBox.Size = new System.Drawing.Size(205, 22);
            this.givenNamesTextBox.TabIndex = 3;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(17, 61);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 6;
            this.addressLabel.Text = "Address";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(110, 61);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(320, 64);
            this.AddressTextBox.TabIndex = 5;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(17, 210);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(56, 17);
            this.genderLabel.TabIndex = 8;
            this.genderLabel.Text = "Gender";
            this.genderLabel.Click += new System.EventHandler(this.genderLabel_Click);
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(110, 210);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 24);
            this.genderComboBox.TabIndex = 9;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(17, 249);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(87, 17);
            this.dobLabel.TabIndex = 10;
            this.dobLabel.Text = "Date of Birth";
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(110, 249);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(200, 22);
            this.dateOfBirthPicker.TabIndex = 11;
            // 
            // employeeIdLabel
            // 
            this.employeeIdLabel.AutoSize = true;
            this.employeeIdLabel.Location = new System.Drawing.Point(681, 24);
            this.employeeIdLabel.Name = "employeeIdLabel";
            this.employeeIdLabel.Size = new System.Drawing.Size(85, 17);
            this.employeeIdLabel.TabIndex = 13;
            this.employeeIdLabel.Text = "Employee Id";
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(801, 24);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(205, 22);
            this.EmployeeIdTextBox.TabIndex = 12;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(681, 64);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(103, 17);
            this.phoneNumberLabel.TabIndex = 15;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(801, 64);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(205, 22);
            this.phoneNumberTextBox.TabIndex = 14;
            // 
            // taxFileLabel
            // 
            this.taxFileLabel.AutoSize = true;
            this.taxFileLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.taxFileLabel.Location = new System.Drawing.Point(681, 332);
            this.taxFileLabel.Name = "taxFileLabel";
            this.taxFileLabel.Size = new System.Drawing.Size(111, 17);
            this.taxFileLabel.TabIndex = 17;
            this.taxFileLabel.Text = "Tax File Number";
            // 
            // TaxFileTextBox
            // 
            this.TaxFileTextBox.Location = new System.Drawing.Point(801, 332);
            this.TaxFileTextBox.Name = "TaxFileTextBox";
            this.TaxFileTextBox.Size = new System.Drawing.Size(205, 22);
            this.TaxFileTextBox.TabIndex = 16;
            // 
            // taxTableComboBox
            // 
            this.taxTableComboBox.FormattingEnabled = true;
            this.taxTableComboBox.Items.AddRange(new object[] {
            "Tax Free Threshold",
            "Non-Tax Free Threshold"});
            this.taxTableComboBox.Location = new System.Drawing.Point(801, 368);
            this.taxTableComboBox.Name = "taxTableComboBox";
            this.taxTableComboBox.Size = new System.Drawing.Size(121, 24);
            this.taxTableComboBox.TabIndex = 19;
            // 
            // taxTableLabel
            // 
            this.taxTableLabel.AutoSize = true;
            this.taxTableLabel.Location = new System.Drawing.Point(681, 368);
            this.taxTableLabel.Name = "taxTableLabel";
            this.taxTableLabel.Size = new System.Drawing.Size(71, 17);
            this.taxTableLabel.TabIndex = 18;
            this.taxTableLabel.Text = "Tax Table";
            // 
            // bsbLabel
            // 
            this.bsbLabel.AutoSize = true;
            this.bsbLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.bsbLabel.Location = new System.Drawing.Point(17, 281);
            this.bsbLabel.Name = "bsbLabel";
            this.bsbLabel.Size = new System.Drawing.Size(35, 17);
            this.bsbLabel.TabIndex = 21;
            this.bsbLabel.Text = "BSB";
            // 
            // bsbTextBox
            // 
            this.bsbTextBox.Location = new System.Drawing.Point(110, 281);
            this.bsbTextBox.Name = "bsbTextBox";
            this.bsbTextBox.Size = new System.Drawing.Size(205, 22);
            this.bsbTextBox.TabIndex = 20;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.accountNumberLabel.Location = new System.Drawing.Point(344, 281);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(113, 17);
            this.accountNumberLabel.TabIndex = 23;
            this.accountNumberLabel.Text = "Account Number";
            // 
            // accoutnNumberTextBox
            // 
            this.accoutnNumberTextBox.Location = new System.Drawing.Point(463, 281);
            this.accoutnNumberTextBox.Name = "accoutnNumberTextBox";
            this.accoutnNumberTextBox.Size = new System.Drawing.Size(205, 22);
            this.accoutnNumberTextBox.TabIndex = 22;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(17, 144);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 17);
            this.cityLabel.TabIndex = 25;
            this.cityLabel.Text = "City";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(110, 141);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(320, 22);
            this.cityTextBox.TabIndex = 24;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(17, 179);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(41, 17);
            this.stateLabel.TabIndex = 27;
            this.stateLabel.Text = "State";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(110, 179);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(85, 22);
            this.stateTextBox.TabIndex = 26;
            // 
            // postcodeLabel
            // 
            this.postcodeLabel.AutoSize = true;
            this.postcodeLabel.Location = new System.Drawing.Point(252, 179);
            this.postcodeLabel.Name = "postcodeLabel";
            this.postcodeLabel.Size = new System.Drawing.Size(67, 17);
            this.postcodeLabel.TabIndex = 29;
            this.postcodeLabel.Text = "Postcode";
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.Location = new System.Drawing.Point(345, 179);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(85, 22);
            this.postcodeTextBox.TabIndex = 28;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(681, 108);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 31;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(801, 108);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(205, 22);
            this.emailTextBox.TabIndex = 30;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(801, 411);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 22);
            this.startDatePicker.TabIndex = 33;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.startDateLabel.Location = new System.Drawing.Point(681, 411);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(72, 17);
            this.startDateLabel.TabIndex = 32;
            this.startDateLabel.Text = "Start Date";
            // 
            // empBasisComboBox
            // 
            this.empBasisComboBox.FormattingEnabled = true;
            this.empBasisComboBox.Items.AddRange(new object[] {
            "Individual",
            "Contract"});
            this.empBasisComboBox.Location = new System.Drawing.Point(852, 194);
            this.empBasisComboBox.Name = "empBasisComboBox";
            this.empBasisComboBox.Size = new System.Drawing.Size(121, 24);
            this.empBasisComboBox.TabIndex = 35;
            // 
            // employBasisLabel
            // 
            this.employBasisLabel.AutoSize = true;
            this.employBasisLabel.Location = new System.Drawing.Point(681, 194);
            this.employBasisLabel.Name = "employBasisLabel";
            this.employBasisLabel.Size = new System.Drawing.Size(123, 17);
            this.employBasisLabel.TabIndex = 34;
            this.employBasisLabel.Text = "Employment Basis";
            // 
            // employCatComboBox
            // 
            this.employCatComboBox.FormattingEnabled = true;
            this.employCatComboBox.Items.AddRange(new object[] {
            "Permanent",
            "Casual"});
            this.employCatComboBox.Location = new System.Drawing.Point(852, 221);
            this.employCatComboBox.Name = "employCatComboBox";
            this.employCatComboBox.Size = new System.Drawing.Size(121, 24);
            this.employCatComboBox.TabIndex = 37;
            // 
            // employmentCatLabel
            // 
            this.employmentCatLabel.AutoSize = true;
            this.employmentCatLabel.Location = new System.Drawing.Point(681, 221);
            this.employmentCatLabel.Name = "employmentCatLabel";
            this.employmentCatLabel.Size = new System.Drawing.Size(146, 17);
            this.employmentCatLabel.TabIndex = 36;
            this.employmentCatLabel.Text = "Employment Category";
            // 
            // empStatusComboBox
            // 
            this.empStatusComboBox.FormattingEnabled = true;
            this.empStatusComboBox.Items.AddRange(new object[] {
            "Full-Time",
            "Part-Time"});
            this.empStatusComboBox.Location = new System.Drawing.Point(852, 249);
            this.empStatusComboBox.Name = "empStatusComboBox";
            this.empStatusComboBox.Size = new System.Drawing.Size(121, 24);
            this.empStatusComboBox.TabIndex = 39;
            // 
            // empStatusLabel
            // 
            this.empStatusLabel.AutoSize = true;
            this.empStatusLabel.Location = new System.Drawing.Point(681, 249);
            this.empStatusLabel.Name = "empStatusLabel";
            this.empStatusLabel.Size = new System.Drawing.Size(129, 17);
            this.empStatusLabel.TabIndex = 38;
            this.empStatusLabel.Text = "Employment Status";
            // 
            // payslipComboBox
            // 
            this.payslipComboBox.FormattingEnabled = true;
            this.payslipComboBox.Items.AddRange(new object[] {
            "To Be Printed",
            "To Be Emailed"});
            this.payslipComboBox.Location = new System.Drawing.Point(852, 274);
            this.payslipComboBox.Name = "payslipComboBox";
            this.payslipComboBox.Size = new System.Drawing.Size(121, 24);
            this.payslipComboBox.TabIndex = 41;
            // 
            // payslipLabel
            // 
            this.payslipLabel.AutoSize = true;
            this.payslipLabel.Location = new System.Drawing.Point(681, 274);
            this.payslipLabel.Name = "payslipLabel";
            this.payslipLabel.Size = new System.Drawing.Size(108, 17);
            this.payslipLabel.TabIndex = 40;
            this.payslipLabel.Text = "Payslip Delivery";
            // 
            // qualificationLabel
            // 
            this.qualificationLabel.AutoSize = true;
            this.qualificationLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.qualificationLabel.Location = new System.Drawing.Point(17, 332);
            this.qualificationLabel.Name = "qualificationLabel";
            this.qualificationLabel.Size = new System.Drawing.Size(86, 17);
            this.qualificationLabel.TabIndex = 43;
            this.qualificationLabel.Text = "Qualification";
            // 
            // qualificationTextBox
            // 
            this.qualificationTextBox.Location = new System.Drawing.Point(110, 332);
            this.qualificationTextBox.Name = "qualificationTextBox";
            this.qualificationTextBox.Size = new System.Drawing.Size(205, 22);
            this.qualificationTextBox.TabIndex = 42;
            // 
            // expDatePicker
            // 
            this.expDatePicker.Enabled = false;
            this.expDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expDatePicker.Location = new System.Drawing.Point(427, 332);
            this.expDatePicker.Name = "expDatePicker";
            this.expDatePicker.Size = new System.Drawing.Size(124, 22);
            this.expDatePicker.TabIndex = 44;
            // 
            // expiresCheckBox
            // 
            this.expiresCheckBox.AutoSize = true;
            this.expiresCheckBox.Location = new System.Drawing.Point(345, 332);
            this.expiresCheckBox.Name = "expiresCheckBox";
            this.expiresCheckBox.Size = new System.Drawing.Size(76, 21);
            this.expiresCheckBox.TabIndex = 45;
            this.expiresCheckBox.Text = "Expires";
            this.expiresCheckBox.UseVisualStyleBackColor = true;
            this.expiresCheckBox.CheckedChanged += new System.EventHandler(this.expiresCheckBox_CheckedChanged);
            // 
            // qualAddButton
            // 
            this.qualAddButton.Location = new System.Drawing.Point(567, 332);
            this.qualAddButton.Name = "qualAddButton";
            this.qualAddButton.Size = new System.Drawing.Size(75, 23);
            this.qualAddButton.TabIndex = 46;
            this.qualAddButton.Text = "Add";
            this.qualAddButton.UseVisualStyleBackColor = true;
            this.qualAddButton.Click += new System.EventHandler(this.qualAddButton_Click);
            // 
            // qualListBox
            // 
            this.qualListBox.FormattingEnabled = true;
            this.qualListBox.ItemHeight = 16;
            this.qualListBox.Location = new System.Drawing.Point(22, 359);
            this.qualListBox.Name = "qualListBox";
            this.qualListBox.Size = new System.Drawing.Size(399, 84);
            this.qualListBox.TabIndex = 47;
            // 
            // TEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 487);
            this.Controls.Add(this.qualListBox);
            this.Controls.Add(this.qualAddButton);
            this.Controls.Add(this.expiresCheckBox);
            this.Controls.Add(this.expDatePicker);
            this.Controls.Add(this.qualificationLabel);
            this.Controls.Add(this.qualificationTextBox);
            this.Controls.Add(this.payslipComboBox);
            this.Controls.Add(this.payslipLabel);
            this.Controls.Add(this.empStatusComboBox);
            this.Controls.Add(this.empStatusLabel);
            this.Controls.Add(this.employCatComboBox);
            this.Controls.Add(this.employmentCatLabel);
            this.Controls.Add(this.empBasisComboBox);
            this.Controls.Add(this.employBasisLabel);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.postcodeLabel);
            this.Controls.Add(this.postcodeTextBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.accoutnNumberTextBox);
            this.Controls.Add(this.bsbLabel);
            this.Controls.Add(this.bsbTextBox);
            this.Controls.Add(this.taxTableComboBox);
            this.Controls.Add(this.taxTableLabel);
            this.Controls.Add(this.taxFileLabel);
            this.Controls.Add(this.TaxFileTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.employeeIdLabel);
            this.Controls.Add(this.EmployeeIdTextBox);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.givenNamesLabel);
            this.Controls.Add(this.givenNamesTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.submitButton);
            this.Name = "TEC";
            this.Text = "Tanda Employee Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label givenNamesLabel;
        private System.Windows.Forms.TextBox givenNamesTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label employeeIdLabel;
        private System.Windows.Forms.TextBox EmployeeIdTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label taxFileLabel;
        private System.Windows.Forms.TextBox TaxFileTextBox;
        private System.Windows.Forms.ComboBox taxTableComboBox;
        private System.Windows.Forms.Label taxTableLabel;
        private System.Windows.Forms.Label bsbLabel;
        private System.Windows.Forms.TextBox bsbTextBox;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.TextBox accoutnNumberTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label postcodeLabel;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.ComboBox empBasisComboBox;
        private System.Windows.Forms.Label employBasisLabel;
        private System.Windows.Forms.ComboBox employCatComboBox;
        private System.Windows.Forms.Label employmentCatLabel;
        private System.Windows.Forms.ComboBox empStatusComboBox;
        private System.Windows.Forms.Label empStatusLabel;
        private System.Windows.Forms.ComboBox payslipComboBox;
        private System.Windows.Forms.Label payslipLabel;
        private System.Windows.Forms.Label qualificationLabel;
        private System.Windows.Forms.TextBox qualificationTextBox;
        private System.Windows.Forms.DateTimePicker expDatePicker;
        private System.Windows.Forms.CheckBox expiresCheckBox;
        private System.Windows.Forms.Button qualAddButton;
        private System.Windows.Forms.ListBox qualListBox;
    }
}

