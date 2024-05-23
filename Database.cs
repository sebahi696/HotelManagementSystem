using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public class Database
    {
        private string connectionString = "your_connection_string_here";

        public List<Room> GetRooms()
        {
            var rooms = new List<Room>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Rooms", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    rooms.Add(new Room
                    {
                        Id = reader.GetInt32(0),
                        Floor = reader.GetInt32(1),
                        Type = reader.GetString(2),
                        Price = reader.GetDecimal(3),
                        Status = reader.GetString(4),
                        Beds = reader.GetInt32(5)
                    });
                }
            }

            return rooms;
        }

        public void AddRoom(Room room)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Rooms (Floor, Type, Price, Status, Beds) VALUES (@Floor, @Type, @Price, @Status, @Beds)", connection);
                command.Parameters.AddWithValue("@Floor", room.Floor);
                command.Parameters.AddWithValue("@Type", room.Type);
                command.Parameters.AddWithValue("@Price", room.Price);
                command.Parameters.AddWithValue("@Status", room.Status);
                command.Parameters.AddWithValue("@Beds", room.Beds);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateRoom(Room room)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Rooms SET Floor=@Floor, Type=@Type, Price=@Price, Status=@Status, Beds=@Beds WHERE Id=@Id", connection);
                command.Parameters.AddWithValue("@Id", room.Id);
                command.Parameters.AddWithValue("@Floor", room.Floor);
                command.Parameters.AddWithValue("@Type", room.Type);
                command.Parameters.AddWithValue("@Price", room.Price);
                command.Parameters.AddWithValue("@Status", room.Status);
                command.Parameters.AddWithValue("@Beds", room.Beds);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteRoom(int roomId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Rooms WHERE Id=@Id", connection);
                command.Parameters.AddWithValue("@Id", roomId);

                command.ExecuteNonQuery();
            }
        }

        public List<Reservation> GetReservations()
        {
            var reservations = new List<Reservation>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Reservations", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    reservations.Add(new Reservation
                    {
                        Id = reader.GetInt32(0),
                        ClientName = reader.GetString(1),
                        RoomId = reader.GetInt32(2),
                        StartDate = reader.GetDateTime(3),
                        EndDate = reader.GetDateTime(4)
                    });
                }
            }

            return reservations;
        }

        public void AddReservation(Reservation reservation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Reservations (ClientName, RoomId, StartDate, EndDate) VALUES (@ClientName, @RoomId, @StartDate, @EndDate)", connection);
                command.Parameters.AddWithValue("@ClientName", reservation.ClientName);
                command.Parameters.AddWithValue("@RoomId", reservation.RoomId);
                command.Parameters.AddWithValue("@StartDate", reservation.StartDate);
                command.Parameters.AddWithValue("@EndDate", reservation.EndDate);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateReservation(Reservation reservation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Reservations SET ClientName=@ClientName, RoomId=@RoomId, StartDate=@StartDate, EndDate=@EndDate WHERE Id=@Id", connection);
                command.Parameters.AddWithValue("@Id", reservation.Id);
                command.Parameters.AddWithValue("@ClientName", reservation.ClientName);
                command.Parameters.AddWithValue("@RoomId", reservation.RoomId);
                command.Parameters.AddWithValue("@StartDate", reservation.StartDate);
                command.Parameters.AddWithValue("@EndDate", reservation.EndDate);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteReservation(int reservationId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Reservations WHERE Id=@Id", connection);
                command.Parameters.AddWithValue("@Id", reservationId);

                command.ExecuteNonQuery();
            }
        }

        public List<Bill> GetBills()
        {
            var bills = new List<Bill>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Bills", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    bills.Add(new Bill
                    {
                        Id = reader.GetInt32(0),
                        ClientName = reader.GetString(1),
                        TotalAmount = reader.GetDecimal(2),
                        Date = reader.GetDateTime(3)
                    });
                }
            }

            return bills;
        }

        public void AddBill(Bill bill)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Bills (ClientName, TotalAmount, Date) VALUES (@ClientName, @TotalAmount, @Date)", connection);
                command.Parameters.AddWithValue("@ClientName", bill.ClientName);
                command.Parameters.AddWithValue("@TotalAmount", bill.TotalAmount);
                command.Parameters.AddWithValue("@Date", bill.Date);

                command.ExecuteNonQuery();
            }
        }
    }
}
