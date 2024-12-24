namespace Pattern.Creational.FactoryMethod.Product.Creator
{

    // El objeto, producto o servicio de negocio, declara la interfaz, que es común a todos los
    // objetos que puede producir la clase creadora y sus subclases.
    // 
    // Para este ejemplo se ha considerado al transporte como un servicio ya que el mismo tiene varias
    // lineas de administración.
    public interface ITransportDeliveryService
    {
        // Deliver es el método en común que todos los tipos de servicio de transporte deben implementar. 
        string Deliver();
    }
}