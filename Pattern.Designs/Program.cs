using Pattern.Creational.FactoryMethod.Database;
using Pattern.Creational.FactoryMethod.PayCards;
using Pattern.Creational.FactoryMethod.Product.Creator;

internal class Program
{
    private static void Main(string[] args)
    {
        ExecuteDelivery();
        ExecuteDatabase();
        ExecutePayCreditCard();
    }

    #region TransportDeliveryService

    public static void ExecuteDelivery()
    {
        // Transport - CreditCardFactory
        Console.WriteLine("Ship: Starting deliver by ship.");
        DeliveryService(new ConcreteCreatorShip());

        Console.WriteLine("Truck: Starting deliver by Truck.");
        DeliveryService(new ConcreteCreatorTruck());
    }

    public static void DeliveryService(Creator creator)
    {
        var service = creator.DeliveryService();
        Console.WriteLine(service);
    }

    #endregion

    #region ExecuteDatabase
    public static void ExecuteDatabase()
    {
        // Database - CreditCardFactory
        string query1 = "[SELECT *FROM PERSON]", query2 = "[SELECT *FROM ACCOUNTS]";
        Console.WriteLine("Oracle: Starting execution by Oracle.");
        Database(new ConcreteOracleDatabase(), query1);

        Console.WriteLine("SqlServer: Starting execution by SqlServer.");
        Database(new ConcreteSqlServerDatabase(), query2);
    }

    public static void Database(CreatorDataAnalysisEngine dataAnalysisEngine, string query)
    {

        dataAnalysisEngine.ProcessData(query);
    }

    #endregion

    #region PayCreditCard

    public static void ExecutePayCreditCard()
    {
        // Database - CreditCardFactory
        var payCard = new PayCardDto()
        {
            Amount = 100,
            CreditCard = "2356 3659 3699 1256",
            IdentificationUser = "1717181820",
        };
        Console.WriteLine("Visa: Starting pay credit card");
        PayCreditCard(new ConcreteCreditCardFactory(), "visa", payCard);

        Console.WriteLine("UnionPay: Starting pay credit card");
        payCard = new PayCardDto()
        {
            Amount = 400,
            CreditCard = "2356 3659 3699 1256",
            IdentificationUser = "1717181820",
        };
        PayCreditCard(new ConcreteCreditCardFactory(), "unionpay", payCard);

        Console.WriteLine("MasterCard: Starting pay credit card");
        payCard = new PayCardDto()
        {
            Amount = 600,
            CreditCard = "2356 3659 3699 1256",
            IdentificationUser = "1717181820",
        };
        PayCreditCard(new ConcreteCreditCardFactory(), "mastercard", payCard);
    }

    public static void PayCreditCard(CreditCardFactory creditCardFactory, string type, PayCardDto payCard)
    {
        var respuesta = creditCardFactory.PaidCreditCard(type, payCard.IdentificationUser, payCard.CreditCard, payCard.Amount,
            payCard.PaymentDescription);

        Console.WriteLine("RESPUESTA: " + respuesta.Mensaje);
        Console.WriteLine("CODIGO: " + respuesta.CodigoOperacion);
    }
    #endregion
}

public class PayCardDto()
{
    public string IdentificationUser { get; set; }
    public string CreditCard { get; set; }
    public int Amount { get; set; }
    public string? PaymentDescription { get; set; }
}