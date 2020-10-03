using Generos_1.EE;
using Generos_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generos_1.DAO
{
    public class GeneroRepository : IGeneroRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["PringlesDB"].ConnectionString;

        private SqlConnection sqlConnection;

        private void Abrir()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        private void Cerrar()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        public void Alta(Genero genero)
        {
            throw new NotImplementedException();
        }

        public void Baja(Genero genero)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genero> ListarGenero()
        {
            Abrir();
            List<Genero> generos = new List<Genero>();
            string query = "Select * from Genero";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    generos.Add(MapearGenero(sqlDataReader));
                }
            }

            Cerrar();
            return generos;
        }

        private Genero MapearGenero(IDataRecord dataRecord)
        {
            return new Genero
            {
                Id = (int)dataRecord["id"],
                Nombre = (string)dataRecord["nombre"],
                Fecha_reg = (DateTime)dataRecord["fecha_reg"]
            };
        }

        public void Modificacion(Genero genero)
        {
            throw new NotImplementedException();
        }
    }
}
