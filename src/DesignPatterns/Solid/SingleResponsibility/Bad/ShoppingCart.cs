using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DesignPatterns.Solid.SingleResponsibility.Bad
{
    public class ShoppingCart
    {
        private readonly List<ShoppingItem> _items = new();
        private int _count = 0;
        private decimal _totalPrice = 0;

        public void Add(ShoppingItem item)
        {
            _items.Add(item);
            _count++;
            _totalPrice += item.Price;
        }

        public void Remove(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item == null)
                throw new Exception("There is no item with that id.");

            _items.Remove(item);
            _count--;
            _totalPrice -= item.Price;
        }

        public override string ToString() => string.Join(Environment.NewLine, _items.Select(x => $"{x.Id} {x.Name} {x.Price}"));

        public string GetInvoiceInfo()
        {
            var info = new StringBuilder("Invoice:\n\n");
            info.AppendLine($"Items count: {_count}");
            info.AppendLine(string.Join(Environment.NewLine, _items.Select(x => $"{x.Name}: {x.Price}$")));
            info.AppendLine($"\nTotal price: {_totalPrice}$");

            return info.ToString();
        }


        // BAD PRACTICE ALERT: the class has too many responsibilities, including executing tasks which are irrelevant
        public void SaveToFile(string fileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
                File.WriteAllText(fileName, GetInvoiceInfo());
        }

        public void Print()
        {
            var text = GetInvoiceInfo();
            // Send this text to the printer
        }

        public void Send(string emailAddress)
        {
            var text = GetInvoiceInfo();
            // Create smtp client and implement a logic to send an email to the customer
        }
    }
}
