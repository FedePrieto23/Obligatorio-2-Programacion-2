using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;
using Obligatorio_2.Persistencia;

namespace Obligatorio_2.Pages.PageVehiculo
{
    public class BajaModel : PageModel
    {
        public Vehiculo vehiculo { get; set; }
        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            vehiculo = unaControladora.BuscarVehiculo(id);
        }
        public IActionResult OnPostEliminar()
        {
            Controladora unaControladora = new Controladora();
            int Id = int.Parse(Request.Form["id"]);
            unaControladora.BajaVehiculo(Id);
            return Redirect("./Lista");
        }
    }
}
