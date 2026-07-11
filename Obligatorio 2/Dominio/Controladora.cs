using Obligatorio_2.Persistencia;

namespace Obligatorio_2.Dominio
{
    public class Controladora
    {
        private PControladora Persistencia;

        private static List<Cliente> aListaClientes = new List<Cliente>();
        private static List<Vehiculo> aListaVehiculos = new List<Vehiculo>();
        private static List<Alquiler> aListaAlquileres = new List<Alquiler>();
        private static List<AlquilerAccesorio> aListaAlquilerAccesorios = new List<AlquilerAccesorio>();

        public Controladora()
        {
            Persistencia = new PControladora();
        }

        #region " Clientes "
        public int ProximoClienteId()
        {
            return Persistencia.ProximoClienteId();
        }
        public List<Cliente> ListarClientes()
        {
            aListaClientes = Persistencia.ListaClientes();
            return aListaClientes;
        }
        public Cliente BuscarCliente(int pId)
        {
            foreach (Cliente unCliente in aListaClientes)
            {
                if (unCliente.Id == pId)
                {
                    return unCliente;
                }
            }
            return null;
        }
        public bool AltaCliente(Cliente pCliente)
        {
            Cliente ComparoCliente = BuscarCliente(pCliente.Id);
            if (ComparoCliente == null)
            {
                if (Persistencia.AltaCliente(pCliente))
                {
                    aListaClientes.Add(pCliente);
                    return true;
                }
            }
            return false;
        }
        public bool BajaCliente(int pId)
        {
            Cliente unCliente = BuscarCliente(pId);
            if (unCliente != null)
            {
                if (Persistencia.BajaCliente(pId))
                {
                    aListaClientes.Remove(unCliente);
                    return true;
                }
            }
            return false;
        }
        public bool ModificarCliente(int pId, string pNombre, string pApellido, string pCedula, DateTime pFechaNac, string pTelefono, string pCelular, string pEmail, string pDireccion, string pNumLibreta, DateTime pFechaVencLibreta)
        {
            Cliente unCliente = BuscarCliente(pId);
            if (unCliente != null)
            {
                Cliente nuevoCliente = new Cliente(pId, pNombre, pApellido, pCedula, pFechaNac, pTelefono, pCelular, pEmail, pDireccion, pNumLibreta, pFechaVencLibreta);
                if (Persistencia.ModificarCliente(nuevoCliente))
                {
                    unCliente.Nombre = pNombre;
                    unCliente.Apellido = pApellido;
                    unCliente.Cedula = pCedula;
                    unCliente.FechaNac = pFechaNac;
                    unCliente.Telefono = pTelefono;
                    unCliente.Celular = pCelular;
                    unCliente.Email = pEmail;
                    unCliente.Direccion = pDireccion;
                    unCliente.NumLibreta = pNumLibreta;
                    unCliente.FechaVencLibreta = pFechaVencLibreta;
                    return true;
                }

            }
            return false;
        }

        #endregion

        #region " Vehiculos "

        public int ProximoVehiculoId()
        {
            return Persistencia.ProximoVehiculoId();
        }
        public List<Vehiculo> ListarVehiculos()
        {
            aListaVehiculos = Persistencia.ListaVehiculos();
            return aListaVehiculos;
        }
        public Vehiculo BuscarVehiculo(int pId)
        {
            foreach (Vehiculo unVehiculo in aListaVehiculos)
            {
                if (unVehiculo.Id == pId)
                {
                    return unVehiculo;
                }
            }
            return null;
        }
        public bool AltaVehiculo(Vehiculo pVehiculo)
        {
            Vehiculo ComparoVehiculo = BuscarVehiculo(pVehiculo.Id);
            if (ComparoVehiculo == null)
            {
                if (Persistencia.AltaVehiculo(pVehiculo))
                {
                    aListaVehiculos.Add(pVehiculo);
                    return true;
                }
            }
            return false;
        }
        public bool BajaVehiculo(int pId)
        {
            Vehiculo unVehiculo = BuscarVehiculo(pId);
            if (unVehiculo != null)
            {
                if (Persistencia.BajaVehiculo(pId))
                {
                    aListaVehiculos.Remove(unVehiculo);
                    return true;
                }
            }
            return false;
        }
        public bool ModificarVehiculo(int pId, string pMatricula, string pMarca, string pModelo, DateTime pAño, string pTipo, int pCapPasajeros, string pCombustible, string pColor, double pPrecioxDia, string pEstado)
        {
            Vehiculo unVehiculo = BuscarVehiculo(pId);
            if (unVehiculo != null)
            {
                Vehiculo nuevoVehiculo = new Vehiculo(pId, pMatricula, pMarca, pModelo, pAño, pTipo, pCapPasajeros, pCombustible, pColor, pPrecioxDia, pEstado);
                if (Persistencia.ModificarVehiculo(nuevoVehiculo))
                {
                    unVehiculo.Matricula = pMatricula;
                    unVehiculo.Marca = pMarca;
                    unVehiculo.Modelo = pModelo;
                    unVehiculo.Año = pAño;
                    unVehiculo.Tipo = pTipo;
                    unVehiculo.CapPasajeros = pCapPasajeros;
                    unVehiculo.Combustible = pCombustible;
                    unVehiculo.PrecioxDia = pPrecioxDia;
                    unVehiculo.Estado = pEstado;

                    return true;
                }

            }
            return false;
        }
        #endregion

        #region " Alquiler "

        public int ProximoAlquilerId()
        {
            return Persistencia.ProximoAlquilerId();
        }

        public List<Alquiler> ListarAlquileres()
        {
            aListaAlquileres = Persistencia.ListaAlquileres();
            return aListaAlquileres;
        }

        public List<Alquiler> ListarAlquileresPorCliente(int pIdCliente)
        {
            List<Alquiler> todos = ListarAlquileres();

            List<Alquiler> resultado = new List<Alquiler>();

            foreach (Alquiler unAlquiler in todos)
            {
                if (unAlquiler.Cliente != null && unAlquiler.Cliente.Id == pIdCliente)
                {
                    resultado.Add(unAlquiler);
                }
            }

            return resultado;
        }


        public List<Alquiler> ListarAlquilers()
        {
            return ListarAlquileres();
        }

        public Alquiler BuscarAlquiler(int pId)
        {
            foreach (Alquiler unAlquiler in aListaAlquileres)
            {
                if (unAlquiler.Id == pId)
                {
                    return unAlquiler;
                }
            }
            return null;
        }

        public bool AltaAlquiler(Alquiler pAlquiler)
        {
            Alquiler unAlquiler = BuscarAlquiler(pAlquiler.Id);
            if (unAlquiler == null)
            {
                if (Persistencia.AltaAlquiler(pAlquiler))
                {
                    aListaAlquileres.Add(pAlquiler);
                    return true;
                }
            }
            return false;
        }

        public bool BajaAlquiler(int pId)
        {
            Alquiler unAlquiler = this.BuscarAlquiler(pId);
            if (unAlquiler != null)
            {
                if (Persistencia.BajaAlquiler(pId))
                {
                    aListaAlquileres.Remove(unAlquiler);
                    return true;
                }
            }
            return false;
        }
        public bool ModificarAlquiler(int pId, DateTime pFechaAlquiler, DateTime pFechaRetiroV, DateTime pFechaDevoV, Vehiculo pVehiculo, Cliente pCliente, string pConductorAd,
            AlquilerAccesorio pAlquilerAccesorio, string pLugarRetiro, string pLugarDev, double pPrecioTotal, string pEstado)
        {
            Alquiler nuevoAlquiler = new Alquiler(pId, pFechaAlquiler, pFechaRetiroV, pFechaDevoV, pVehiculo, pCliente, pConductorAd,
                pAlquilerAccesorio, pLugarRetiro, pLugarDev, pPrecioTotal, pEstado);
            Alquiler unAlquiler = this.BuscarAlquiler(pId);
            if (unAlquiler != null)
            {
                if (Persistencia.ModificarAlquiler(nuevoAlquiler))
                {
                    unAlquiler.FechaAlquiler = pFechaAlquiler;
                    unAlquiler.FechaRetiroV = pFechaRetiroV;
                    unAlquiler.FechaDevoV = pFechaDevoV;
                    unAlquiler.Vehiculo = pVehiculo;
                    unAlquiler.Cliente = pCliente;
                    unAlquiler.ConductorAd = pConductorAd;
                    unAlquiler.AlquilerAccesorio = pAlquilerAccesorio;
                    unAlquiler.LugarRetiro = pLugarRetiro;
                    unAlquiler.LugarDev = pLugarDev;
                    unAlquiler.PrecioTotal = pPrecioTotal;
                    unAlquiler.Estado = pEstado;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region " Alquiler Accesorios "

        public List<AlquilerAccesorio> ListarAlquilerAccesorios()
        {
            aListaAlquilerAccesorios = Persistencia.ListaAlquilerAccesorios();
            return aListaAlquilerAccesorios;
        }
        public int ProximoAlquilerAccesorioId()
        {
            return Persistencia.ProximoAlquilerAccesorioId();
        }
        public AlquilerAccesorio BuscarAlquilerAccesorio(int pId)
        {
            foreach (AlquilerAccesorio unAlquilerAccesorio in aListaAlquilerAccesorios)
            {
                if (unAlquilerAccesorio.Id == pId)
                {
                    return unAlquilerAccesorio;
                }
            }
            return null;
        }
        public bool AltaAlquilerAccesorio(AlquilerAccesorio pAlquilerAccesorio)
        {
            AlquilerAccesorio unAlquilerAccesorio = this.BuscarAlquilerAccesorio(pAlquilerAccesorio.Id);
            if (unAlquilerAccesorio == null)
            {
                if (Persistencia.AltaAlquilerAccesorio(pAlquilerAccesorio))
                {
                    aListaAlquilerAccesorios.Add(pAlquilerAccesorio);
                    return true;
                }
            }
            return false;
        }
        public bool BajaAlquilerAccesorio(int pId)
        {
            AlquilerAccesorio unAlquilerAccesorio = this.BuscarAlquilerAccesorio(pId);
            if (unAlquilerAccesorio != null)
            {
                if (Persistencia.BajaAlquilerAccesorio(pId))
                {
                    aListaAlquilerAccesorios.Remove(unAlquilerAccesorio);
                    return true;
                }
            }
            return false;
        }
        public bool ModificarAlquilerAccesorio(int pId, string pNombre, double pPrecio)
        {
            AlquilerAccesorio nuevoAlquilerAccesorio = new AlquilerAccesorio(pId, pNombre, pPrecio);
            AlquilerAccesorio unAlquilerAccesorio = this.BuscarAlquilerAccesorio(pId);
            if (unAlquilerAccesorio != null)
            {
                if (Persistencia.ModificarAlquilerAccesorio(nuevoAlquilerAccesorio))
                {
                    unAlquilerAccesorio.Nombre = pNombre;
                    unAlquilerAccesorio.Precio = pPrecio;
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region " Reportes "
        
        public List<Alquiler> AlquileresXVehiculo(int pIdVehiculo)
        {
            List<Alquiler> lista = new List<Alquiler>();

            foreach (Alquiler unAlqui in aListaAlquileres)
            {
                if (unAlqui.Vehiculo.Id == pIdVehiculo)
                {
                    lista.Add(unAlqui);
                }
            }
            return lista;
        }
        public List<Alquiler> AlquileresXFecha(DateTime pFechaRetiroV, DateTime pFechaDevoV)
        {
            List<Alquiler> lista = new List<Alquiler>();

            foreach (Alquiler unAlqui in aListaAlquileres)
            {
                if (unAlqui.FechaRetiroV >= pFechaRetiroV && unAlqui.FechaDevoV <= pFechaDevoV)
                {
                    lista.Add(unAlqui);
                }
            }
            return lista;
        }

        public Cliente BuscarClientePorCedula(string pCedula)
        {
            foreach (Cliente unCliente in aListaClientes)
            {
                if (unCliente.Cedula == pCedula)
                {
                    return unCliente;
                }
            }
            return null;
        }

        #endregion

        #region Estadisticas
        public List<string> AlquileresPorMesDelAnio()
        {
            List<string> resultado = new List<string>();
            int[] cantidades = new int[13];
            double[] montos = new double[13];

            for (int i = 0; i < 13; i++)
            {
                cantidades[i] = 0;
                montos[i] = 0;
            }

            short anioActual = short.Parse(DateTime.Now.Year.ToString());

            foreach (Alquiler unAlquiler in aListaAlquileres)
            {
                DateTime fecha = unAlquiler.FechaAlquiler;
                short anioAlquiler = short.Parse(fecha.Year.ToString());
                short mesAlquiler = short.Parse(fecha.Month.ToString());

                if (anioAlquiler == anioActual)
                {
                    cantidades[mesAlquiler] = cantidades[mesAlquiler] + 1;
                    montos[mesAlquiler] = montos[mesAlquiler] + unAlquiler.PrecioTotal;
                }
            }

            string[] nombresMes = new string[]
            {
        "null", "Enero", "Febrero", "Marzo", "Abril", "Mayo",
        "Junio", "Julio", "Agosto", "Setiembre", "Octubre",
        "Noviembre", "Diciembre"
            };

            for (int i = 1; i < 13; i++)
            {
                string linea = nombresMes[i] + ";" + cantidades[i] + ";" + montos[i].ToString("N2");
                resultado.Add(linea);
            }

            return resultado;
        }

        public double GananciasAnioActual()
        {
            double total = 0;
            short anioActual = short.Parse(DateTime.Now.Year.ToString());

            foreach (Alquiler unAlquiler in aListaAlquileres)
            {
                DateTime fecha = unAlquiler.FechaAlquiler;
                short anioAlquiler = short.Parse(fecha.Year.ToString());

                if (anioAlquiler == anioActual)
                {
                    total = total + unAlquiler.PrecioTotal;
                }
            }

            return total;
        }


        #endregion

        #region " Cargo Listas "
        public void CargoListas()
        {
            ListarClientes();
            ListarVehiculos();
            ListarAlquileres();
            ListarAlquilerAccesorios();
        }
        #endregion
    }
}

