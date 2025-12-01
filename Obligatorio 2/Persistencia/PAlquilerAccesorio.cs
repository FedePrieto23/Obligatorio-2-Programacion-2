using System.Data;
using Obligatorio_2.Dominio;

namespace Obligatorio_2.Persistencia
{
    public class PAlquilerAccesorio
    {
        private Conexion Conexion = new Conexion();

        public List<AlquilerAccesorio> ListaAlquilerAccesorios()
        {
            string sql = "SELECT * FROM AlquilerAccesorio";

            DataSet datos = Conexion.Consulta(sql);

            List<AlquilerAccesorio> lista = new List<AlquilerAccesorio>();
            Controladora controladora = new Controladora(); 

            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                AlquilerAccesorio unAlquilerAccesorio = new AlquilerAccesorio(
                    int.Parse(fila[0].ToString()),
                    fila[1].ToString(),
                    int.Parse(fila[2].ToString())
                );
                lista.Add(unAlquilerAccesorio);
            }
            return lista;
        }
        public bool Alta(AlquilerAccesorio unAlquilerAccesorio)
        {
            string sql = "INSERT INTO AlquilerAccesorio (Id, Nombre, Cantidad) "
                       + "VALUES (" + unAlquilerAccesorio.Id + ", '"
                       + unAlquilerAccesorio.Nombre + "', "
                       + unAlquilerAccesorio.Cantidad + ")";
            return Conexion.Ejecutar(sql);
        }

        public bool Baja(int pId)
        {
            string sql = "DELETE FROM AlquilerAccesorio WHERE Id = " + pId.ToString();
            
            return Conexion.Ejecutar(sql);
        }

        public bool Modificar(AlquilerAccesorio unAlquilerAccesorio)
        {
            string sql = "UPDATE AlquilerAccesorio "
                       + "SET Nombre = '" + unAlquilerAccesorio.Nombre + "', "
                       + "Cantidad = " + unAlquilerAccesorio.Cantidad + " "
                       + "WHERE Id = " + unAlquilerAccesorio.Id;

            return Conexion.Ejecutar(sql);
        }
        public int ProximoAlquilerAccesorioId()
        {
            string sql = "SELECT (ISNULL(MAX(id),0)+1) FROM AlquilerAccesorio";
            DataSet datos = Conexion.Consulta(sql);
            DataRowCollection filas = datos.Tables[0].Rows;
            var campo = filas[0];
            int Id = int.Parse(campo[0].ToString());
            return Id;
        }
    }
}
