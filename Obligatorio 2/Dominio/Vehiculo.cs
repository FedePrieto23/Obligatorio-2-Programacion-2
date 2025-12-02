namespace Obligatorio_2.Dominio
{
    public class Vehiculo
    {
        private int aId;
        private string aMatricula;
        private string aMarca;
        private string aModelo;
        private DateTime aAño;
        private string aTipo;
        private int aCapPasajeros;
        private string aCombustible;
        private string aColor;
        private double aPrecioxDia;
        private string aEstado;

        public int Id 
            { get { return aId; } set { aId = value; } }
        public string Matricula
            { get { return aMatricula; } set { aMatricula = value; } }
        public string Marca
            { get { return aMarca; } set { aMarca = value; } }
        public string Modelo
            { get { return aModelo; } set { aModelo = value; } }
        public DateTime Año
            { get { return aAño; } set { aAño = value; } }
        public string Tipo 
            { get { return aTipo; } set { aTipo = value; } }
        public int CapPasajeros
            { get { return aCapPasajeros; } set { aCapPasajeros = value; } }
        public string Combustible
            { get { return aCombustible; } set { aCombustible = value; } }
        public string Color 
            { get { return aColor; } set { aColor = value; } }
        public double PrecioxDia
            { get { return aPrecioxDia; } set { aPrecioxDia = value; } }
        public string Estado
            { get { return aEstado; } set { aEstado = value; } }

       public Vehiculo(int pId, string pMatricula, string pMarca, string pModelo, DateTime pAño, string pTipo, int pCapPasajeros,string pCombustible,
           string pColor, double pPrecioxDia, string pEstado)
        {
            aId = pId;
            aMatricula = pMatricula;
            aMarca = pMarca;
            aModelo = pModelo;
            aAño = pAño;
            aTipo = pTipo;
            aCapPasajeros = pCapPasajeros;
            aCombustible = pCombustible;
            aColor = pColor;
            aPrecioxDia = pPrecioxDia;
            aEstado = pEstado;

        }


    }
}
