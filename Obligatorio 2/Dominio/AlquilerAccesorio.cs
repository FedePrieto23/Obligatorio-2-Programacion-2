namespace Obligatorio_2.Dominio
{
    public class AlquilerAccesorio
    {
        private int aId;  
        private string aNombre;
        private double aPrecio;

        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public double Precio { get { return aPrecio; } set { aPrecio = value; } }
    
        public AlquilerAccesorio(int pId, string pNombre, double pPrecio)
        {
            aId = pId;
            aNombre = pNombre;
            aPrecio = pPrecio;
        }
    }
}
