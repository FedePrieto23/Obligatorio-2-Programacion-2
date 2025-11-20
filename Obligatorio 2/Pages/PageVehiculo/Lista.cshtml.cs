using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;
using Obligatorio_2.Persistencia;

namespace Obligatorio_2.Pages.PageVehiculo
{
    public class ListaModel : PageModel
    {
        public List<Vehiculo> Vehiculos { get; set; }
        Controladora unaControladora = new Controladora();
        public void OnGet()
        {
            Vehiculos = unaControladora.ListarVehiculos();
        }
    }
}
