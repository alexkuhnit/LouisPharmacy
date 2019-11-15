using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;

namespace FinalProject
{
    class PharmacyDataTier
    {
        static String connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        static SqlConnection myConn = new SqlConnection(connString);
        static System.Data.SqlClient.SqlCommand cmdString = new System.Data.SqlClient.SqlCommand();

        public DataSet AddPhysicians(string fName, string mInit, string lName, string office, string phoneNum, int licenseNum)
        {
            try
            {
                //open connection
                myConn.Open();
                //Clear command argument
                cmdString.Parameters.Clear();
                //command
                cmdString.Connection = myConn;
                cmdString.CommandText = connString;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "AddPhysician";

                //define input parameter
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fName;
                cmdString.Parameters.Add("@minit", SqlDbType.VarChar, 1).Value = mInit;
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = lName;
                cmdString.Parameters.Add("@office", SqlDbType.VarChar, 60).Value = office;
                cmdString.Parameters.Add("@phoneNum", SqlDbType.VarChar, 10).Value = phoneNum;
                cmdString.Parameters.Add("@licenseNum", SqlDbType.Int).Value = licenseNum;

                //adapter and dataset
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();

                //filladapter
                aAdapter.Fill(aDataSet);
                //return data set
                return aDataSet;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }

        //add patient
        public DataSet AddPatient(string fName, string lName,string mInit, DateTime DOB,
                                    string gender,string street1,string street2,string city,
                                    string state,string zip, string homePhone, string workPhone, 
                                    string cellPhone, string email)
        {
            try
            {
                //open connection
                myConn.Open();
                //Clear command argument
                cmdString.Parameters.Clear();
                //command
                cmdString.Connection = myConn;
                cmdString.CommandText = connString;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "AddPatient";

                //define input parameters
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fName;
                cmdString.Parameters.Add("@minit", SqlDbType.VarChar, 1).Value = mInit;
                cmdString.Parameters.Add("@lName", SqlDbType.VarChar, 25).Value = lName;
                cmdString.Parameters.Add("@DOB", SqlDbType.Date).Value = DOB;

                cmdString.Parameters.Add("@gender", SqlDbType.VarChar, 6).Value = gender;
                cmdString.Parameters.Add("@street1", SqlDbType.VarChar, 30).Value = street1;
                cmdString.Parameters.Add("@street2", SqlDbType.VarChar, 30).Value = street2;
                cmdString.Parameters.Add("@city", SqlDbType.VarChar, 13).Value = city;

                cmdString.Parameters.Add("@state", SqlDbType.Char, 2).Value = state;
                cmdString.Parameters.Add("@zip", SqlDbType.Char, 5).Value = zip;
                cmdString.Parameters.Add("@homePhone", SqlDbType.Char, 10).Value = homePhone;
                cmdString.Parameters.Add("@workPhone", SqlDbType.Char, 10).Value = workPhone;

                cmdString.Parameters.Add("@cellPhone", SqlDbType.Char, 10).Value = cellPhone;
                cmdString.Parameters.Add("@email", SqlDbType.VarChar, 75).Value = email;

                //adapter and dataset
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();

                //filladapter
                aAdapter.Fill(aDataSet);
                //return data set
                return aDataSet;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }
        public DataSet AddPrescription(string NDCPackageCode, string patientID, string physicianID, string totalRefills, DateTime time)
        {
            try
            {
                //open connection
                myConn.Open();
                //Clear command argument
                cmdString.Parameters.Clear();
                //command
                cmdString.Connection = myConn;
                cmdString.CommandText = connString;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "AddPrescription";

                //define input parameters
                cmdString.Parameters.Add("@NDCPackageCode", SqlDbType.VarChar, 11).Value = NDCPackageCode;
                cmdString.Parameters.Add("@patientID", SqlDbType.Int).Value = patientID;
                cmdString.Parameters.Add("@physicianID", SqlDbType.Int).Value = physicianID;
                cmdString.Parameters.Add("@totalRefills", SqlDbType.Int).Value = totalRefills;
                cmdString.Parameters.Add("@remainingRefills", SqlDbType.Int).Value = totalRefills;

                cmdString.Parameters.Add("@time", SqlDbType.DateTime).Value = time;

                //adapter and dataset
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();

                //filladapter
                aAdapter.Fill(aDataSet);
                //return data set
                return aDataSet;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }


    }
}
