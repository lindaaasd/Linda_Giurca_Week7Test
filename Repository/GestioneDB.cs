using System;
using System.Data.SqlClient;
using Week7_Test.Entities;

namespace Week7_Test.Repository
{
	public class GestioneDB
	{
		string connectionString = @"";

		public List<User> GetAll()
        {
			SqlConnection connection = null;
            try
            {
				using(connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("select * from User", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    List<User> Users = new List<User>();

                    while (reader.Read())
                    {
                        var id = (int)reader["ID"];
                        var nome = (string)reader["Nome"];
                        var cognome = (string)reader["Cognome"];

                        User newUser = new User();
                        newUser.ID = id;
                        newUser.Nome = nome;
                        newUser.Cognome = cognome;

                        Users.Add(newUser);
                    }

                    return Users;
                }
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return new List<User>();
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }
	}
}

