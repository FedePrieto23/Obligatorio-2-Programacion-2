using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio_2.Dominio;
using Obligatorio_2.Persistencia;

namespace Obligatorio_2.Pages.PageReportes
{
    public class AlquileresXMesModel : PageModel
    {
        public List<string> AlquileresMes { get; set; } = new List<string>();
        public string Mensaje { get; set; } = "";
        public double TotalAnual { get; set; } = 0;

        Controladora unaControladora = new Controladora();

        public void OnGet()
        {
            try
            {
                AlquileresMes = unaControladora.AlquileresPorMesDelAnio();
                TotalAnual = unaControladora.GananciasAnioActual();
            }
            catch (Exception error)
            {
                Mensaje = error.Message;
            }
        }
    }
}

