
namespace Pattern.Creational.FactoryMethod.PayCards
{
    // Concret class of CreditCards: MasterCard
    internal class MasterCard : ICreditCards
    {
        public RespuestaPagoDto PaidCreditCard(string identificationUser, string creditCard,
            int amount, string? paymentDescription = null)
        {
            var respuesta = new RespuestaPagoDto();

            if (identificationUser.Any(char.IsLetter))
            {
                respuesta.CodigoOperacion = "0009999";
                respuesta.Mensaje = "NO ESTÁ PERMITIDO EL PAGO CON PASAPORTE";
                return respuesta;
            }

            respuesta.CodigoOperacion = "123456";
            respuesta.Mensaje = $"EL ABONO REALIZADO A LA TARJETA MASTERCARD CON #{creditCard} POR EL VALOR DE " +
            $"{amount} FUE REALIZADO CON EXITO. Usuario: {identificationUser}";

            return respuesta;
        }
    }
}
