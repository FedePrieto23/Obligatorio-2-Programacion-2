using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;
using System;
using System.Collections.Generic;

namespace Obligatorio_2.Pages.PageReportes
{
    public class AlquileresXClienteModel : PageModel
    {
        public string Cedula { get; set; } = "";
        public string Mensaje { get; set; } = "";

        public Cliente ClienteConsulta { get; set; }
        public List<Alquiler> AlquileresCliente { get; set; } = new List<Alquiler>();

        public void OnGet()
        {
        }

        public void OnPost()
        {
            try
            {
                Cedula = Request.Form["cedula"];

                if (string.IsNullOrEmpty(Cedula))
                {
                    throw new Exception("Debe ingresar la cédula o pasaporte del cliente.");
                }

                Controladora unaControladora = new Controladora();

                unaControladora.ListarClientes();
                unaControladora.ListarAlquileres();

                ClienteConsulta = unaControladora.BuscarClientePorCedula(Cedula);

                if (ClienteConsulta == null)
                {
                    throw new Exception("No existe un cliente con la cédula ingresada.");
                }

                AlquileresCliente = unaControladora.ListarAlquileresPorCliente(ClienteConsulta.Id);

                if (AlquileresCliente.Count == 0)
                {
                    Mensaje = "El cliente no tiene alquileres registrados.";
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                ClienteConsulta = null;
                AlquileresCliente = new List<Alquiler>();
            }
        }
    }
}

