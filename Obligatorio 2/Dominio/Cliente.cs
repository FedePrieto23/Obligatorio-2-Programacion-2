
namespace Obligatorio_2.Dominio
{
    public class Cliente
    {
        private int aId;
        private string aNombre;
        private string aApellido;
        private string aCedula;
        private DateTime aFechaNac;
        private string aTelefono;
        private string aCelular;
        private string aEmail;
        private string aDireccion;
        private string aNumLibreta;
        private DateTime aFechaVencLibreta;

        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public string Apellido { get { return aApellido; } set { aApellido = value; } }
        public string Cedula { get { return aCedula; } set { aCedula = value; } }
        public DateTime FechaNac { get { return aFechaNac; } set { aFechaNac = value; } }
        public string Telefono { get { return aTelefono; } set { aTelefono = value; } }
        public string Celular { get { return aCelular; } set { aCelular = value; } }
        public string Email { get { return aEmail; } set { aEmail = value; } } 
        public string Direccion { get { return aDireccion; } set { aDireccion = value; } }
        public string NumLibreta { get { return aNumLibreta; } set { aNumLibreta = value; } }
        public DateTime FechaVencLibreta { get { return aFechaVencLibreta; } set { aFechaVencLibreta = value; } }

        public Cliente(int pId, string pNombre, string pApellido, string pCedula, DateTime pFechaNac, string pTelefono, string pCelular, string pEmail,
           string pDireccion, string pNumLibreta, DateTime pFechaVencLibreta)
        {
            aId = pId;
            aNombre = pNombre;
            aApellido = pApellido;
            aCedula = pCedula;
            aFechaNac = pFechaNac;
            aTelefono = pTelefono;
            aCelular = pCelular;
            aEmail = pEmail;
            aDireccion = pDireccion;
            aNumLibreta = pNumLibreta;
            aFechaVencLibreta = pFechaVencLibreta;
        }
    }
}
