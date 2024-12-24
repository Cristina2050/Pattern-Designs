

namespace Pattern.Creational.FactoryMethod.PayCards
{
    // Concret class of CreditCards: UnionPay
    internal class UnionPay : ICreditCards
    {
        RespuestaPagoDto ICreditCards.PaidCreditCard(string identificationUser, string creditCard,
            int amount, string? paymentDescription)
        {
            var respuesta = new RespuestaPagoDto();

            if (string.IsNullOrEmpty(paymentDescription))
            {
                respuesta.CodigoOperacion = "0009999";
                respuesta.Mensaje = "SE REQUIERE LA DESCRIPCION DEL PAGO";
                return respuesta;
            }

            respuesta.CodigoOperacion = "22336655";
            respuesta.Mensaje = $"SE REALIZÓ UN ABONO A LA TARJETA UNIONPAY CON #{creditCard} POR EL VALOR DE " +
                $"{amount}. USUARIO GENERADOR: {identificationUser}";

            return respuesta;
        }
    }
}
