using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    public class PessoaDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BancoMuitoLouco2CS"].ConnectionString; //Negocio Loko memo

        public void InserirPessoa(Pessoa objPessoa) //pode ser o nome que quiser
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                //Inserindo uma Pessoa
                string sql = @"INSERT INTO Pessoas (Nome,Email,EstadoCivil,Sexo,ReceberEmail, ReceberSMS) VALUES (@a,@b,@c,@d,@e,@f)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@a",objPessoa.Nome);
                cmd.Parameters.AddWithValue("@b", objPessoa.Email);
                cmd.Parameters.AddWithValue("@c", objPessoa.EstadoCivil);
                cmd.Parameters.AddWithValue("@d", objPessoa.Sexo);
                cmd.Parameters.AddWithValue("@e", objPessoa.ReceberEmail);
                cmd.Parameters.AddWithValue("@f", objPessoa.ReceberSMS);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open) //Se o estado da conexão estiver aberta.
                {
                    conn.Close();
                }

            }
        }

        public Pessoa SelecionarPessoaPeloId(int id)
        {
            Pessoa pessoa = null;

            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();

                string sql = "SELECT * FROM Pessoas WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader dr = cmd.ExecuteReader(); // Colocando todos os dados pesquisados do dr (Tabela virtual)
                if (dr.HasRows && dr.Read()) // Verificando se tem linhase se consegue ler os registros que veio
                {
                    //Jogando pro Objeto
                    pessoa = new Pessoa();
                    pessoa.Id = id;
                    pessoa.Nome = dr["Nome"].ToString();
                    pessoa.Email = dr["Email"].ToString();
                    pessoa.EstadoCivil = dr["EstadoCivil"].ToString();
                    pessoa.Sexo = dr["Sexo"].ToString();
                    pessoa.ReceberSMS = Convert.ToBoolean(dr["ReceberSMS"]);
                    pessoa.ReceberEmail = Convert.ToBoolean(dr["ReceberEmail"]);
                }
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return pessoa; //Retornando o Objeto Pessoa.
        }

    }
}
