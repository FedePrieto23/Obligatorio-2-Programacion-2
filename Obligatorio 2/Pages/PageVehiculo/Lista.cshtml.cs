using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;
using Obligatorio_2.Persistencia;

namespace Obligatorio_2.Pages.PageVehiculo
{
    public class ListaModel : PageModel
    {
        public List<Vehiculo> Vehiculos { get; set; }
        
        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            Vehiculos = unaControladora.ListarVehiculos();
        }
    }
}
