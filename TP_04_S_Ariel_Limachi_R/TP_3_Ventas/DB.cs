using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TP_3_Ventas
{
    public class DB
    {
        string connstr;
        public DB(string dir)
        {
            this.connstr = dir;
        }
        public Persona RetornarUnEmpleado(string cuil)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select Nombre, Apellido, Cuil from Table_Employes  where Cuil={0}", cuil);
            string consulta = sb.ToString();
            Persona persona = new Persona();
            SqlConnection cn = new SqlConnection(this.connstr);
            SqlCommand cm = new SqlCommand(consulta, cn);
            try
            {
                cn.Open();
                SqlDataReader sqlDataReader = cm.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    persona.Nombre = sqlDataReader["Nombre"].ToString();
                    persona.Apellido = sqlDataReader["Apellido"].ToString();
                    persona.Cuil = sqlDataReader["Cuil"].ToString();
                    persona.Localidad = sqlDataReader["Localidad"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return persona;
        }
        public Persona RetornarEmpleados(string? condicion)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select Nombre, Apellido, Cuil from Table_Employes  where {0}",condicion);
            string consulta = sb.ToString();
            Persona persona = new Persona();
            SqlConnection cn = new SqlConnection(this.connstr);
            SqlCommand cm = new SqlCommand(consulta, cn);
            try
            {
                cn.Open();
                SqlDataReader sqlDataReader = cm.ExecuteReader();

                while(sqlDataReader.Read())
                {
                    Persona nuevo = new Persona();
                    persona.Nombre = sqlDataReader["Nombre"].ToString();
                    persona.Apellido = sqlDataReader["Apellido"].ToString();
                    persona.Cuil = sqlDataReader["Cuil"].ToString();
                    persona.Localidad = sqlDataReader["Localidad"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return persona;
        }
    }

}
