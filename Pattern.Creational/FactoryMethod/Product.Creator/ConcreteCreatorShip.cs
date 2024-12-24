namespace Pattern.Creational.FactoryMethod.Product.Creator
{
    public class ConcreteCreatorShip : Creator
    {
        public override ITransportDeliveryService FactoryMethod()
        {
            return new Ship();
        }
    }
}
