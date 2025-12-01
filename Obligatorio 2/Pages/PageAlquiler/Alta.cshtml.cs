using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;

namespace Obligatorio_2.Pages.PageAlquiiler
{
    public class AltaModel : PageModel
    {
        public string Mensaje { get; set; }
        public int id { get; set; } = 1;
        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            id = unaControladora.ProximoClienteId();
        }
        public IActionResult OnPostAgregar()
        {
            try
            {
                if (Request.Form["id"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el ID");
                }
                if (!int.TryParse(Request.Form["id"], out _))
                {
                    throw new Exception("El ID debe ser numérico");
                }
                if (Request.Form["fechaalquiler"] == string.Empty)
                {
                    throw new Exception("Debe ingresar la fecha del alquiler");
                }
                if (!DateTime.TryParse(Request.Form["fechaalquiler"], out DateTime fechaalquiler))
                {
                    throw new Exception("El formato de Fecha no es válido");
                }
                if (Request.Form["fecharetirov"] == string.Empty)
                {
                    throw new Exception("Debe ingresar la fecha de retiro");
                }
                if (!DateTime.TryParse(Request.Form["fecharetirov"], out DateTime fecharetirov))
                {
                    throw new Exception("El formato de Fecha no es válido");
                }
                if (Request.Form["fechadevov"] == string.Empty)
                {
                    throw new Exception("Debe ingresar la fecha de devolucion");
                }
                if (!DateTime.TryParse(Request.Form["fechadevov"], out DateTime fechadevov))
                {
                    throw new Exception("El formato de Fecha no es válido");
                }
                if (Request.Form["vehiculo"] == string.Empty)
                {
                    throw new Exception("Debe seleccionar un vehiculo");
                }
                if (Request.Form["cliente"] == string.Empty)
                {
                    throw new Exception("Debe seleccionar un cliente");
                }
                if (Request.Form["conductorad"] == string.Empty)
                {
                    throw new Exception("Debe ingresar un conductor adicional");
                }
                if (Request.Form["accesorios"] == string.Empty)
                {
                    throw new Exception("Debe seleccionar un accesorio");
                }
                if (Request.Form["lugarretiro"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el lugar de retiro");
                }
                if (Request.Form["precioxdia"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el precio por dia");
                }
                if (double.TryParse(Request.Form["preciototal"], out _))
                {
                    throw new Exception("Debe ingresar el Precio total");
                }
                if (double.TryParse(Request.Form["precioxdia"], out _))
                {
                    throw new Exception("Debe ingresar el Precio por dia");
                }
                if (Request.Form["estado"] == string.Empty)
                {
                    throw new Exception("Debe ingresar Estado");
                }

                Controladora unaControladora = new Controladora();

                int Id = int.Parse(Request.Form["id"]);
                DateTime FechaAlquiler = DateTime.Parse(Request.Form["fechaalquiler"]);
                DateTime FechaRetiroV = DateTime.Parse(Request.Form["fecharetirov"]);
                DateTime FechaDevov = DateTime.Parse(Request.Form["fechadevov"]);
                string ConductorAd = Request.Form["conductorad"];
                string LugarRetiro = Request.Form["lugaretiro"];
                string LugarDev = Request.Form["lugardev"];
                double PrecioTotal = double.Parse(Request.Form["preciototal"]);
                string Estado = Request.Form["estado"];

                int idCliente = int.Parse(Request.Form["idCliente"]);
                Cliente unCliente = unaControladora.BuscarCliente(idCliente);

                int idVehiculo= int.Parse(Request.Form["idVehiculo"]);
                Vehiculo unVehiculo = unaControladora.BuscarVehiculo(idVehiculo);

                int idAccesorio = int.Parse(Request.Form["idAccesorios"]);
                AlquilerAccesorio unAlquilerAccesorio = unaControladora.BuscarAlquilerAccesorio(idAlquilerAccesorio);

                Alquiler unAlquiler= new Alquiler(Id, FechaAlquiler, FechaRetiroV, FechaDevov, ConductorAd, LugarRetiro, LugarDev, PrecioTotal, Estado, unCliente, unAlquilerAccesorio);

                unaControladora.AltaCliente(unCliente);
                return Redirect("/PageCliente/Lista");
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
            }
            return Page();
        }
    }
}