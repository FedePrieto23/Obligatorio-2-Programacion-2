using Obligatorio_2.Dominio;
using System.Data;

namespace Obligatorio_2.Persistencia
{
    public class PVehiculo
    {
        private Conexion Conexion = new Conexion();

        public List<Vehiculo> ListaVehiculos()
        {
            string sql = "SELECT * FROM Vehiculo";

            DataSet datos = Conexion.Consulta(sql);

            List<Vehiculo> lista = new List<Vehiculo>();

            Controladora unaControladora = new Controladora();

            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                Vehiculo unVehiculo = new Vehiculo(
                    int.Parse(fila[0].ToString()),
                    fila[1].ToString(),
                    fila[2].ToString(),
                    fila[3].ToString(),
                    DateTime.Parse(fila[4].ToString()),
                    fila[5].ToString(),
                    int.Parse(fila[6].ToString()),
                    fila[7].ToString(),
                    fila[8].ToString(),
                    double.Parse(fila[9].ToString()),
                    fila[10].ToString()
                );
                lista.Add(unVehiculo);
            }
            return lista;
        }

        public bool Alta(Vehiculo unVehiculo)
        {
            string precioxdia = unVehiculo.PrecioxDia.ToString().Replace(",", ".");
            string sql = "INSERT INTO vehiculo " +
                         "(id, matricula, marca, modelo, año, tipo, cappasajeros, combustible, color, precioxdia, estado) " +
                         "VALUES (" + unVehiculo.Id + ",'"
                                    + unVehiculo.Matricula + "','"
                                    + unVehiculo.Marca + "','"
                                    + unVehiculo.Modelo + "','"
                                    + unVehiculo.Año.ToShortDateString() + "','"
                                    + unVehiculo.Tipo + "',"
                                    + unVehiculo.CapPasajeros + ",'"
                                    + unVehiculo.Combustible + "','"
                                    + unVehiculo.Color + "',"
                                    + precioxdia + ",'"
                                    + unVehiculo.Estado + "')";

            return Conexion.Ejecutar(sql);
        }

        public bool Baja(int pId)
        {
            string sql = "DELETE FROM vehiculo WHERE id = " + pId.ToString();
            return Conexion.Ejecutar(sql);
        }

        public bool Modificar(Vehiculo unVehiculo)
        {
            string precioxdia = unVehiculo.PrecioxDia.ToString().Replace(",", ".");
            string sql = "UPDATE vehiculo " +
                         "SET matricula = '" + unVehiculo.Matricula + "'," +
                         "marca = '" + unVehiculo.Marca + "'," +
                         "modelo = '" + unVehiculo.Modelo + "'," +
                         "año = '" + unVehiculo.Año.ToShortDateString() + "'," +
                         "tipo = '" + unVehiculo.Tipo + "'," +
                         "cappasajeros = " + unVehiculo.CapPasajeros + "," +
                         "combustible = '" + unVehiculo.Combustible + "'," +
                         "color = '" + unVehiculo.Color + "'," +
                         "precioxdia = " + precioxdia + "," +
                         "estado = '" + unVehiculo.Estado + "' " +
                         "WHERE id = " + unVehiculo.Id.ToString();

            return Conexion.Ejecutar(sql);
        }

        public int ProximoId()
        {
            string sql = "SELECT (ISNULL(MAX(id),0)+1) FROM Vehiculo";
            DataSet datos = Conexion.Consulta(sql);
            DataRowCollection filas = datos.Tables[0].Rows;
            var campo = filas[0];
            int Id = int.Parse(campo[0].ToString());
            return Id;
        }

    }
}
