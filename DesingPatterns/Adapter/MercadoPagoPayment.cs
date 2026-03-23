namespace Adapter
{
    interface IMercadoPagoPayment
    {
        Token AuthToken();
        void MercadoPagoPayment();
        void MercadoPagoReceive();
    }
}
