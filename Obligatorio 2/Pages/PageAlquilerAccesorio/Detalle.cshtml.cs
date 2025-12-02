using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;

namespace Obligatorio_2.Pages.PageAlquilerAccesorio
{
    public class DetalleModel : PageModel
    {
        public AlquilerAccesorio alquileraccesorio { get; set; }
        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            alquileraccesorio = unaControladora.BuscarAlquilerAccesorio(id);
        }
    }
}
