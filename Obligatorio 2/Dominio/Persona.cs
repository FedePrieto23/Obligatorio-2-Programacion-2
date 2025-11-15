namespace Obligatorio_2.Dominio
{
    public class Persona
    {
        private int aId;
        private string aNombre;
        private string aApellido;

        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public string Apellido { get { return aApellido; } set { aApellido = value; } }
        public Persona(int pId, string pNombre, string pApellido) 
        { 
            aId = pId;
            aNombre = pNombre;
            aApellido = pApellido;
        }
    }
}
