using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CRUD.EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace CRUD.DataLayer
{
    public class PersonsDL
    {
        /* 
            Cargar varios empleados 
         */
        public List<Empleado> Lista()
        {
            List<Empleado> lista = new List<Empleado>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("select * from Persons", oConexion);
                cmd.CommandType = CommandType.Text;
                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Empleado
                            {
                                PersonId = Convert.ToInt32(dr["PersonID"].ToString()),
                                FirstName = dr["FirstName"].ToString(),
                                LastName = dr["LastName"].ToString(),
                                Address = dr["Address"].ToString(),
                                City = dr["City"].ToString()
                            });
                        }
                    }
                    return lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        /*
        Cargar solo un empleado

        params:
            Empleado ID
         */
        public Empleado Obtener(int IdEmpleado)
        {
            Empleado entidad = new Empleado();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("select * from Persons where PersonID = @idEmpleado", oConexion);
                cmd.Parameters.AddWithValue("@idEmpleado", IdEmpleado);
                cmd.CommandType = CommandType.Text;
                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            entidad.PersonId = Convert.ToInt32(dr["PersonID"].ToString());
                            entidad.FirstName = dr["FirstName"].ToString();
                            entidad.LastName = dr["LastName"].ToString();
                            entidad.Address = dr["Address"].ToString();
                            entidad.City = dr["City"].ToString();
                        }
                    }
                    return entidad;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        /*
        Cargar solo un empleado

        params:
            Empleado ID
         */
        public List<Empleado> FiltroID(int idEmpleado)
        {
            List<Empleado> lista = new List<Empleado>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("select * from Persons where PersonID = @idEmpleado", oConexion);
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                cmd.CommandType = CommandType.Text;
                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Empleado
                            {
                                PersonId = Convert.ToInt32(dr["PersonID"].ToString()),
                                FirstName = dr["FirstName"].ToString(),
                                LastName = dr["LastName"].ToString(),
                                Address = dr["Address"].ToString(),
                                City = dr["City"].ToString()
                            });
                        }
                    }
                    return lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
