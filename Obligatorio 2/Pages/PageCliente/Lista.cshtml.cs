using Obligatorio_2.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Obligatorio_2.Pages.PageCliente
{
    public class ListaModel : PageModel
    {
        public List<Cliente> Clientes { get; set; }
        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            Clientes = unaControladora.ListarClientes();
        }
    }
}