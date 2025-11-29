using Obligatorio_2.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Obligatorio_2.Pages.PageCliente
{
    public class AltaModel : PageModel
    {
        public string Mensaje { get; set; }
        public int id { get; set; } = 1;
        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            id = unaControladora.ProximoClienteID();
        }
        public IActionResult OnPostAgregar()
        {
            try
            {
                if (Request.Form["id"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el ID");
                }
                if (!int.TryParse(Request.Form["id"], out _))
                {
                    throw new Exception("El ID debe ser numérico");
                }
                if (Request.Form["nombre"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Nombre");
                }
                if (Request.Form["apellido"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Apellido");
                }
                if (Request.Form["cedula"] == string.Empty)
                {
                    throw new Exception("Debe ingresar la Cedula");
                }
                if (Request.Form["fechanac"] == string.Empty)
                {
                    throw new Exception("Debe ingresar su Fecha de Nacimiento");
                }
                if (Request.Form["telefono"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Teléfono");
                }
                if (Request.Form["celular"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Celular");
                }
                if (Request.Form["email"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Email");
                }
                if (Request.Form["direccion"] == string.Empty)
                {
                    throw new Exception("Debe ingresar la Dirección");
                }
                if (Request.Form["numlibreta"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Nùmero de la Libreta");
                }
                if (Request.Form["fechavenclibreta"] == string.Empty)
                {
                    throw new Exception("Debe ingresar Fecha de Vencimiento de la Libreta");
                }

                int Id = int.Parse(Request.Form["id"]);
                string Nombre = Request.Form["nombre"];
                string Apellido = Request.Form["apellido"];
                string Cedula = Request.Form["cedula"];
                DateTime FechaNac = DateTime.Parse(Request.Form["fechanac"]);
                string Telefono = Request.Form["telefono"];
                string Celular = Request.Form["celular"];
                string Email = Request.Form["email"];
                string Direccion = Request.Form["direccion"];
                string NumLibreta = Request.Form["numlibreta"];
                DateTime FechaVencLibreta = DateTime.Parse(Request.Form["fechavenclibreta"]);

                Cliente unCliente = new Cliente(
                    Id,
                    Nombre,
                    Apellido,
                    Cedula,
                    FechaNac,
                    Telefono,
                    Celular,
                    Email,
                    Direccion,
                    NumLibreta,
                    FechaVencLibreta
                );
                Controladora unaControladora = new Controladora();
                unaControladora.AltaCliente(unCliente);
                return Redirect("/PageCliente/Lista");
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
            }
            return Page();
        }
    }
}
