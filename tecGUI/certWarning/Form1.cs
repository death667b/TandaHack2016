﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace certWarning
{
    public partial class Form1 : Form
    {

        private string listString;
        private string empName;
        private string empNumber;
        private string certification;
        private string expiryDate;
        private int expireDays;
        
        public Form1()
        {
            InitializeComponent();
        }

        /*
        public Form1(String str)
        {

            InitializeComponent();
            listString = str;
            
        }
        */
        public static string readFile()
        {


            List<string> list = new List<string>();

            //list =  pushToExt.readFromFile();

            // index 1 = First Name
            // index 2 = Last Name
            // index 21 = Qual1 Date
            // index 22 = Qual2 Date
            // index 23 = Qual3 Date
            // index 0 = Employee ID

            list.Add("EmployeeID1, FirstName, LastName, Email, Male, (DOB)23/04/2016, TaxFileNumber, Tax Free Threshold, PhoneNumber, BSB, AccountNumber, AddressLine1, AddressLine2, AddressLine3, City, State, Postcode, (StartDate)23/04/2016, Individual, Full-Time, To Be Printed, Qualification1 23/04/2016, Qualification2 23/04/2016, Qualification3 23/04/2016");
            list.Add("EmployeeID2, FirstName, LastName, Email, Male, (DOB)23/04/2016, TaxFileNumber, Tax Free Threshold, PhoneNumber, BSB, AccountNumber, AddressLine1, AddressLine2, AddressLine3, City, State, Postcode, (StartDate)23/04/2016, Individual, Full-Time, To Be Printed, Qualification1 23/04/2016, Qualification2 23/04/2016, Qualification3 23/04/2016");
            list.Add("EmployeeID3, FirstName, LastName, Email, Male, (DOB)23/04/2016, TaxFileNumber, Tax Free Threshold, PhoneNumber, BSB, AccountNumber, AddressLine1, AddressLine2, AddressLine3, City, State, Postcode, (StartDate)23/04/2016, Individual, Full-Time, To Be Printed, Qualification1 23/04/2016, Qualification2 23/04/2016, Qualification3 23/04/2016");
            list.Add("EmployeeID4, FirstName, LastName, Email, Male, (DOB)23/04/2016, TaxFileNumber, Tax Free Threshold, PhoneNumber, BSB, AccountNumber, AddressLine1, AddressLine2, AddressLine3, City, State, Postcode, (StartDate)23/04/2016, Individual, Full-Time, To Be Printed, Qualification1 23/04/2016, Qualification2 23/04/2016, Qualification3 23/04/2016");
            list.Add("EmployeeID5, FirstName, LastName, Email, Male, (DOB)23/04/2016, TaxFileNumber, Tax Free Threshold, PhoneNumber, BSB, AccountNumber, AddressLine1, AddressLine2, AddressLine3, City, State, Postcode, (StartDate)23/04/2016, Individual, Full-Time, To Be Printed, Qualification1 23/04/2016, Qualification2 23/04/2016, Qualification3 23/04/2016");



            //   string details = "EmployeeID1, FirstName, LastName, Email, Male, (DOB)23/04/2016, TaxFileNumber, Tax Free Threshold, PhoneNumber, BSB, AccountNumber, AddressLine1, AddressLine2, AddressLine3, City, State, Postcode, (StartDate)23/04/2016, Individual, Full-Time, To Be Printed, Qualification1 23/04/2016, Qualification2 23/04/2016, Qualification3 23/04/2016";

            //foreach (string employee_data in list)
            //{
            List<string> details_list = list.ElementAt(0).Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();


            //}

            string data_employee = details_list.ElementAt(0);
            string firstName = details_list.ElementAt(1);
            string lastName = details_list.ElementAt(2);

            string[] data_Qual1 = details_list.ElementAt(21).Split(' ');
            string[] data_Qual2 = details_list.ElementAt(22).Split(' ');
            string[] data_Qual3 = details_list.ElementAt(23).Split(' ');

            System.Console.WriteLine(data_employee);
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(lastName);


            System.Console.WriteLine(data_Qual1[0]);
            System.Console.WriteLine(data_Qual1[1]);




            return null;


            //    string readFile = System.IO.File.ReadAllText(@"C:\Testing\testText.txt");
            //    System.Console.WriteLine("This is a test");
            //    System.Console.WriteLine("Contents of testText.txt = {0}", readFile);

            //    string[] var = {"Brendan", "Clohesy", "050279", };
            //    System.Console.WriteLine("First: {0} Second: {1} Third: {2}", var[0], var[1], var[2]);   




        }   // end readFile()

    }

}
