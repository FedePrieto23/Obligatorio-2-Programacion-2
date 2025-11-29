using System.Data;
using Obligatorio_2.Dominio;

namespace Obligatorio_2.Persistencia
{
    public class PAlquilerAccesorios
    {
        private Conexion Conexion = new Conexion();

        public List<AlquilerAccesorios> ListaAlquilerAccesorios()
        {
            string sql = "SELECT * FROM AlquilerAccesorios";

            DataSet datos = Conexion.Consulta(sql);

            List<AlquilerAccesorios> lista = new List<AlquilerAccesorios>();
            Controladora controladora = new Controladora(); 

            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                AlquilerAccesorios unAlquilerAccesorios = new AlquilerAccesorios(
                    int.Parse(fila[0].ToString()),
                    fila[1].ToString(),
                    int.Parse(fila[2].ToString())
                );
                lista.Add(unAlquilerAccesorios);
            }
            return lista;
        }

        public bool Baja(int pId)
        {
            string sql = "DELETE FROM AlquilerAccesorios WHERE Id = " + pId.ToString();
            
            return Conexion.Ejecutar(sql);
        }

        public bool Modificar(AlquilerAccesorios unAlquilerAccesorios)
        {
            string sql = "UPDATE AlquilerAccesorios "
                       + "SET Nombre = '" + unAlquilerAccesorios.Nombre + "', "
                       + "Cantidad = " + unAlquilerAccesorios.Cantidad + " "
                       + "WHERE Id = " + unAlquilerAccesorios.Id;

            return Conexion.Ejecutar(sql);
        }
        public int ProximoAlquilerAccesoriosId()
        {
            string sql = "SELECT (ISNULL(MAX(id),0)+1) FROM AlquilerAccesorios";
            DataSet datos = Conexion.Consulta(sql);
            DataRowCollection filas = datos.Tables[0].Rows;
            var campo = filas[0];
            int Id = int.Parse(campo[0].ToString());
            return Id;
        }
    }
}
