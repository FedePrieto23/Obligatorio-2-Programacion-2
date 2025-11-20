using System.Data;
using Obligatorio_2.Dominio;

namespace Obligatorio_2.Persistencia
{
    public class PCliente
    {
        private Conexion Conexion = new Conexion();

        public List<Cliente> ListaClientes()
        {
            string sql = "SELECT * FROM Cliente";

            DataSet datos = Conexion.Consulta(sql);

            List<Cliente> lista = new List<Cliente>();

            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                Cliente unCliente = new Cliente(
                    int.Parse(fila[0].ToString()),
                    fila[1].ToString(),
                    fila[2].ToString(),
                    fila[3].ToString(),
                    DateTime.Parse(fila[4].ToString()),
                    fila[5].ToString(),
                    fila[6].ToString(),
                    fila[7].ToString(),
                    fila[8].ToString(),
                    fila[9].ToString(),
                    DateTime.Parse(fila[10].ToString())
                    );
                lista.Add(unCliente);
            }
            return lista;
        }
        public bool Alta(Cliente unCliente)
        {
            string sql = "INSERT INTO cliente (id, nombre, apellido, cedula, fechanac, telefono, celular, email, direccion, numlibreta, fechavenclibreta)"
                + "VALUES (" + unCliente.Id + ", '" + unCliente.Nombre + "', '" + unCliente.Apellido + "', '" + unCliente.Cedula + "', '" + unCliente.FechaNac.ToShortDateString() +
                "', '" + unCliente.Telefono + "', '" + unCliente.Celular + "', '" + unCliente.NumLibreta + "', '" + unCliente.FechaVencLibreta.ToShortDateString() + "')";

            return Conexion.Ejecutar(sql);
        }
        public bool Baja(int pId)
        {
            string sql = "DELETE FROM Cliente WHERE id = " + pId.ToString();

            return Conexion.Ejecutar(sql);
        }

        public bool Modificar(Cliente unCliente)
        {
            string sql = "UPDATE Cliente "
                + "SET nombre = '" + unCliente.Nombre + "', " +
                " apellido = '" + unCliente.Apellido + "', " +
                " cedula = '" + unCliente.Cedula + "', " +
                " fechanac = '" + unCliente.FechaNac.ToShortDateString() + "', " +
                " telefono = '" + unCliente.Telefono + "', " +
                " celular = '" + unCliente.Celular + "', " +
                " email = '" + unCliente.Email + "', " +
                " direccion = '" + unCliente.Direccion + "', " +
                " numlibreta = '" + unCliente.NumLibreta + "', " +
                " fechavenclibreta = '" + unCliente.FechaVencLibreta.ToShortDateString() + "' " +
                " WHERE id = " + unCliente.Id.ToString();

            return Conexion.Ejecutar(sql);
        }
        public int ProximoId()
        {
            string sql = "SELECT (ISNULL(MAX(id),0)+1) FROM Cliente";
            DataSet datos = Conexion.Consulta(sql);
            DataRowCollection filas = datos.Tables[0].Rows;
            var campo = filas[0];
            int id = int.Parse(campo[0].ToString());
            return id;
        }
    }
}