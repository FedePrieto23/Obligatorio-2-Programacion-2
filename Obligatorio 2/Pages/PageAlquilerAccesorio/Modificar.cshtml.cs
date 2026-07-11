using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;

namespace Obligatorio_2.Pages.PageAlquilerAccesorio
{
    public class ModificarModel : PageModel
    {
        public AlquilerAccesorio alquileraccesorio { get; set; }
        public string Mensaje { get; set; }

        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            alquileraccesorio = unaControladora.BuscarAlquilerAccesorio(id);
        }
        public IActionResult OnPostModificar()
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
                    throw new Exception("El Precio debe ser numérico");
                }
                int Id = int.Parse(Request.Form["id"]);
                string Nombre = Request.Form["nombre"];
                double Precio = double.Parse(Request.Form["precio"]);

                Controladora unaControladora = new Controladora();
                unaControladora.ModificarAlquilerAccesorio(Id, Nombre, Precio);

                return Redirect("/PageAlquilerAccesorio/Lista");
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
                int Id = int.Parse(Request.Form["id"]);
                OnGet(Id);
            }
            return Page();
        }
    }
}
