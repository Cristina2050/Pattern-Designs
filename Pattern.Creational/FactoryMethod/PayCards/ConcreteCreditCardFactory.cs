
namespace Pattern.Creational.FactoryMethod.PayCards
{
    public class ConcreteCreditCardFactory : CreditCardFactory
    {
        public override ICreditCards FactortyMethod(string type)
        {
            return type.ToLower() switch
            {
                "visa" => new Visa(),
                "unionpay" => new UnionPay(),
                "mastercard" => new MasterCard(),
                _ => throw new ArgumentException("Invalid credit card"),
            };
        }
    }
}
