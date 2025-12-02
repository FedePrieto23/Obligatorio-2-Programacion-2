using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;

namespace Obligatorio_2.Pages.PageAlquilerAccesorio
{
    public class ListaModel : PageModel
    {
        public List<AlquilerAccesorio> AlquilerAccesorios { get; set; }
        Controladora unaControladora = new Controladora();
        public void OnGet()
        {
            AlquilerAccesorios = unaControladora.ListarAlquilerAccesorios();
        }
    }
}
