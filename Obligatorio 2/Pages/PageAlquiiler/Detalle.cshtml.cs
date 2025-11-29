using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;

namespace Obligatorio_2.Pages.PageAlquiiler
{
    public class DetalleModel : PageModel
    {
        public Alquiler alquiler { get; set; }
        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            alquiler = unaControladora.BuscarAlquiler(id);
        }
    }
}
