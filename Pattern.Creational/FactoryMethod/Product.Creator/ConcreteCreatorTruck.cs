namespace Pattern.Creational.FactoryMethod.Product.Creator
{
    public class ConcreteCreatorTruck : Creator
    {
        public override ITransportDeliveryService FactoryMethod()
        {
            return new Truck();
        }
    }
}
