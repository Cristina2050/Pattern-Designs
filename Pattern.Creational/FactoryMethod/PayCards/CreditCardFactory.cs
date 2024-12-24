

namespace Pattern.Creational.FactoryMethod.PayCards
{
    public abstract class CreditCardFactory
    {
        public abstract ICreditCards FactortyMethod(string type);

        public RespuestaPagoDto PaidCreditCard(string type, string identificationUser, string creditCard,
            int amount, string? paymentDescription = null)
        {
            var respuesta = new RespuestaPagoDto();

            if(string.IsNullOrEmpty(identificationUser) || identificationUser?.Length > 13)
            {
                respuesta.CodigoOperacion = "0099";
                respuesta.Mensaje = "IDENTIFICACION INVÁLIDA";

                return respuesta;
            }

            if (string.IsNullOrEmpty(creditCard) || creditCard?.Length > 20)
            {
                respuesta.CodigoOperacion = "0099";
                respuesta.Mensaje = "TARJETA DE CREDITO INVÁLIDA";

                return respuesta;
            }

            if (amount <= 0)
            {
                respuesta.CodigoOperacion = "0099";
                respuesta.Mensaje = "EL VALOR DEL PAGO DEBE SER MAYOR A CERO ";
                return respuesta;
            }

            var servicioPagos = FactortyMethod(type);
            
            respuesta = servicioPagos.PaidCreditCard(identificationUser, creditCard, amount, paymentDescription);

            return respuesta;
        }
    }
}
