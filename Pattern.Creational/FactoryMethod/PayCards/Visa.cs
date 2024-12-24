namespace Pattern.Creational.FactoryMethod.PayCards
{
    // Concret class of CreditCards: Visa
    internal class Visa : ICreditCards
    {
        RespuestaPagoDto ICreditCards.PaidCreditCard(string identificationUser, string creditCard,
            int amount, string? paymentDescription)
        {
            var respuesta = new RespuestaPagoDto();

            if(amount > 50000)
            {
                respuesta.CodigoOperacion = "0009999";
                respuesta.Mensaje = "NO SE ACEPTAN PAGOS MAYORES A 50000. SE DEBE PEDIR NOTA DE PAGO A LA ADMINISTRACIÓN";
                return respuesta;
            }

            respuesta.CodigoOperacion = "0009999";
            respuesta.Mensaje = $"NO SE PUDO PROCESAR EL PAGO A LA TARJETA VISA CON #{creditCard}." +
                $"VALOR: " + $"{amount}. USUARIO GENERADOR: {identificationUser}. DESCRIPCION: {paymentDescription}"; 

            return respuesta;
        }
    }
}
