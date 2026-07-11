using Obligatorio_2.Dominio;
using Obligatorio_2.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Obligatorio_2.Pages.PageReportes
{
    public class VehiculosXAlquileresModel : PageModel
    {
        public List<Alquiler> AlquileresXVehiculo { get; set; }
        public List<Vehiculo> vehiculos { get; set; }
        public string Mensaje { get; set; } = "";
        public double Total { get; set; } = 0;
        public int CantidadAlquileres { get; set; } = 0;

        Controladora unaControladora = new Controladora();

        public void OnGet()
        {
            vehiculos = unaControladora.ListarVehiculos();
        }

        public void OnPostBuscar()
        {
            try
            {
                if (Request.Form["idVehiculos"] == string.Empty)
                {
                    throw new Exception("Debe seleccionar un Vehiculo");
                }

                int IdVehiculo = int.Parse(Request.Form["idVehiculos"]);
                AlquileresXVehiculo = unaControladora.AlquileresXVehiculo(IdVehiculo);
                Total = AlquileresXVehiculo.Sum(v => v.PrecioTotal);
                CantidadAlquileres = AlquileresXVehiculo.Count;
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
                Total = 0;
                CantidadAlquileres = 0;
            }

            vehiculos = unaControladora.ListarVehiculos();
        }

        public double CalculoTotal()
        {
            double suma = 0;
            foreach (var veh in AlquileresXVehiculo)
            {
                suma += veh.PrecioTotal;
            }
            return suma;
        }
    }
}
