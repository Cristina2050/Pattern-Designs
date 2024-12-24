namespace Pattern.Creational.FactoryMethod.Product.Creator
{
    // El producto Ship(Barco) implementa el servicio de entrega de paquetes. 
    internal class Ship : ITransportDeliveryService
    {
        public string Deliver()
        {
             return "Ship is delivering a package by the ocean.";
        }
    }
}
