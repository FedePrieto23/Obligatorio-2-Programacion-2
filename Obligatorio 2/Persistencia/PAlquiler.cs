using Obligatorio_2.Dominio;
using System.Data;

namespace Obligatorio_2.Persistencia
{
    public class PAlquiler
    {
        private Conexion Conexion = new Conexion();

        public List<Alquiler> ListaAlquileres()
        {
            string sql = "SELECT * FROM Alquiler";

            DataSet datos = Conexion.Consulta(sql);

            List<Alquiler> lista = new List<Alquiler>();

            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                Vehiculo veh = new Vehiculo();
                veh.Id = int.Parse(fila["idvehiculo"].ToString());

                Cliente cli = new Cliente();
                cli.Id = int.Parse(fila["idcliente"].ToString());

                Accesorios acc = new Accesorios();
                acc.Id = int.Parse(fila["idaccesorios"].ToString());

                Alquiler unAlq = new Alquiler(
                    int.Parse(fila["id"].ToString()),
                    DateTime.Parse(fila["fechaalquiler"].ToString()),
                    DateTime.Parse(fila["fecharetirov"].ToString()),
                    DateTime.Parse(fila["fechadev"].ToString()),
                    veh,
                    cli,
                    fila["conductorad"].ToString(),
                    acc,
                    fila["lugarretiro"].ToString(),
                    fila["lugardev"].ToString(),
                    double.Parse(fila["precioxdia"].ToString()),
                    fila["estado"].ToString()
                );

                lista.Add(unAlq);
            }
            return lista;
        }

        public bool Alta(Alquiler unAlq)
        {
            string sql =
                "INSERT INTO Alquiler " +
                "(id, fechaalquiler, fecharetirov, fechadev, idvehiculo, idcliente, conductorad, idaccesorios, lugarretiro, lugardev, precioxdia, estado) VALUES (" +
                unAlq.Id + ",'" +
                unAlq.FechaAlquiler.ToString("yyyy-MM-dd") + "','" +
                unAlq.FechaRetiroV.ToString("yyyy-MM-dd") + "','" +
                unAlq.FechaDevoV.ToString("yyyy-MM-dd") + "'," +
                unAlq.Vehiculo.Id + "," +
                unAlq.Vehiculo.Id + "," +
                unAlq.Cliente.Id + ",'" +
                unAlq.ConductorAd + "'," +
                unAlq.Accesorios.Id + ",'" +
                unAlq.LugarRetiro + "','" +
                unAlq.LugarDev + "'," +
                unAlq.PrecioXDia.ToString().Replace(',', '.') + ",'" +
                unAlq.Estado + "')";

            return Conexion.Ejecutar(sql);
        }

        public bool Baja(int pId)
        {
            string sql = "DELETE FROM Alquiler WHERE id = " + pId.ToString();
            return Conexion.Ejecutar(sql);
        }

        public bool Modificar(Alquiler unAlq)
        {
            string sql =
                "UPDATE Alquiler SET " +
                "fechaalquiler = '" + unAlq.FechaAlquiler.ToString("yyyy-MM-dd") + "'," +
                "fecharetirov = '" + unAlq.FechaRetiroV.ToString("yyyy-MM-dd") + "'," +
                "fechadev = '" + unAlq.FechaDevoV.ToString("yyyy-MM-dd") + "'," +
                "idvehiculo = " + unAlq.Vehiculo.Id + "," +
                "idcliente = " + unAlq.Cliente.Id + "," +
                "conductorad = '" + unAlq.ConductorAd + "'," +
                "idaccesorios = " + unAlq.Accesorios.Id + "," +
                "lugarretiro = '" + unAlq.LugarRetiro + "'," +
                "lugardev = '" + unAlq.LugarDev + "'," +
                "precioxdia = " + unAlq.PrecioXDia.ToString().Replace(',', '.') + "," +
                "estado = '" + unAlq.Estado + "' " +
                "WHERE id = " + unAlq.Id.ToString();

            return Conexion.Ejecutar(sql);
        }

        public int ProximoId()
        {
            string sql = "SELECT (ISNULL(MAX(id),0)+1) FROM Alquiler";
            DataSet datos = Conexion.Consulta(sql);
            DataRowCollection filas = datos.Tables[0].Rows;
            int Id = int.Parse(filas[0][0].ToString());
            return Id;
        }
    }
}
