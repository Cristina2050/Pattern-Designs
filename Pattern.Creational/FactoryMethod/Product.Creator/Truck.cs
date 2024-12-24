namespace Pattern.Creational.FactoryMethod.Product.Creator
{
    // El producto Truck(Camión) implementa el servicio de entrega de paquetes. 
    internal class Truck : ITransportDeliveryService
    {
        public string Deliver()
        {
            return "Truck is delivering a package by the road.";
        }
    }
}
