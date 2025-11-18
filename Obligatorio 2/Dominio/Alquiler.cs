namespace Obligatorio_2.Dominio
{
    public class Alquiler
    {
        private int aId;
        private DateTime aFechaAlquiler;
        private DateTime aFechaRetiroV;a
        private DateTime aFechaDevoV;
        private Vehiculo aVehiculo;
        private Cliente aCliente;
        private string aConductorAd;
        private Accesorios aAccesorios;
        private string aLugarRetiro;
        private string aLugarDev;
        private double aPrecioXDia;
        private string aEstado;

        public int Id { get { return aId; } set { aId = value; } }
        public DateTime FechaAlquiler { get { return aFechaAlquiler; } set { aFechaAlquiler = value; } }
        public DateTime FechaRetiroV { get { return aFechaRetiroV; } set { aFechaRetiroV = value; } }
        private DateTime FechaDevoV { get { return aFechaDevoV; } set { aFechaDevoV = value; } }
        private Vehiculo Vehiculo { get { return aVehiculo; } set { aVehiculo = value; } } 
        private Cliente Cliente { get { return aCliente; } set { aCliente = value; } }
        private string AConductorAd { get { return aConductorAd; } set { aConductorAd = value; } }
        private Accesorios Accesorios { get { return aAccesorios; } set { aAccesorios = value; } }
        private string LugarRetiro { get { return aLugarRetiro; } set { aLugarRetiro = value; } }
        private string LugarDev {  get { return aLugarDev; } set { aLugarDev = value; }}
        private double PrecioXDia { get { return aPrecioXDia; } set { aPrecioXDia = value; } }
        private string Estado {  get { return aEstado; } set { aEstado = value; } }

        public Alquiler(int pId, DateTime pFechaAlquiler, DateTime pFechaRetiroV, DateTime pFechaDevoV, Vehiculo pVehiculo, Cliente pCliente, 
            string pConductorAd, Accesorios pAccesorios, string pLugarRetiro, string pLugarDev, double pPrecioXDia, string pEstado)
        {
            aId = pId;
            aFechaAlquiler = pFechaAlquiler;
            aFechaRetiroV = pFechaRetiroV;
            aFechaDevoV = pFechaDevoV;
            aVehiculo = pVehiculo;
            aCliente = pCliente;
            aConductorAd = pConductorAd;
            aAccesorios = pAccesorios;
            aLugarRetiro = pLugarRetiro;
            aLugarDev = pLugarDev;
            aPrecioXDia = pPrecioXDia;
            aEstado = pEstado;
        }
    }
}
