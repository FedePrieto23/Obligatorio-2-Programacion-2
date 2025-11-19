using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;

namespace Obligatorio_2.Pages.PageVehiculo
{
    public class ModificarModel : PageModel
    {
        public Vehiculo vehiculo { get; set; }
        public string Mensaje { get; set; }
        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            vehiculo = unaControladora.BuscarVehiculo(id);
        }
        public IActionResult OnPostAgregar()
        {
            try
            {
                if (Request.Form["id"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el ID");
                }
                if (Request.Form["matricula"] == string.Empty)
                {
                    throw new Exception("Debe ingresar su Matricula");
                }
                if (Request.Form["marca"] == string.Empty)
                {
                    throw new Exception("Debe ingresar la Marca");
                }
                if (Request.Form["modelo"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Modelo");
                }
                if (Request.Form["año"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Año");
                }
                if (Request.Form["tipo"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Tipo");
                }
                if (Request.Form["cappasajeros"] == string.Empty)
                {
                    throw new Exception("Debe ingresar la Capacidad de Pasajeros");
                }
                if (Request.Form["combustible"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Combustible");
                }
                if (Request.Form["color"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Color del Vehiculo");
                }
                if (Request.Form["precioxdia"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Precio por dia");
                }
                if (double.TryParse(Request.Form["precioxdia"], out _))
                {
                    throw new Exception("Debe ingresar el Precio por dia");
                }
                if (Request.Form["estado"] == string.Empty)
                {
                    throw new Exception("Debe ingresar el Estado del vehiculo");
                }


                int Id = int.Parse(Request.Form["id"]);
                string Matricula = Request.Form["matricula"];
                string Marca = Request.Form["marca"];
                string Modelo = Request.Form["modelo"];
                DateTime Año = DateTime.Parse(Request.Form["año"]);
                string Tipo = Request.Form["tipo"];
                int CapPasajeros = int.Parse(Request.Form["cappasajeros"]);
                string Combustible = Request.Form["combustible"];
                string Color = Request.Form["color"];
                double PrecioxDia = double.Parse(Request.Form["PrecioxDia"]);
                string Estado = Request.Form["estado"];
                Controladora unaControladora = new Controladora();
                unaControladora.ModificarVehiculo(Id, Matricula, Marca, Modelo, Año, Tipo, CapPasajeros,Combustible
                    Color, PrecioxDia, Estado);

                return Redirect("/PageVehiculo/Lista");
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
                int Id = int.Parse(Request.Form["id"]);
                OnGet(Id);
            }
            return Page();
        }
    }
}
