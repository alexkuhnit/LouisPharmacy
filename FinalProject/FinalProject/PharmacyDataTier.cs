using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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
        public DataSet AddPatient(string fName, string lName, string mInit, DateTime DOB,
                                    string gender, string street1, string street2, string city,
                                    string state, string zip, string homePhone, string workPhone,
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
        public DataSet AddRefill(string prescriptionID, DateTime time)
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
                cmdString.CommandText = "AddRefill";

                //define input parameters
                cmdString.Parameters.Add("@prescriptionID", SqlDbType.Int).Value = prescriptionID;
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
        public DataSet GetPatient(string fName, string lName, string patientID)
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
                cmdString.CommandText = "SearchPatient";

                //define input parameters
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fName;
                cmdString.Parameters.Add("@lName", SqlDbType.VarChar, 25).Value = lName;
                cmdString.Parameters.Add("@patientID", SqlDbType.VarChar, 25).Value = patientID;

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
        public DataSet GetPhysician(string fName, string lName, string physicianID)
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
                cmdString.CommandText = "SearchPhysician";

                //define input parameters
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fName;
                cmdString.Parameters.Add("@lName", SqlDbType.VarChar, 25).Value = lName;
                cmdString.Parameters.Add("@physicianID", SqlDbType.VarChar, 25).Value = physicianID;

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
        public DataSet FillPatient()
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
                cmdString.CommandText = "FillPatient";

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
        public DataSet GetPrescription(string patientID)
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
                cmdString.CommandText = "SearchPrescription";

                //define input parameters
                cmdString.Parameters.Add("@patientID", SqlDbType.VarChar, 25).Value = patientID;

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
        public DataSet GetFulfillment(string fulfillmentID)
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
                cmdString.CommandText = "GetFulfillment";

                //define input parameters
                cmdString.Parameters.Add("@fulfillmentID", SqlDbType.Int).Value = fulfillmentID;

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
        public DataSet UpdatePatient(string patientID, string fName, string lName, string mInit, DateTime DOB,
                                    string gender, string street1, string street2, string city,
                                    string state, string zip, string homePhone, string workPhone,
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
                cmdString.CommandText = "UpdatePatient";

                //define input parameters
                cmdString.Parameters.Add("@patientID", SqlDbType.VarChar, 25).Value = patientID;
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
        public DataSet UpdatePhysicians(string physicianID, string fName, string mInit, string lName, string office, string phoneNum, int licenseNum)
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
                cmdString.CommandText = "UpdatePhysician";

                //define input parameter
                cmdString.Parameters.Add("@physicianID", SqlDbType.Int).Value = physicianID;
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
        public DataSet GetPrescriptionPID(string prescriptionID)
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
                cmdString.CommandText = "SearchPrescriptionPrescriptionID";

                //define input parameters
                cmdString.Parameters.Add("@prescriptionID", SqlDbType.VarChar, 25).Value = prescriptionID;

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
        public DataSet GetRefills(string prescriptionID)
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
                cmdString.CommandText = "searchRefills";

                //define input parameters
                cmdString.Parameters.Add("@prescriptionID", SqlDbType.Int).Value = prescriptionID;

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
        public DataSet UpdatePrescription(string prescriptionID, string NDCPackageCode, string patientID, string physicianID, string totalRefills, DateTime time)
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
                cmdString.CommandText = "UpdatePrescription";

                //define input parameters
                cmdString.Parameters.Add("@prescriptionID", SqlDbType.Int).Value = prescriptionID;
                cmdString.Parameters.Add("@NDCPackageCode", SqlDbType.VarChar, 11).Value = NDCPackageCode;
                cmdString.Parameters.Add("@patientID", SqlDbType.Int).Value = patientID;
                cmdString.Parameters.Add("@physicianID", SqlDbType.Int).Value = physicianID;
                cmdString.Parameters.Add("@totalRefills", SqlDbType.Int).Value = totalRefills;
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
        public DataSet UpdateFulfillment(string fulfillmentID, string originalPrescriptionID, string prescriptionID, DateTime time)
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
                cmdString.CommandText = "UpdateFulfillment";

                //define input parameters
                cmdString.Parameters.Add("@fulfillmentID", SqlDbType.Int).Value = fulfillmentID;
                cmdString.Parameters.Add("@originalPrescriptionID", SqlDbType.Int).Value = originalPrescriptionID;
                cmdString.Parameters.Add("@prescriptionID", SqlDbType.Int).Value = prescriptionID;
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
        public DataSet DeleteRefill(string fulfillmentID)
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
                cmdString.CommandText = "removeRefill";

                //define input parameters
                cmdString.Parameters.Add("@fulfillmentID", SqlDbType.Int).Value = fulfillmentID;

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
        public DataSet DeletePrescription(string prescriptionID)
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
                cmdString.CommandText = "RemovePrescription";

                //define input parameters
                cmdString.Parameters.Add("@prescriptionID", SqlDbType.Int).Value = prescriptionID;

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
        public DataSet DeletePatient(string patientID)
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
                cmdString.CommandText = "RemovePatient";

                //define input parameters
                cmdString.Parameters.Add("@patientID", SqlDbType.Int).Value = patientID;

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
        public DataSet DeletePhysician(string physicianID)
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
                cmdString.CommandText = "RemovePhysician";

                //define input parameters
                cmdString.Parameters.Add("@physicianID", SqlDbType.Int).Value = physicianID;

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
        public DataSet FillCBOPatient(string patientID)
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
                cmdString.CommandText = "FillCBOPatient";

                //define input parameters
                cmdString.Parameters.Add("@patientID", SqlDbType.Int).Value = patientID;

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
        public DataSet FillCBODrug()
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
                cmdString.CommandText = "FillCBODrug";

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
        public DataSet FillCBOPhysician()
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
                cmdString.CommandText = "FillCBOPhysician";

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
