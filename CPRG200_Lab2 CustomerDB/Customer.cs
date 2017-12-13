using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG200_Lab2_CustomerDB
{
    //**********************************************************************
    //**********************************************************************

    //CUSTOMER CLASS
    //Author: Dean Jones
    //Date: Nov.26, 2016

    //**********************************************************************
    //**********************************************************************

    class Customer
    {
        // COUNTERS
        private static int custResCount = 0;        //Residential Count Only
        private static int custComCount = 0;        //Commercial Count Only
        private static int custIndCount = 0;        //Industrial Count Only
        private static int custCount = -1;          //TOTAL Customer Count

        // CHARGES (by Type)
        private static decimal custResCharges = 0;  //Residential Charges
        private static decimal custComCharges = 0;  //Commercial Charges
        private static decimal custIndCharges = 0;  //Industrial Charges
        private static decimal custTotalCharges = 0;    //TOTAL Charges

        // CONSTANTS (CUSTOMER TYPES)
        const string CUSTOMER_RES = "R";      //Residential
        const string CUSTOMER_COM = "C";      //Commercial
        const string CUSTOMER_IND = "I";      //Industrial

        // PROPERTIES (private, use getters and setters)
        private int custId;                     //customer Id (account#)(primary key)
        private string custFirstName;           //customer first name
        private string custLastName;            //customer last name
        private string custType;                //customer type (res, com, ind)
        private decimal custChargeAmount;       //customer charge amount ($)


        /// <summary>
        /// DEFAULT CONSTRUCTOR
        /// </summary>
        public Customer()                       //default constructor
        {
            countCustomerType();                //Count the RES, COM, IND customers.
            custCount++;                        //Counts the number of customers as they are created.

            chargesCustomerType();              //Tallies CHARGES (by TYPE)
            chargesCustomerAll();               //Tallies CHARGES (ALL TYPES)
        }

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public Customer(string fname, string lname, string type)
        {
            custFirstName = fname;              //set first name
            custLastName = lname;               //set last name
            custType = type;                    //set customer type

            countCustomerType();                //Count the RES, COM, IND customers.
            custCount++;                        //Counts the number of customers as they are created.

            chargesCustomerType();              //Tallies CHARGES (by TYPE)
            chargesCustomerAll();               //Tallies CHARGES (ALL TYPES)
        }

        /// <summary>
        /// COUNT (tallies the customers, by TYPE)
        /// </summary>
        public void countCustomerType()
        {
            switch (custType)
            {
                case "R":
                    custResCount++;     //Update count for RESIDENTIAL customer
                    break;
                case "C":
                    custComCount++;     //Update count for COMMERCIAL customer
                    break;
                case "I":
                    custIndCount++;     //Update count for INDUSTRIAL customer
                    break;
                default:
                    //MessageBox.Show("Something is wrong with custType property?");
                    break;
            }
        }

        /// <summary>
        /// CHARGES (tallies the customer charges, by TYPE)
        /// </summary>
        public void chargesCustomerType()
        {
            switch (custType)
            {
                case "R":
                    custResCharges += custChargeAmount;     //Adds current charges to RESIDENTIAL CHARGES
                    break;
                case "C":
                    custComCharges += custChargeAmount;     //Adds current charges to COMMERCIAL CHARGES
                    break;
                case "I":
                    custIndCharges += custChargeAmount;     //Adds current charges to INDUSTRIAL CHARGES
                    break;
                default:
                    //MessageBox.Show("Something is wrong with custType property?");
                    break;
            }
        }

        /// <summary>
        /// CHARGES (tallies TOTAL customer charges, ALL TYPES)
        /// </summary>
        public void chargesCustomerAll()
        {
            custTotalCharges += custChargeAmount;     //Adds current charges to ALL CHARGES
        }

        /// <summary>
        /// Counts the number of Customer objects
        /// </summary>
        public static int CustCount
        {
            get
            {
                return custCount;
            }           
        }

        /// <summary>
        /// Counts the number of Customer RESIDENTIAL objects
        /// </summary>
        public static int CustResCount
        {
            get
            {
                return custResCount;
            }
        }

        /// <summary>
        /// Counts the number of Customer COMMERCIAL objects
        /// </summary>
        public static int CustComCount
        {
            get
            {
                return custComCount;
            }
        }

        /// <summary>
        /// Counts the number of Customer INDUSTRIAL objects
        /// </summary>
        public static int CustIndCount
        {
            get
            {
                return custIndCount;
            }
        }

        /// <summary>
        /// Tallies CHARGES for Customer RESIDENTIAL objects
        /// </summary>
        public static decimal CustResCharges
        {
            get
            {
                return custResCharges;
            }
        }

        /// <summary>
        /// Tallies CHARGES for Customer COMMERCIAL objects
        /// </summary>
        public static decimal CustComCharges
        {
            get
            {
                return custComCharges;
            }
        }

        /// <summary>
        /// Tallies CHARGES for Customer INDUSTRIAL objects
        /// </summary>
        public static decimal CustIndCharges
        {
            get
            {
                return custIndCharges;
            }
        }

        /// <summary>
        /// Tallies CHARGES for Customer ALL objects
        /// </summary>
        public static decimal CustTotalCharges
        {
            get
            {
                return custTotalCharges;
            }
        }

        /// <summary>
        /// Customer ID (account#)(read-only)
        /// </summary>
        public int CustId
        {
            get
            {                
                return custId;
            }
            set
            {
                custId = value;
            }
        }
        
        /// <summary>
        /// Customer's first name
        /// </summary>
        public string CustFirstName
        {
            get
            {
                return custFirstName;
            }
            set
            {
                custFirstName = value;
            }
        }

        /// <summary>
        /// Customer's last name
        /// </summary>
        public string CustLastName
        {
            get
            {
                return custLastName;
            }
            set
            {
                custLastName = value;
            }
        }

        /// <summary>
        /// Customer's type ("R" = residential, "C" = commercial, "I" = industrial)
        /// </summary>
        public string CustType
        {
            get
            {
                return custType;
            }
            set
            {
                //custType = value;
                switch (value.ToUpper())
                {
                    case "R":
                    case "C":
                    case "I":
                        custType = value;
                        break;
                    default:
                        MessageBox.Show("The customer type needs to be RES, COM, or IND", "Customer type error");
                        break;
                }
            }
        }

        /// <summary>
        /// Customer's charge amount (use calculator to get total $)
        /// </summary>
        public decimal CustChargeAmount
        {
            get
            {
                return custChargeAmount;
            }
            set
            {
                custChargeAmount = value;
            }
        }

    /// <summary>
    /// String of Customer properties (in CSV comma separated format)
    /// </summary>
    public override string ToString()   //OVERRIDE inherited method ToString (Object Class)
        {
            return custId.ToString() + "\t"
                + custFirstName + "\t"
                + custLastName + "\t"
                + custType + "\t"
                + custChargeAmount.ToString();   //String to be written to file (Customer.txt)
                //+ custChargeAmount.ToString("c");   //String to be written to file (Customer.txt)

            //return custId.ToString() + ","
            //    + custFirstName + ","
            //    + custLastName + ","
            //    + custType + ","
            //    + custChargeAmount.ToString();   //String to be written to file (Customer.txt)
        }

    }
}
