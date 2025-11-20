using System.Data.SqlClient;
using System.Data;

namespace Obligatorio_2.Persistencia
{
    public class Conexion
    {
        private static string source = "DESKTOP-2GR15MM\\SQLEXPRESS";
        private static string baseDeDatos = "Obligatorio2";
        private string CadenaConexion = "data source=" + source + "; " +
            "initial Catalog=" + baseDeDatos + "; Integrated Security=SSPI; Encrypt=false";

        public bool Ejecutar(string sql)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(this.CadenaConexion);
                string FormatoFecha = "set dateformat dmy; ";
                SqlCommand comando = new SqlCommand(FormatoFecha + sql, conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexion.Close();
                return true;
            }
            catch
            {
                throw new Exception("Error en conexion sql = " + sql);
            }
        }

        public DataSet Consulta(string sql)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(this.CadenaConexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion);
                DataSet resultado = new DataSet();
                conexion.Open();
                adaptador.Fill(resultado);
                adaptador.Dispose();
                conexion.Close();
                return resultado;
            }
            catch (Exception e)
            {
                throw new Exception("Error en conexión sql = " + sql, e);
            }
        }
    }
}