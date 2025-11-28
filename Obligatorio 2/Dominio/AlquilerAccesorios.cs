namespace Obligatorio_2.Dominio
{
    public class AlquilerAccesorios
    {
        private int aId;  
        private string aNombre;
        private int aCantidad;

        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public int Cantidad { get { return aCantidad; } set { aCantidad = value; } }
    
        public AlquilerAccesorios(int pId, string pNombre, int pCantidad)
        {
            aId = pId;
            aNombre = pNombre;
            aCantidad = pCantidad;
        }
    }
}
