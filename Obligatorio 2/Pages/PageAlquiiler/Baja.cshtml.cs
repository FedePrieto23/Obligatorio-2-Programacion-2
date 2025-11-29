using Obligatorio_2.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Obligatorio_2.Pages.PageAlquiiler
{
    public class BajaModel : PageModel
    {
        public Alquiler alquiler { get; set; }
        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            alquiler = unaControladora.BuscarAlquiler(id);
        }

        public IActionResult OnPostEliminar()
        {
            Controladora unaControladora = new Controladora();
            int id = int.Parse(Request.Form["id"]);
            unaControladora.BajaAlquiler(id);
            return Redirect("./Lista");
        }
    }
}
