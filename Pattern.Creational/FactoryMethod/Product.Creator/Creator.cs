namespace Pattern.Creational.FactoryMethod.Product.Creator
{
    // The CreditCardFactory class declares the factory method that is supposed to return
    // an object of a Product class. The CreditCardFactory's subclasses usually provide
    // the implementation of this method.
    public abstract class Creator
    {
        // Note that the CreditCardFactory may also provide some default implementation of
        // the factory method.
        public abstract ITransportDeliveryService FactoryMethod();



        // Also note that, despite its name, the CreditCardFactory's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // transport from it.
        public string DeliveryService()
        {
            // Call the factory method to create a Product object.
            var transport = FactoryMethod();

            // Now, use the transport.
            var result = "FACTORY DELIVERY PRODUCTS: " + transport.Deliver();

            return result;
        }
    }
}
