using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
using System.Data.SqlClient;


namespace LectorEquiposFutbol
{
    public class Conexion_class
    {
        const string const_UsuarioConexion = "EKONO";
        const string const_ContrasennaConexion = "EKONO";
        const string const_ServidorBaseDatos = @"LAPTOP-QGPUJ485\SQLEXPRESS";
        const string const_BaseDatos = "PRUEBA_DESARROLLO";

        #region Devuelve el constructor de la conexión
        private SqlConnectionStringBuilder IniciarCadenaConexion()
        {
            try
            {
                SqlConnectionStringBuilder sql_constructorConexion = new SqlConnectionStringBuilder();
                sql_constructorConexion.DataSource = const_ServidorBaseDatos;
                sql_constructorConexion.UserID = const_UsuarioConexion;
                sql_constructorConexion.Password = const_ContrasennaConexion;
                sql_constructorConexion.InitialCatalog = const_BaseDatos;

                return sql_constructorConexion;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        #endregion

        ///Hace la consulta
        public DataTable Consulta(string p_consulta)//Consulta solo echa para SELECT
        {
            DataTable var_tablaDatos = new DataTable();

            try
            {
                using (SqlConnection conexionBD = new SqlConnection(IniciarCadenaConexion().ConnectionString))
                {
                    try
                    {
                        conexionBD.Open();
                        using (SqlDataAdapter sqlAdaptador = new SqlDataAdapter(p_consulta, conexionBD))
                        {
                            sqlAdaptador.Fill(var_tablaDatos);
                            conexionBD.Close();

                            return var_tablaDatos;
                        }                        
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.ToString());
                        if (conexionBD.State == ConnectionState.Open)
                        {
                            conexionBD.Close();
                        }

                        return null;
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}