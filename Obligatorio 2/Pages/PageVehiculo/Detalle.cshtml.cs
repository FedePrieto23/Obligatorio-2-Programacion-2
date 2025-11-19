using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;

namespace Obligatorio_2.Pages.PageVehiculo
{
    public class DetalleModel : PageModel
    {
        public Vehiculo vehiculo { get; set; }
        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            vehiculo = unaControladora.BuscarVehiculo(id);
        }
    }
}
