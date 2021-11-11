using DesignPatterns.Solid.SingleResponsibility;
using DesignPatterns.Solid.SingleResponsibility.Good;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main()
        {
            #region Single Responsibility

            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(new ShoppingItem { Id = 123, Name = "Keyboard", Price = 450 });
            shoppingCart.Add(new ShoppingItem { Id = 124, Name = "Mouse", Price = 300 });
            shoppingCart.Add(new ShoppingItem { Id = 125, Name = "Monitor", Price = 2200 });

            var utils = new InvoiceUtility();
            utils.SaveToFile(shoppingCart, "C:\\Users\\Giorgi\\Desktop\\Invoice.txt", true);

            #endregion
        }
    }
}
