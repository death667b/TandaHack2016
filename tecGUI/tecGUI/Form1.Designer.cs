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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkQualificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(483, 448);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(125, 25);
            this.submitButton.TabIndex = 50;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(104, 37);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(205, 22);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 37);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // givenNamesLabel
            // 
            this.givenNamesLabel.AutoSize = true;
            this.givenNamesLabel.Location = new System.Drawing.Point(320, 37);
            this.givenNamesLabel.Name = "givenNamesLabel";
            this.givenNamesLabel.Size = new System.Drawing.Size(93, 17);
            this.givenNamesLabel.TabIndex = 4;
            this.givenNamesLabel.Text = "Given Names";
            // 
            // givenNamesTextBox
            // 
            this.givenNamesTextBox.Location = new System.Drawing.Point(432, 37);
            this.givenNamesTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.givenNamesTextBox.Name = "givenNamesTextBox";
            this.givenNamesTextBox.Size = new System.Drawing.Size(205, 22);
            this.givenNamesTextBox.TabIndex = 3;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 74);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 6;
            this.addressLabel.Text = "Address";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(104, 74);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(320, 64);
            this.AddressTextBox.TabIndex = 5;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(12, 222);
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
            this.genderComboBox.Location = new System.Drawing.Point(104, 222);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 24);
            this.genderComboBox.TabIndex = 9;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(12, 261);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(87, 17);
            this.dobLabel.TabIndex = 10;
            this.dobLabel.Text = "Date of Birth";
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(104, 261);
            this.dateOfBirthPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(200, 22);
            this.dateOfBirthPicker.TabIndex = 10;
            // 
            // employeeIdLabel
            // 
            this.employeeIdLabel.AutoSize = true;
            this.employeeIdLabel.Location = new System.Drawing.Point(676, 37);
            this.employeeIdLabel.Name = "employeeIdLabel";
            this.employeeIdLabel.Size = new System.Drawing.Size(85, 17);
            this.employeeIdLabel.TabIndex = 13;
            this.employeeIdLabel.Text = "Employee Id";
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(796, 37);
            this.EmployeeIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(205, 22);
            this.EmployeeIdTextBox.TabIndex = 11;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(676, 76);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(103, 17);
            this.phoneNumberLabel.TabIndex = 15;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(796, 76);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(205, 22);
            this.phoneNumberTextBox.TabIndex = 12;
            // 
            // taxFileLabel
            // 
            this.taxFileLabel.AutoSize = true;
            this.taxFileLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.taxFileLabel.Location = new System.Drawing.Point(676, 344);
            this.taxFileLabel.Name = "taxFileLabel";
            this.taxFileLabel.Size = new System.Drawing.Size(111, 17);
            this.taxFileLabel.TabIndex = 17;
            this.taxFileLabel.Text = "Tax File Number";
            // 
            // TaxFileTextBox
            // 
            this.TaxFileTextBox.Location = new System.Drawing.Point(796, 344);
            this.TaxFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaxFileTextBox.Name = "TaxFileTextBox";
            this.TaxFileTextBox.Size = new System.Drawing.Size(205, 22);
            this.TaxFileTextBox.TabIndex = 20;
            // 
            // taxTableComboBox
            // 
            this.taxTableComboBox.FormattingEnabled = true;
            this.taxTableComboBox.Items.AddRange(new object[] {
            "Tax Free Threshold",
            "Non-Tax Free Threshold"});
            this.taxTableComboBox.Location = new System.Drawing.Point(796, 380);
            this.taxTableComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taxTableComboBox.Name = "taxTableComboBox";
            this.taxTableComboBox.Size = new System.Drawing.Size(121, 24);
            this.taxTableComboBox.TabIndex = 21;
            // 
            // taxTableLabel
            // 
            this.taxTableLabel.AutoSize = true;
            this.taxTableLabel.Location = new System.Drawing.Point(676, 380);
            this.taxTableLabel.Name = "taxTableLabel";
            this.taxTableLabel.Size = new System.Drawing.Size(71, 17);
            this.taxTableLabel.TabIndex = 18;
            this.taxTableLabel.Text = "Tax Table";
            // 
            // bsbLabel
            // 
            this.bsbLabel.AutoSize = true;
            this.bsbLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.bsbLabel.Location = new System.Drawing.Point(12, 293);
            this.bsbLabel.Name = "bsbLabel";
            this.bsbLabel.Size = new System.Drawing.Size(35, 17);
            this.bsbLabel.TabIndex = 21;
            this.bsbLabel.Text = "BSB";
            // 
            // bsbTextBox
            // 
            this.bsbTextBox.Location = new System.Drawing.Point(104, 293);
            this.bsbTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bsbTextBox.Name = "bsbTextBox";
            this.bsbTextBox.Size = new System.Drawing.Size(205, 22);
            this.bsbTextBox.TabIndex = 18;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.accountNumberLabel.Location = new System.Drawing.Point(339, 293);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(113, 17);
            this.accountNumberLabel.TabIndex = 23;
            this.accountNumberLabel.Text = "Account Number";
            // 
            // accoutnNumberTextBox
            // 
            this.accoutnNumberTextBox.Location = new System.Drawing.Point(458, 293);
            this.accoutnNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accoutnNumberTextBox.Name = "accoutnNumberTextBox";
            this.accoutnNumberTextBox.Size = new System.Drawing.Size(205, 22);
            this.accoutnNumberTextBox.TabIndex = 19;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 156);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 17);
            this.cityLabel.TabIndex = 25;
            this.cityLabel.Text = "City";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(104, 154);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(320, 22);
            this.cityTextBox.TabIndex = 6;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(12, 190);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(41, 17);
            this.stateLabel.TabIndex = 27;
            this.stateLabel.Text = "State";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(104, 190);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(85, 22);
            this.stateTextBox.TabIndex = 7;
            // 
            // postcodeLabel
            // 
            this.postcodeLabel.AutoSize = true;
            this.postcodeLabel.Location = new System.Drawing.Point(247, 190);
            this.postcodeLabel.Name = "postcodeLabel";
            this.postcodeLabel.Size = new System.Drawing.Size(67, 17);
            this.postcodeLabel.TabIndex = 29;
            this.postcodeLabel.Text = "Postcode";
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.Location = new System.Drawing.Point(340, 190);
            this.postcodeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(85, 22);
            this.postcodeTextBox.TabIndex = 8;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(676, 120);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 31;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(796, 120);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(205, 22);
            this.emailTextBox.TabIndex = 13;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(796, 423);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 22);
            this.startDatePicker.TabIndex = 22;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.startDateLabel.Location = new System.Drawing.Point(676, 423);
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
            this.empBasisComboBox.Location = new System.Drawing.Point(847, 206);
            this.empBasisComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empBasisComboBox.Name = "empBasisComboBox";
            this.empBasisComboBox.Size = new System.Drawing.Size(121, 24);
            this.empBasisComboBox.TabIndex = 14;
            // 
            // employBasisLabel
            // 
            this.employBasisLabel.AutoSize = true;
            this.employBasisLabel.Location = new System.Drawing.Point(676, 206);
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
            this.employCatComboBox.Location = new System.Drawing.Point(847, 234);
            this.employCatComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employCatComboBox.Name = "employCatComboBox";
            this.employCatComboBox.Size = new System.Drawing.Size(121, 24);
            this.employCatComboBox.TabIndex = 15;
            // 
            // employmentCatLabel
            // 
            this.employmentCatLabel.AutoSize = true;
            this.employmentCatLabel.Location = new System.Drawing.Point(676, 234);
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
            this.empStatusComboBox.Location = new System.Drawing.Point(847, 261);
            this.empStatusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empStatusComboBox.Name = "empStatusComboBox";
            this.empStatusComboBox.Size = new System.Drawing.Size(121, 24);
            this.empStatusComboBox.TabIndex = 16;
            // 
            // empStatusLabel
            // 
            this.empStatusLabel.AutoSize = true;
            this.empStatusLabel.Location = new System.Drawing.Point(676, 261);
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
            this.payslipComboBox.Location = new System.Drawing.Point(847, 286);
            this.payslipComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payslipComboBox.Name = "payslipComboBox";
            this.payslipComboBox.Size = new System.Drawing.Size(121, 24);
            this.payslipComboBox.TabIndex = 17;
            // 
            // payslipLabel
            // 
            this.payslipLabel.AutoSize = true;
            this.payslipLabel.Location = new System.Drawing.Point(676, 286);
            this.payslipLabel.Name = "payslipLabel";
            this.payslipLabel.Size = new System.Drawing.Size(108, 17);
            this.payslipLabel.TabIndex = 40;
            this.payslipLabel.Text = "Payslip Delivery";
            // 
            // qualificationLabel
            // 
            this.qualificationLabel.AutoSize = true;
            this.qualificationLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.qualificationLabel.Location = new System.Drawing.Point(12, 344);
            this.qualificationLabel.Name = "qualificationLabel";
            this.qualificationLabel.Size = new System.Drawing.Size(86, 17);
            this.qualificationLabel.TabIndex = 43;
            this.qualificationLabel.Text = "Qualification";
            // 
            // qualificationTextBox
            // 
            this.qualificationTextBox.Location = new System.Drawing.Point(104, 344);
            this.qualificationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qualificationTextBox.Name = "qualificationTextBox";
            this.qualificationTextBox.Size = new System.Drawing.Size(205, 22);
            this.qualificationTextBox.TabIndex = 23;
            // 
            // expDatePicker
            // 
            this.expDatePicker.Enabled = false;
            this.expDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expDatePicker.Location = new System.Drawing.Point(422, 344);
            this.expDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expDatePicker.Name = "expDatePicker";
            this.expDatePicker.Size = new System.Drawing.Size(124, 22);
            this.expDatePicker.TabIndex = 25;
            // 
            // expiresCheckBox
            // 
            this.expiresCheckBox.AutoSize = true;
            this.expiresCheckBox.Location = new System.Drawing.Point(340, 344);
            this.expiresCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expiresCheckBox.Name = "expiresCheckBox";
            this.expiresCheckBox.Size = new System.Drawing.Size(76, 21);
            this.expiresCheckBox.TabIndex = 24;
            this.expiresCheckBox.Text = "Expires";
            this.expiresCheckBox.UseVisualStyleBackColor = true;
            this.expiresCheckBox.CheckedChanged += new System.EventHandler(this.expiresCheckBox_CheckedChanged);
            // 
            // qualAddButton
            // 
            this.qualAddButton.Location = new System.Drawing.Point(562, 344);
            this.qualAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.qualListBox.Location = new System.Drawing.Point(16, 371);
            this.qualListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qualListBox.Name = "qualListBox";
            this.qualListBox.Size = new System.Drawing.Size(399, 84);
            this.qualListBox.TabIndex = 47;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.checkQualificationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1075, 28);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // checkQualificationsToolStripMenuItem
            // 
            this.checkQualificationsToolStripMenuItem.Name = "checkQualificationsToolStripMenuItem";
            this.checkQualificationsToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.checkQualificationsToolStripMenuItem.Text = "Check Qualifications";
            this.checkQualificationsToolStripMenuItem.Click += new System.EventHandler(this.checkQualificationsToolStripMenuItem_Click);
            // 
            // TEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 504);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TEC";
            this.Text = "Tanda Employee Card";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkQualificationsToolStripMenuItem;
    }
}

