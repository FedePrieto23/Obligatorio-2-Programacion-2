using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;

namespace Obligatorio_2.Pages.PageAlquiiler
{
    public class ListaModel : PageModel
    {
        public List<Alquiler> alquiler{ get; set; }
        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            alquiler = unaControladora.ListarAlquileres();
        }
    }
}
