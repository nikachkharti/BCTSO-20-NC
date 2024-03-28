﻿using HotelProject.Data;
using HotelProject.Models;
using Microsoft.Data.SqlClient;

namespace HotelProject.Repository
{
    public class ManagerRepository
    {
        public async Task<List<Manager>> GetManagers()
        {
            List<Manager> result = new();
            const string sqlExpression = "SELECT*FROM Managers";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);

                    await connection.OpenAsync();

                    SqlDataReader reader = await command.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                    {
                        if (reader.HasRows)
                        {
                            result.Add(new Manager
                            {
                                Id = reader.GetInt32(0),
                                FirstName = !reader.IsDBNull(1) ? reader.GetString(1) : string.Empty,
                                LastName = !reader.IsDBNull(2) ? reader.GetString(2) : string.Empty,
                                HotelId = !reader.IsDBNull(3) ? reader.GetInt32(3) : 0
                            });
                        }
                    }

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }

            return result;
        }
        public async Task AddManager(Manager manager)
        {
            string sqlExpression = @$"INSERT INTO Managers(FirstName,LastName,HotelId)VALUES(N'{manager.FirstName}',N'{manager.LastName}',N'{manager.HotelId}')";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }
        }
        public async Task UpdateManager(Manager manager)
        {
            string sqlExpression = @$"UPDATE Managers
                                    SET
	                                    FirstName = N'{manager.FirstName}',
	                                    LastName = N'{manager.LastName}',
	                                    HotelId = {manager.HotelId}
                                    WHERE Id = {manager.Id}";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }
        }
        public async Task DeleteManager(int id)
        {
            string sqlExpression = @$"DELETE Managers WHERE Id = {id}";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }
        }
    }
}
