using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;
using System.Configuration; // referenciado

namespace DAL
{
    public class CarroDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BancoMuitoLouco2CS"].ConnectionString; //Negocio Loko memo

        public void InserirCarro(Carro objCarro)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = @"INSERT INTO Carros (Marca,Modelo,Ano,Cor) VALUES (@a,@b,@c,@d)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@a", objCarro.Marca);
                cmd.Parameters.AddWithValue("@b", objCarro.Modelo);
                cmd.Parameters.AddWithValue("@c", objCarro.Ano);
                cmd.Parameters.AddWithValue("@d", objCarro.Cor);

                cmd.ExecuteNonQuery();

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }

            }
        }
    }
}
