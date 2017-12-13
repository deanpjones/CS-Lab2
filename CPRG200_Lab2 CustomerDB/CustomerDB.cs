using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG200_Lab2_CustomerDB
{
    //**********************************************************************
    //**********************************************************************

    //CUSTOMER DATABASE CLASS
    //Author: Dean Jones
    //Date: Nov.26, 2016

    //**********************************************************************
    //**********************************************************************

    class CustomerDB
    {
        // FILE PATH (customer.txt)
        //const string path = "../../customer.txt";
        const string path = "Customers.txt";

        // LOAD LIST FROM CUSTOMER.TXT FILE
        public static List<Customer> Load()
        {
            FileStream fs = null;
            StreamReader sr = null;
            List<Customer> customersList = new List<Customer>();

            try
            {
                //FILE OPEN FOR READ
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                string line;            //each line of Customers.txt file
                string[] parts;         //each element of each line

                //while ((line = sr.ReadLine()) != null)
                while(!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    //parts = line.Split(',');
                    parts = line.Split('\t');


                    //ADD INFO FROM (customer.txt) BACK TO LIST
                    Customer c = new Customer();                        //creates a customer object
                    c.CustId = Convert.ToInt32(parts[0]);               //add account# to customer object (INTEGER)
                    c.CustFirstName = parts[1];                         //add first name
                    c.CustLastName = parts[2];                          //add last name
                    c.CustType = parts[3];                              //add customer type
                    c.CustChargeAmount = Convert.ToDecimal(parts[4]);   //add charge amount (DECIMAL)

                    //TALLY CUSTOMER TYPE COUNT
                    c.countCustomerType();
                  
                    c.chargesCustomerType();        //Tallies CHARGES (by TYPE)                     
                    c.chargesCustomerAll();         //Tallies CHARGES (ALL TYPES)                          

                    //ADD CUSTOMER TO LIST
                    customersList.Add(c);
                }

                MessageBox.Show("Data loaded successfully", "Load Data");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Could not find file " + path + ", the file will be created automatically.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + ": " + ex.Message);
            }
            finally
            {     
                if (sr != null) sr.Close(); // close the file             
            }
            return customersList;
        }

        // SAVE LIST TO CUSTOMER.TXT FILE
        public static void Save(List<Customer> customerList)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                //FILE OPEN FOR WRITE (use OpenOrCreate)
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                foreach (Customer c in customerList) // foreach CUSTOMER in the CUSTOMERLIST
                {
                    sw.WriteLine(c.ToString());
                }
                MessageBox.Show("Data written successfully", "Data Write");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Could not find file " + path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + ": " + ex.Message);
            }
            finally
            {
                if (sw != null) sw.Close(); // close the file
            }
        }
    }
}
