using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;

namespace Obligatorio_2.Pages.PageCliente
{
    public class DetalleModel : PageModel
    {
        public Cliente cliente { get; set; }
        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            cliente = unaControladora.BuscarCliente(id);
        }
    }
}
