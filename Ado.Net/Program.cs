using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Ado.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFromBase();
        }
        
        private static void ReadFromBase()
        {
            
            var conString = ConfigurationManager.AppSettings["Connection String"];
            using (var connection = new SqlConnection(conString))
            {
                string commandText = @"SELECT DISTINCT 
                                        e.Id, e.Name, e.Birthday, e.Email, e.Salary
                                    FROM
                                        Employees e
                                    WHERE
                                        LEN(e.Name) > @Len";

                var command = new SqlCommand(commandText,connection);
                var parameter = new SqlParameter("@Len", SqlDbType.Int);
                parameter.Value = 20;

                command.Parameters.Add(parameter);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    List<dynamic> dataFromDb = new List<dynamic>();
                    while (reader.Read())
                    {
                        var item = new Employee()
                        {
                            Id = int.Parse(reader[0].ToString()),

                            Name = reader[1].ToString(),

                            Birthday = reader[2].GetType() != typeof(DBNull)
                                ? Convert.ToDateTime(reader[2])
                                :new DateTime(),

                            Email = (reader[3].GetType() != typeof(DBNull)
                                ? reader[3].ToString()
                                : String.Empty),

                            Salary = (reader[4].GetType() != typeof(DBNull)
                                ? reader[4].ToString().GetDouble()
                                : 0.0)
                        };
                        dataFromDb.Add(item);
                        Console.WriteLine(item);
                    }
                }
            }  
        }
    }
}
