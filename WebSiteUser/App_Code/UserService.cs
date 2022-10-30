using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;


namespace WebSiteUser
{
    public class UserService
    {
        protected OleDbConnection myConnection;

        public UserService()
        {
#pragma warning disable CS0436 // Type conflicts with imported type
            string connectionString = Connect.getConnectionString();
            myConnection = new OleDbConnection(connectionString);
        }

        public List<string> getCities()
        {
            List<string> result = new List<string>();
            myConnection.Open();
            using (OleDbCommand Command = new OleDbCommand("SELECT CityName from tlbCities", myConnection))
            {
                using (OleDbDataReader reader = Command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(reader.GetString(0));
                    }
                }

            }
            myConnection.Close();
            return result;

        }

#pragma warning disable CS0436 // Type conflicts with imported type
        public void AddUser(UserDetails userDetail)
        {
           // INSERT INTO tlbUsers VALUES([@UserID], [@FirstName], [@LastName], [@Phone], [@Address], [@City], [@State], [@Zip], [@Username], [@Password], [@BirthDate]);


            OleDbCommand myCommand = new OleDbCommand("CreateNewUser", myConnection);
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;

            myCommand.Parameters.Add("@UserID", OleDbType.BSTR).Value = userDetail.ID;
            myCommand.Parameters.Add("@FirstName", OleDbType.BSTR).Value = userDetail.FirstName;
            myCommand.Parameters.Add("@LastName", OleDbType.BSTR).Value = userDetail.LastName;
            myCommand.Parameters.Add("@Phone", OleDbType.BSTR).Value = userDetail.Phone;
            myCommand.Parameters.Add("@Address", OleDbType.BSTR).Value = userDetail.Address;
            myCommand.Parameters.Add("@CityID", OleDbType.BSTR).Value = userDetail.City;
            myCommand.Parameters.Add("@State", OleDbType.BSTR).Value = userDetail.State;
            myCommand.Parameters.Add("@Zip", OleDbType.BSTR).Value = userDetail.Zip;
            myCommand.Parameters.Add("@Username", OleDbType.BSTR).Value = userDetail.Username;
            myCommand.Parameters.Add("@Password", OleDbType.BSTR).Value = userDetail.Password;
            myCommand.Parameters.Add("@BirthDate", OleDbType.Date).Value = userDetail.BirthDate;

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }

        }

        public int CityIdFromName(string CityName)
        {
            
            OleDbCommand myCommand = new OleDbCommand("CityIdFromName", myConnection);
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            myCommand.Parameters.Add("@CityName", OleDbType.BSTR).Value = CityName;
            object obj;
            try
            {
                myConnection.Open();
                obj = myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return int.Parse(obj.ToString());
        }

        public List<string> login(string username, string password)
        {
            List<string> result = new List<string>();
            myConnection.Open();
            using (OleDbCommand Command = new OleDbCommand($"SELECT * FROM tlbusers WHERE Username = '{username}' and Password = '{password}'", myConnection))
            {
                using (OleDbDataReader reader = Command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            result.Add(reader.GetString(i));
                        }
                        result.Add(reader.GetDateTime(10).ToString());
                    }
                }
            }
            myConnection.Close();
            return result;
        }

    }
}