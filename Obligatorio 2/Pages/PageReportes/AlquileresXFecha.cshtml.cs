using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;

namespace Obligatorio_2.Pages.PageReportes
{
    public class AlquileresXFechaModel : PageModel
    {
        public List<Alquiler> AlquileresXFecha { get; set; }
        public string Mensaje { get; set; } = "";
        public double PrecioTotal { get; set; } = 0;
        public DateTime FechaRetiroV { get; set; } = DateTime.Now.AddDays(-7);
        public DateTime FechaDevoV { get; set; } = DateTime.Now;

        Controladora unaControladora = new Controladora();
        public void OnGet()
        {
        }
        public void OnPostBuscar()
        {
            try
            {
                if (Request.Form["fecharetirov"] == string.Empty)
                {
                    throw new Exception("Debe seleccionar la fecha de retiro");
                }
                if (Request.Form["fechadevov"] == string.Empty)
                {
                    throw new Exception("Debe seleccionar la fecha de devolucion");
                }

                DateTime pFechaRetiroV = DateTime.Parse(Request.Form["fecharetirov"]);
                DateTime pFechaDevoV = DateTime.Parse(Request.Form["fechadevov"]);

                AlquileresXFecha = unaControladora.AlquileresXFecha(pFechaRetiroV, pFechaDevoV);
                PrecioTotal = AlquileresXFecha.Sum(c => c.PrecioTotal);
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
            }

        }
    }
}
