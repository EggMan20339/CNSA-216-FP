using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;


namespace FWA_MAIN
{
    public class PharmacyDataTier
    {
    
        static String connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        static SqlConnection myConn = new SqlConnection(connString);
        static System.Data.SqlClient.SqlCommand cmdString = new System.Data.SqlClient.SqlCommand();


        public static void UpdatePatient(
            string Patient_id,
            string FirstName,
            string LastName,
            string MiddleIntials,
            int lbs,
            int Height_feet,
            int Height_inches,
            DateTime DOB,
            string Gender,
            string City,
            Int16 Zip,
            string UsState,
            string PhoneNumber)
        {
            
            try
            {
                myConn.Open();

                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;

                cmdString.CommandText = "UpdatePatient";

                cmdString.Parameters.Add("@Patient_id", SqlDbType.VarChar, 8).Value = Patient_id;
                cmdString.Parameters.Add("@FirstName", SqlDbType.VarChar, 30).Value = FirstName;
                cmdString.Parameters.Add("@LastName", SqlDbType.VarChar, 30).Value = LastName;
                cmdString.Parameters.Add("@MiddleIntials", SqlDbType.VarChar).Value = MiddleIntials;
                cmdString.Parameters.Add("@lbs", SqlDbType.Int).Value = lbs;
                cmdString.Parameters.Add("@Height_feet", SqlDbType.Int).Value = Height_feet;
                cmdString.Parameters.Add("@Height_inches", SqlDbType.Int).Value = Height_inches;
                cmdString.Parameters.Add("@DOB", SqlDbType.DateTime).Value = DOB;
                cmdString.Parameters.Add("@Gender", SqlDbType.Char).Value = Gender;
                cmdString.Parameters.Add("@City", SqlDbType.VarChar, 30).Value = City;
                cmdString.Parameters.Add("@Zip", SqlDbType.SmallInt).Value = Zip;
                cmdString.Parameters.Add("@UsState", SqlDbType.Char, 2).Value = UsState;
                cmdString.Parameters.Add("@PhoneNumber", SqlDbType.Char,14).Value = PhoneNumber;

                cmdString.ExecuteNonQuery();

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
        
        
        public static void CreatePatient(
            string Patient_id,
            string FirstName,
            string LastName,
            string MiddleIntials,
            int lbs,
            int Height_feet,
            int Height_inches,
            DateTime DOB,
            string Gender,
            string City,
            Int16 Zip,
            string UsState,
            string PhoneNumber)
        {
            
            try
            {
                myConn.Open();

                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;

                cmdString.CommandText = "CreatePatient";

                cmdString.Parameters.Add("@Patient_id", SqlDbType.VarChar, 8).Value = Patient_id;
                cmdString.Parameters.Add("@FirstName", SqlDbType.VarChar, 30).Value = FirstName;
                cmdString.Parameters.Add("@LastName", SqlDbType.VarChar, 30).Value = LastName;
                cmdString.Parameters.Add("@MiddleIntials", SqlDbType.VarChar).Value = MiddleIntials;
                cmdString.Parameters.Add("@lbs", SqlDbType.Int).Value = lbs;
                cmdString.Parameters.Add("@Height_feet", SqlDbType.Int).Value = Height_feet;
                cmdString.Parameters.Add("@Height_inches", SqlDbType.Int).Value = Height_inches;
                cmdString.Parameters.Add("@DOB", SqlDbType.DateTime).Value = DOB;
                cmdString.Parameters.Add("@Gender", SqlDbType.Char).Value = Gender;
                cmdString.Parameters.Add("@City", SqlDbType.VarChar, 30).Value = City;
                cmdString.Parameters.Add("@Zip", SqlDbType.SmallInt).Value = Zip;
                cmdString.Parameters.Add("@UsState", SqlDbType.Char, 2).Value = UsState;
                cmdString.Parameters.Add("@PhoneNumber", SqlDbType.Char,14).Value = PhoneNumber;

                cmdString.ExecuteNonQuery();

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
        
        
        
        public static void CreatePhysician(
            string Physician_id,
            string FirstName,
            string LastName,
            string MiddleInit,
            DateTime DOB,
            string Gender,
            string City,
            Int16 Zip,
            string UsState,
            string PhoneNumber,
            string Speciality)

        {
            try
            {
                myConn.Open();

                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;

                cmdString.CommandText = "CreatePhysician";

                cmdString.Parameters.Add("@Physician_id", SqlDbType.VarChar, 8).Value = Physician_id;
                cmdString.Parameters.Add("@FirstName", SqlDbType.VarChar, 30).Value = FirstName;
                cmdString.Parameters.Add("@LastName", SqlDbType.VarChar, 30).Value = LastName;
                cmdString.Parameters.Add("@MiddleIntials", SqlDbType.VarChar).Value = MiddleInit;
                cmdString.Parameters.Add("@DOB", SqlDbType.DateTime).Value = DOB;
                cmdString.Parameters.Add("@Gender", SqlDbType.Char).Value = Gender;
                cmdString.Parameters.Add("@City", SqlDbType.VarChar, 30).Value = City;
                cmdString.Parameters.Add("@Zip", SqlDbType.SmallInt).Value = Zip;
                cmdString.Parameters.Add("@UsState", SqlDbType.VarChar, 2).Value = UsState;
                cmdString.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 14).Value = PhoneNumber;
                cmdString.Parameters.Add("@Speciality", SqlDbType.VarChar, 100).Value = Speciality;

                cmdString.ExecuteNonQuery();

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
        
        public static void UpdatePhysician(
            string Physician_id,
            string FirstName,
            string LastName,
            string MiddleInit,
            DateTime DOB,
            string Gender,
            string City,
            Int16 Zip,
            string UsState,
            string PhoneNumber,
            string Speciality)

        {
            try
            {
                myConn.Open();

                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;

                cmdString.CommandText = "UpdatePhysician";

                cmdString.Parameters.Add("@Physician_id", SqlDbType.VarChar, 8).Value = Physician_id;
                cmdString.Parameters.Add("@FirstName", SqlDbType.VarChar, 30).Value = FirstName;
                cmdString.Parameters.Add("@LastName", SqlDbType.VarChar, 30).Value = LastName;
                cmdString.Parameters.Add("@MiddleIntials", SqlDbType.VarChar).Value = MiddleInit;
                cmdString.Parameters.Add("@DOB", SqlDbType.DateTime).Value = DOB;
                cmdString.Parameters.Add("@Gender", SqlDbType.Char).Value = Gender;
                cmdString.Parameters.Add("@City", SqlDbType.VarChar, 30).Value = City;
                cmdString.Parameters.Add("@Zip", SqlDbType.SmallInt).Value = Zip;
                cmdString.Parameters.Add("@UsState", SqlDbType.VarChar, 2).Value = UsState;
                cmdString.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 14).Value = PhoneNumber;
                cmdString.Parameters.Add("@Speciality", SqlDbType.VarChar, 100).Value = Speciality;

                cmdString.ExecuteNonQuery();

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
        
        public static void UpdateMedication(
            string Medication_id,
            string MedicationName,
            string IntakeMethod,
            string Frequency,
            string Dosage,
            string Purpose,
            string RxNum)

        {
            try
            {
                myConn.Open();

                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;

                cmdString.CommandText = "UpdateMedication";

                cmdString.Parameters.Add("@Medication_id", SqlDbType.VarChar, 7).Value = Medication_id;
                cmdString.Parameters.Add("@MedicationName", SqlDbType.VarChar,60).Value = MedicationName;
                cmdString.Parameters.Add("@IntakeMethod", SqlDbType.VarChar,30).Value =IntakeMethod ;
                cmdString.Parameters.Add("@Frequency", SqlDbType.VarChar,30).Value =Frequency ;
                cmdString.Parameters.Add("@Dosage", SqlDbType.VarChar,30).Value = Dosage;
                cmdString.Parameters.Add("@Purpose", SqlDbType.VarChar,100).Value = Purpose;
                cmdString.Parameters.Add("@RxNum", SqlDbType.VarChar,30).Value = RxNum;

                cmdString.ExecuteNonQuery();

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
        
        public static void CreateMedication(
            string Medication_id,
            string MedicationName,
            string IntakeMethod,
            string Frequency,
            string Dosage,
            string Purpose,
            string RxNum)

        {
            try
            {
                myConn.Open();

                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;

                cmdString.CommandText = "CreateMedication";

                cmdString.Parameters.Add("@Medication_id", SqlDbType.VarChar, 7).Value = Medication_id;
                cmdString.Parameters.Add("@MedicationName", SqlDbType.VarChar,60).Value = MedicationName;
                cmdString.Parameters.Add("@IntakeMethod", SqlDbType.VarChar,30).Value =IntakeMethod ;
                cmdString.Parameters.Add("@Frequency", SqlDbType.VarChar,30).Value =Frequency ;
                cmdString.Parameters.Add("@Dosage", SqlDbType.VarChar,30).Value = Dosage;
                cmdString.Parameters.Add("@Purpose", SqlDbType.VarChar,100).Value = Purpose;
                cmdString.Parameters.Add("@RxNum", SqlDbType.VarChar,30).Value = RxNum;

                cmdString.ExecuteNonQuery();

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


        public static void DeletePatient(string Patient_id)
        {
            
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "DeletePatient";
                // Define input parameter
                cmdString.Parameters.Add("@Patient_id", SqlDbType.VarChar, 8).Value = Patient_id;

                cmdString.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(Patient_id + " Has an Associated Prescriptions. Could Not Delete", "Error", MessageBoxButtons.OK);
            }
            finally
            {
                myConn.Close();
            }
            
        }
        
        public static void DeletePhysician(string Physician_id)
        {
            
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "DeletePhysician";
                // Define input parameter
                cmdString.Parameters.Add("@Physician_id", SqlDbType.VarChar, 8).Value = Physician_id;

                cmdString.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(Physician_id + " Has an Associated Prescriptions. Could Not Delete", "Error", MessageBoxButtons.OK);
            }
            finally
            {
                myConn.Close();
            }
            
        }
        
        public static void DeleteMedication(string medID)
        {
            
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "DeleteMedication";
                // Define input parameter
                cmdString.Parameters.Add("@MedID", SqlDbType.VarChar, 7).Value = medID;

                cmdString.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(medID + " Has an Associated Prescriptions. Could Not Delete", "Error", MessageBoxButtons.OK);
            }
            finally
            {
                myConn.Close();
            }
            
        }
        
        public static void DeletePrescription(string precID)
        {
            
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "DeletePrescription";
                // Define input parameter
                cmdString.Parameters.Add("@RxID", SqlDbType.VarChar, 11).Value = precID;

                cmdString.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(precID + " Has an Associated Refill. Could Not Delete", "Error", MessageBoxButtons.OK);
            }
            finally
            {
                myConn.Close();
            }
            
        }
        
        
        
        public static DataSet PatientInfoSearch(string id, string lname, string fname)
        {
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "SearchPatients";
                // Define input parameter
                cmdString.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = id;
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 30).Value = lname;
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 30).Value = fname;
                // adapter and dataset
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();
        
                // fill adapter
                aAdapter.Fill(aDataSet);
        
                // return dataSet
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
        
        public static DataSet PatientInfoSearch(string id)
        {
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "SearchPatients";
                // Define input parameter
                cmdString.Parameters.Add("@ID", SqlDbType.VarChar, 8).Value = id;
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 30).Value = "";
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 30).Value = "";
                // adapter and dataset
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();
        
                // fill adapter
                aAdapter.Fill(aDataSet);
        
                // return dataSet
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

        
        public static DataSet PrescriptionInfoSearch(string rxID, string patID, string medID, string physID)
        {
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "PerscriptionInfoSearch";
                // Define input parameter
                cmdString.Parameters.Add("@rxID", SqlDbType.VarChar, 11).Value = rxID;
                cmdString.Parameters.Add("@patientID", SqlDbType.VarChar, 8).Value = patID;
                cmdString.Parameters.Add("@physicianID", SqlDbType.VarChar, 8).Value = physID;
                cmdString.Parameters.Add("@medID", SqlDbType.VarChar, 8).Value = medID;
                // adapter and dataset
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();
        
                // fill adapter
                aAdapter.Fill(aDataSet);
        
                // return dataSet
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
        
        public static DataSet PrescriptionInfoSearch(string rxID)
        {
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "PerscriptionInfoSearch";
                // Define input parameter
                cmdString.Parameters.Add("@rxID", SqlDbType.VarChar, 11).Value = rxID;
                cmdString.Parameters.Add("@patientID", SqlDbType.VarChar, 8).Value = "%";
                cmdString.Parameters.Add("@physicianID", SqlDbType.VarChar, 8).Value = "%";
                cmdString.Parameters.Add("@medID", SqlDbType.VarChar, 8).Value = "%";
                // adapter and dataset
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();
        
                // fill adapter
                aAdapter.Fill(aDataSet);
        
                // return dataSet
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

        public static DataSet GetRefill(string rxID)
        {
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetRefills";
                // Define input parameter
                cmdString.Parameters.Add("@rxID", SqlDbType.VarChar, 11).Value = rxID;
                // adapter and dataset
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();

                // fill adapter
                aAdapter.Fill(aDataSet);

                // return dataSet
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

        public DataSet NumberofRefills(string rxID)
        {
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "NumberofRefills";
                // Define input parameter
                cmdString.Parameters.Add("@rxID", SqlDbType.VarChar, 11).Value = rxID;
                // adapter and dataset
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();

                // fill adapter
                aAdapter.Fill(aDataSet);

                // return dataSet
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


        public static DataSet PhysicianInfoSearch(string fname,string lname, string phyID)
        {
            
            
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "PhysicianInfoSearch";
                // Define input parameter
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 11).Value = fname;
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 8).Value = lname;
                cmdString.Parameters.Add("@phyID", SqlDbType.VarChar, 8).Value = phyID;
                // adapter and dataset
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();
        
                // fill adapter
                aAdapter.Fill(aDataSet);
        
                // return dataSet
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
        
        
        public static DataSet PhysicianInfoSearch(string phyID)
        {
            
            
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "PhysicianInfoSearch";
                // Define input parameter
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 11).Value = "";
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 8).Value = "";
                cmdString.Parameters.Add("@phyID", SqlDbType.VarChar, 8).Value = phyID;
                // adapter and dataset
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();
        
                // fill adapter
                aAdapter.Fill(aDataSet);
        
                // return dataSet
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
        
        public static DataSet MedicationInfoSearch(string medID, string medicationName)
        {
            
            
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "MedicationInfoSearch";
                // Define input parameter
                cmdString.Parameters.Add("@Medication_id", SqlDbType.VarChar, 7).Value = medID;
                cmdString.Parameters.Add("@MedicationName", SqlDbType.VarChar, 60).Value = medicationName;
                // adapter and dataset
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();
        
                // fill adapter
                aAdapter.Fill(aDataSet);
        
                // return dataSet
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
        
        public static DataSet MedicationInfoSearch(string medID)
        {
            
            
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "MedicationInfoSearch";
                // Define input parameter
                cmdString.Parameters.Add("@Medication_id", SqlDbType.VarChar, 7).Value = medID;
                cmdString.Parameters.Add("@MedicationName", SqlDbType.VarChar, 60).Value = "";
                // adapter and dataset
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();
        
                // fill adapter
                aAdapter.Fill(aDataSet);
        
                // return dataSet
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
        
        
        public static double GetNextPatientID()
        {
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetNextPatientID";
                // Define input parameter
                cmdString.Parameters.Add("@TableName", SqlDbType.NVarChar, 128).Value = "PATIENT";
                
                object result = cmdString.ExecuteScalar();
                double value = 0;
                try
                {
                    value = Convert.ToDouble(result);

                }
                catch(Exception e)
                {
                    // MessageBox.Show("Error Getting next Patient ID","ERROR",MessageBoxButtons.OK);
                }
                
        
                // return dataSet
                return value;
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
        
        
        public static double GetNextPhysicianID()
        {
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetNextPhysicianID";
                
                object result = cmdString.ExecuteScalar();
                double value = 0;
                try
                {
                    value = Convert.ToDouble(result);

                }
                catch(Exception e)
                {
                    // MessageBox.Show("Error Getting next Patient ID","ERROR",MessageBoxButtons.OK);
                }
                
        
                // return dataSet
                return value;
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
        
        public static double GetNextMedicationID()
        {
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetNextMedicationID";
                
                object result = cmdString.ExecuteScalar();
                double value = 0;
                try
                {
                    value = Convert.ToDouble(result);

                }
                catch(Exception e)
                {
                    // MessageBox.Show("Error Getting next Patient ID","ERROR",MessageBoxButtons.OK);
                }
                
        
                // return dataSet
                return value;
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

        public static double GetNextRxNum()
        {
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetNextRxID";

                object result = cmdString.ExecuteScalar();
                double value = 0;
                try
                {
                    value = Convert.ToDouble(result);

                }
                catch (Exception e)
                {
                    // MessageBox.Show("Error Getting next Rx Number", "ERROR", MessageBoxButtons.OK);
                }


                // return dataSet
                return value;
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


        public static DataSet RefillSearch(DateTime date, string id)
        {
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "SearchRefills";
                // Define input parameter
                cmdString.Parameters.Add("@date", SqlDbType.Date).Value = date;
                cmdString.Parameters.Add("@ID", SqlDbType.VarChar, 10).Value = id;
                // adapter and dataset
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();

                // fill adapter
                aAdapter.Fill(aDataSet);

                // return dataSet
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

        public static DataSet RefillSearch(string id)
        {
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "SearchRefills2";
                // Define input parameter
                cmdString.Parameters.Add("@ID", SqlDbType.VarChar, 10).Value = id;
                //cmdString.Parameters.Add("@date", SqlDbType.Date).Value = "";
                // adapter and dataset
                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();

                // fill adapter
                aAdapter.Fill(aDataSet);

                // return dataSet
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

        public static double GetNextRefillID()
        {
            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetNextRefillID";
                // Define input parameter
                cmdString.Parameters.Add("@TableName", SqlDbType.NVarChar, 128).Value = "Refill";

                object result = cmdString.ExecuteScalar();
                double value = 0;
                try
                {
                    value = Convert.ToDouble(result);

                }
                catch (Exception e)
                {
                    // MessageBox.Show("Error Getting next Refill ID", "ERROR", MessageBoxButtons.OK);
                }


                // return dataSet
                return value;
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

        public static void AddRefill(string refillID, DateTime date, string patientID, string medicationID, string rxNum)
        {
            try
            {
                myConn.Open();

                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;

                cmdString.CommandText = "AddNewRefill";

                cmdString.Parameters.Add("@refillID", SqlDbType.Char, 10).Value = refillID;
                cmdString.Parameters.Add("@date", SqlDbType.Date).Value = date;
                cmdString.Parameters.Add("@patientID", SqlDbType.VarChar, 8).Value = patientID;
                cmdString.Parameters.Add("@medicationID", SqlDbType.VarChar, 7).Value = medicationID;
                cmdString.Parameters.Add("@rxNum", SqlDbType.VarChar, 11).Value = rxNum;

                cmdString.ExecuteNonQuery();
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

        public static void UpdateRefill(string refillID, DateTime date, string patientID, string medicationID, string rxNum)
        {
            try
            {
                myConn.Open();

                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;

                cmdString.CommandText = "UpdateRefills";

                cmdString.Parameters.Add("@refillID", SqlDbType.Char, 10).Value = refillID;
                cmdString.Parameters.Add("@date", SqlDbType.Date).Value = date;
                cmdString.Parameters.Add("@patientID", SqlDbType.VarChar, 8).Value = patientID;
                cmdString.Parameters.Add("@medicationID", SqlDbType.VarChar, 7).Value = medicationID;
                cmdString.Parameters.Add("@rxNum", SqlDbType.VarChar, 11).Value = rxNum;

                cmdString.ExecuteNonQuery();
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

        public static void DeleteRefill(string Refill_id)
        {

            try
            {
                // open connection
                myConn.Open();
                //clear any parameters
                cmdString.Parameters.Clear();
                // command
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "DeleteRefill";
                // Define input parameter
                cmdString.Parameters.Add("@Refill_id", SqlDbType.Char, 10).Value = Refill_id;

                cmdString.ExecuteNonQuery();
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

        public static void PastRefills(string rxNum)
        {
            try
            {
                myConn.Open();

                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;

                cmdString.CommandText = "PastRefills";

                cmdString.Parameters.Add("@Prescription_id", SqlDbType.VarChar, 11).Value = rxNum;

                cmdString.ExecuteNonQuery();
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

        public static void DecrementPastRefills(string rxNum)
        {
            try
            {
                myConn.Open();

                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;

                cmdString.CommandText = "DecrementPastRefills";

                cmdString.Parameters.Add("@Prescription_id", SqlDbType.VarChar, 11).Value = rxNum;

                cmdString.ExecuteNonQuery();
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

        public static void CreatePrescription(
            string RxNum,
            string Patient_id,
            string Medication_id,
            string Physician_name,
            string Physician_id,
            int Completed_refills,
            int Max_refills)
        {
            try
            {
                myConn.Open();

                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;

                cmdString.CommandText = "CreatePrescription";

                cmdString.Parameters.Add("@Medication_id", SqlDbType.VarChar, 7).Value = Medication_id;
                cmdString.Parameters.Add("@numRefills", SqlDbType.Int).Value = Max_refills;
                cmdString.Parameters.Add("@pastNumRefills", SqlDbType.Int).Value = Completed_refills;
                cmdString.Parameters.Add("@PrescribedBy", SqlDbType.VarChar, 30).Value = Physician_name;
                cmdString.Parameters.Add("@Physician_id", SqlDbType.VarChar, 8).Value = Physician_id;
                cmdString.Parameters.Add("@Patient_id", SqlDbType.VarChar, 8).Value = Patient_id;
                cmdString.Parameters.Add("@RxNum", SqlDbType.VarChar, 11).Value = RxNum;

                cmdString.ExecuteNonQuery();

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

        public static void UpdatePrescription(
            string RxNum,
            string Patient_id,
            string Medication_id,
            string Physician_name,
            string Physician_id,
            int Completed_refills,
            int Max_refills)
        {
            try
            {
                myConn.Open();

                cmdString.Parameters.Clear();

                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;

                cmdString.CommandText = "UpdatePrescription";

                cmdString.Parameters.Add("@Medication_id", SqlDbType.VarChar, 7).Value = Medication_id;
                cmdString.Parameters.Add("@numRefills", SqlDbType.VarChar, 60).Value = Max_refills;
                cmdString.Parameters.Add("@pastNumRefills", SqlDbType.VarChar, 30).Value = Completed_refills;
                cmdString.Parameters.Add("@PrescribedBy", SqlDbType.VarChar, 30).Value = Physician_name;
                cmdString.Parameters.Add("@Physician_id", SqlDbType.VarChar, 30).Value = Physician_id;
                cmdString.Parameters.Add("@Patient_id", SqlDbType.VarChar, 100).Value = Patient_id;
                cmdString.Parameters.Add("@RxNum", SqlDbType.VarChar, 30).Value = RxNum;

                cmdString.ExecuteNonQuery();

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

        // public static void FillComboBox(string table, string ValueMember, string displayMember, ComboBox myComboBox)
        // {
        //     try
        //     {
        //         myConn.Open();
        //
        //         SqlCommand command = new SqlCommand("SELECT "+ValueMember+" FROM "+table, myConn);
        //         SqlDataReader reader = command.ExecuteReader();
        //
        //         DataTable dt = new DataTable();
        //         dt.Columns.Add(ValueMember, typeof(string));
        //         dt.Load(reader);
        //
        //         myComboBox.ValueMember = ValueMember;
        //         myComboBox.DisplayMember = displayMember;
        //         myComboBox.DataSource = dt;
        //
        //         reader.Close();
        //         myConn.Close();
        //     }
        //     catch (Exception ex)
        //     {
        //         MessageBox.Show("Error: " + ex.Message);
        //     }
        // }

    }

}