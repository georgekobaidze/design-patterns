using System.IO;

namespace DesignPatterns.Solid.SingleResponsibility
{
    public class InvoiceUtility
    {
        public void SaveToFile(ShoppingCart cart, string fileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
                File.WriteAllText(fileName, cart.GetInvoiceInfo());
        }

        public void Print(ShoppingCart cart)
        {
            var text = cart.GetInvoiceInfo();
            // Send this text to the printer
        }

        public void Send(ShoppingCart cart, string emailAddress)
        {
            var text = cart.GetInvoiceInfo();
            // Create smtp client and implement a logic to send an email to the customer
        }
    }
}
