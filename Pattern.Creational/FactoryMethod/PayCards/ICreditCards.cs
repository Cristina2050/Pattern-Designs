namespace Pattern.Creational.FactoryMethod.PayCards
{
    public interface ICreditCards
    {
        RespuestaPagoDto PaidCreditCard(string identificationUser, string creditCard, 
            int amount, string? paymentDescription = null);
    }
}
