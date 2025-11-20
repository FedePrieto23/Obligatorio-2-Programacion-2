using Obligatorio_2.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Obligatorio_2.Pages.PageCliente
{
    public class BajaModel : PageModel
    {
        public Cliente cliente { get; set; }

        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            cliente = unaControladora.BuscarCliente(id);
        }
        public IActionResult OnPostEliminar()
        {
            Controladora unaControladora = new Controladora();
            int Id = int.Parse(Request.Form["id"]);
            unaControladora.BajaCliente(Id);
            return Redirect("./Lista");
        }
    }
}
