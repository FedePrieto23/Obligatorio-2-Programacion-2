using Obligatorio_2.Dominio;

namespace Obligatorio_2.Persistencia
{
    public class PControladora
    {
        #region " Cliente "
        public List<Cliente> ListaClientes()
        {
            return new PCliente().ListaClientes();
        }
        public bool AltaCliente(Cliente mCliente)
        {
            return new PCliente().Alta(mCliente);
        }
        public bool BajaCliente(int pId)
        {
            return new PCliente().Baja(pId);
        }
        public bool ModificarCliente(Cliente mCliente)
        {
            return new PCliente().Modificar(mCliente);
        }
        public int ProximoClienteId()
        {
            return new PCliente().ProximoId();
        }
        #endregion

        #region " Vehiculos "
        public List<Vehiculo> ListaVehiculos()
        {
            return new PVehiculo().ListaVehiculos();
        }
        public bool AltaVehiculo(Vehiculo mVehiculo)
        {
            return new PVehiculo().Alta(mVehiculo);
        }
        public bool BajaVehiculo(int pId)
        {
            return new PVehiculo().Baja(pId);
        }
        public bool ModificarVehiculo(Vehiculo mVehiculo)
        {
            return new PVehiculo().Modificar(mVehiculo);
        }
        public int ProximoVehiculoId()
        {
            return new PVehiculo().ProximoId();
        }
        #endregion

        #region " Alquiler "
        public List<Alquiler> ListaAlquileres()
        {
            return new PAlquiler().ListaAlquileres();
        }
        public bool AltaAlquiler(Alquiler aAlquiler)
        {
            return new PAlquiler().Alta(aAlquiler);
        }
        public bool BajaAlquiler(int pId)
        {
            return new PAlquiler().Baja(pId);
        }
        public bool ModificarAlquiler(Alquiler aAlquiler)
        {
            return new PAlquiler().Modificar(aAlquiler);
        }
        public int ProximoAlquilerId()
        {
            return new PAlquiler().ProximoAlquilerId();
        }
        #endregion

        #region " Accesorios "
        //public List<Accesorio> ListaAccesorios()
        //{
        //    return new PAccesorio().ListaAccesorios();
        //}
        //public bool AltaAccesorio(Accesorio mAccesorio)
        //{
        //    return new PAccesorio().Alta(mAccesorio);
        //}
        //public bool BajaAccesorio(int pId)
        //{
        //    return new PAccesorio().Baja(pId);
        //}
        //public bool ModificarAccesorio(Accesorio mAccesorio)
        //{
        //    return new PAccesorio().Modificar(mAccesorio);
        //}
        //public int ProximoAccesorioId()
        //{
        //    return new PAccesorio().ProximoId();
        //}
        #endregion
    }
}

