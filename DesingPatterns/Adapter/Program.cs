namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //PayPal payment = new PayPal();
            //IPayPalPayment payment = new PayonnerAdapter(new Payonner());
            IPayPalPayment payment = new MercadoPagoAdapter(new MercadoPago());

            payment.PayPalPayment();
            payment.PayPalReceive();

            Console.ReadLine();
        }
    }
}