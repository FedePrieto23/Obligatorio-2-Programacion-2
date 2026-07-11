using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;

namespace Obligatorio_2.Pages.PageAlquilerAccesorio
{
    public class AltaModel : PageModel
    {
        public string Mensaje { get; set; }
        public int id { get; set; } = 1;
        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            id = unaControladora.ProximoAlquilerAccesorioId();
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
                if (Request.Form["precio"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Precio");
                }
                if (!double.TryParse(Request.Form["precio"], out _))
                {
                    throw new Exception("el precio debe ser numérico");
                }

                int Id = int.Parse(Request.Form["id"]);
                string Nombre = Request.Form["nombre"];
                double Precio = double.Parse(Request.Form["precio"]);

                AlquilerAccesorio unAlquilerAccesorio = new AlquilerAccesorio(Id, Nombre, Precio);

                Controladora unaControladora = new Controladora();
                unaControladora.AltaAlquilerAccesorio(unAlquilerAccesorio);
                return Redirect("/PageAlquilerAccesorio/Lista");
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
            }
            return Page();
        }
    }
}
