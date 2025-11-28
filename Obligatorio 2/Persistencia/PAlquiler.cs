using System.Data;
using Obligatorio_2.Dominio;

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
            Controladora controladora = new Controladora(); 

            foreach(DataRow fila in datos.Tables[0].Rows)
            {
                Alquiler unAlquiler = new Alquiler(
                
                    int.Parse(fila[0].ToString()),
                    DateTime.Parse(fila[1].ToString()),
                    DateTime.Parse(fila[2].ToString()),
                    DateTime.Parse(fila[3].ToString()),
                    controladora.BuscarVehiculo(int.Parse(fila[4].ToString())),
                    controladora.BuscarCliente(int.Parse(fila[5].ToString())),
                    fila[6].ToString(),
                    controladora.BuscarAccesorios(int.Parse(fila[7].ToString())),
                    fila[8].ToString(),
                    fila[9].ToString(),
                    double.Parse(fila[10].ToString()),
                    fila[11].ToString()
                );
                lista.Add(unAlquiler);
            }
            return lista;
        }
        public bool Alta(Alquiler unAlquiler)
        {
            string sql = "INSERT INTO Alquiler (Id, FechaAlquiler, FechaRetiroV, FechaDevoV, Vehiculo, Cliente, ConductorAd, Accesorios, LugarRetiro, LugarDev, PrecioXDia, Estado) " +
                         "VALUES (" + unAlquiler.Id + ", '" + unAlquiler.FechaAlquiler.ToShortDateString() + "', '" + unAlquiler.FechaRetiroV.ToShortDateString() + "', '" +
                         unAlquiler.FechaDevoV.ToShortDateString() + "', " + unAlquiler.Vehiculo.Id + ", " + unAlquiler.Cliente.Id + ", '" + unAlquiler.ConductorAd + "', " +
                         unAlquiler.Accesorios.Id + ", '" + unAlquiler.LugarRetiro + "', '" + unAlquiler.LugarDev + "', " + unAlquiler.PrecioXDia + ", '" + unAlquiler.Estado + "')";
        
            return Conexion.Ejecutar(sql);
        }
        public bool Baja(int pId)
        {
            string sql = "DELETE FROM Alquiler WHERE Id = " + pId.ToString();
            
            return Conexion.Ejecutar(sql);
        }

        public bool Modificar(Alquiler unAlquiler)
        {
            string sql = "UPDATE Alquiler "
                       + "SET FechaAlquiler = '" + unAlquiler.FechaAlquiler.ToShortDateString() + "', "
                       + "FechaRetiroV = '" + unAlquiler.FechaRetiroV.ToShortDateString() + "', "
                       + "FechaDevoV = '" + unAlquiler.FechaDevoV.ToShortDateString() + "', "
                       + "Vehiculo = " + unAlquiler.Vehiculo.Id + ", "
                       + "Cliente = " + unAlquiler.Cliente.Id + ", "
                       + "ConductorAd = '" + unAlquiler.ConductorAd + "', "
                       + "Accesorios = " + unAlquiler.Accesorios.Id + ", "
                       + "LugarRetiro = '" + unAlquiler.LugarRetiro + "', "
                       + "LugarDev = '" + unAlquiler.LugarDev + "', "
                       + "PrecioXDia = " + unAlquiler.PrecioXDia + ", "
                       + "Estado = '" + unAlquiler.Estado + "' "
                       + "WHERE Id = " + unAlquiler.Id;

            return Conexion.Ejecutar(sql);
        }
        public int ProximoAlquilerId()
        {
            string sql = "SELECT (ISNULL(MAX(Id),0)+1) FROM Alquiler";
            DataSet datos = Conexion.Consulta(sql);
            DataRowCollection filas = datos.Tables[0].Rows;
            var campo = filas[0];
            int Id = int.Parse(campo[0].ToString());
            return Id;
        }
    }
}
