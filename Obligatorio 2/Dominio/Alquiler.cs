namespace Obligatorio_2.Dominio
{
    public class Alquiler
    {
        private int aId;
        private DateTime aFechaAlquiler;
        private DateTime aFechaRetiroV;
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
        public DateTime FechaDevoV { get { return aFechaDevoV; } set { aFechaDevoV = value; } }
        public Vehiculo Vehiculo { get { return aVehiculo; } set { aVehiculo = value; } }
        public Cliente Cliente { get { return aCliente; } set { aCliente = value; } }
        public string ConductorAd { get { return aConductorAd; } set { aConductorAd = value; } }
        public Accesorios Accesorios { get { return aAccesorios; } set { aAccesorios = value; } }
        public string LugarRetiro { get { return aLugarRetiro; } set { aLugarRetiro = value; } }
        public string LugarDev { get { return aLugarDev; } set { aLugarDev = value; } }
        public double PrecioXDia { get { return aPrecioXDia; } set { aPrecioXDia = value; } }
        public string Estado { get { return aEstado; } set { aEstado = value; } }

        public Alquiler(int pId, DateTime pFechaAlquiler, DateTime pFechaRetiroV, DateTime pFechaDevoV,
                        Vehiculo pVehiculo, Cliente pCliente,
                        string pConductorAd, Accesorios pAccesorios,
                        string pLugarRetiro, string pLugarDev,
                        double pPrecioXDia, string pEstado)
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

        public Alquiler() { }
    }
}
D
