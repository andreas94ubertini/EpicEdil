using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace EpicEdil.Models
{
    public class Database
    {
        public static List<Pagamento> GetAllPagamenti()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Pagamenti", conn);
            SqlDataReader sqlDataReader;

            conn.Open();

            List<Pagamento> AllPagamenti = new List<Pagamento>();
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Pagamento Npagamento = new Pagamento();
                Npagamento.IdPagamento = Convert.ToInt32(sqlDataReader["IdPagamento"]);
                Npagamento.Data = Convert.ToDateTime(sqlDataReader["Data"]);
                Npagamento.Importo = Convert.ToDouble(sqlDataReader["Importo"]);
                Npagamento.IsStipendio = Convert.ToBoolean(sqlDataReader["IsStipendio"]);
                Npagamento.IdDipendente = Convert.ToInt32(sqlDataReader["IdDipendente"]);
                AllPagamenti.Add(Npagamento);

            }

            conn.Close();
            return AllPagamenti;
        }
        public static List<Dipendente> getAllDipenti()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Dipendenti", conn);
            SqlDataReader sqlDataReader;

            conn.Open();

            List<Dipendente> dipendenti = new List<Dipendente>();
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Dipendente dipendente = new Dipendente();
                dipendente.IdDipendente = Convert.ToInt32(sqlDataReader["IdDipendente"]);
                dipendente.Nome = sqlDataReader["Nome"].ToString();
                dipendente.Cognome = sqlDataReader["Cognome"].ToString();
                dipendente.Indirizzo = sqlDataReader["Indirizzo"].ToString();
                dipendente.Cdf = sqlDataReader["Cdf"].ToString();
                dipendente.Mansione = sqlDataReader["Mansione"].ToString();
                dipendente.IsSposato = Convert.ToBoolean(sqlDataReader["IsSposato"]);
                dipendente.Nfigli = Convert.ToInt32(sqlDataReader["NumeroFigli"]);
                dipendenti.Add(dipendente);

            }

            conn.Close();
            return dipendenti;
        }
        public static void InsertDipendente(string nome, string cognome, string indirizzo, string cdf, string mansione, bool IsSposato, int Nfigli)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Dipendenti VALUES(@Nome, @Cognome, @Indirizzo, @Cdf, @Mansione, @IsSposato, @NumeroFigli)";
                cmd.Parameters.AddWithValue("Nome", nome);
                cmd.Parameters.AddWithValue("Cognome", cognome);
                cmd.Parameters.AddWithValue("Indirizzo", indirizzo);
                cmd.Parameters.AddWithValue("Cdf", cdf);
                cmd.Parameters.AddWithValue("Mansione", mansione);
                cmd.Parameters.AddWithValue("IsSposato", IsSposato);
                cmd.Parameters.AddWithValue("NumeroFigli", Nfigli);
                int IsOk = cmd.ExecuteNonQuery();

            }

            catch
            {

            }
            finally
            {
                conn.Close();
            }

        }
        public static void InsertPagamento(DateTime data, double importo, bool IsStipendio, int IdDipendente)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Pagamenti VALUES(@Data, @Importo, @IsStipendio, @IdDipendente)";
                cmd.Parameters.AddWithValue("Data", data);
                cmd.Parameters.AddWithValue("Importo", importo);
                cmd.Parameters.AddWithValue("IsStipendio", IsStipendio);
                cmd.Parameters.AddWithValue("IdDipendente", IdDipendente);

                int IsOk = cmd.ExecuteNonQuery();

            }

            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }
        
    }
}