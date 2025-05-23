﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace LibraryManagementSystem
{
    class DataAddBooks
    {
        SqlConnection connect;
        public int ID { set; get; }
        public string BookTitle { set; get; }
        public string Author { set; get; }
        public string Pulished { set; get; }
        public string image { set; get; }
        public string Status { set; get; }

        public DataAddBooks()
        {
            string dbPath = Path.Combine(Application.StartupPath, "Data", "library.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;";
            connect = new SqlConnection(connectionString);

        }

        public List<DataAddBooks> addBooksData()
        {
            List<DataAddBooks> listData = new List<DataAddBooks>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM books WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        

                        while (reader.Read())
                        {
                            DataAddBooks dab = new DataAddBooks();
                            dab.ID = (int)reader["id"];
                            dab.BookTitle = reader["book_title"].ToString();
                            dab.Author = reader["author"].ToString();
                            dab.Pulished = reader["published_date"].ToString();
                            dab.image = reader["image"].ToString();
                            dab.Status = reader["status"].ToString();

                            listData.Add(dab);
                        }

                        reader.Close();
                    }

                    }catch(Exception ex)
                {
                    Console.WriteLine("Error conenecting Database: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
