using System;

class Order {
    private Customer _customer;
    private Product[] _products;

    public Order(Customer customer, Product[] products) {
        this._customer = customer;
        this._products = products;
    }

    public double TotalPrice {
        get {
            double totalPrice = 0;
            foreach (Product p in _products) {
                totalPrice += p.Price;
            }
            return totalPrice + (_customer.IsInUSA() ? 5 : 35);
        }
    }

    public string PackingLabel {
        get {
            string packingLabel = "";
            foreach (Product p in _products) {
                packingLabel += $"{p.Name} ({p.ProductId})\n";
            }
            return packingLabel;
        }
    }

    public string ShippingLabel {
        get {
            return $"   {_customer.Name}\n{_customer.Address.FullAddress}\n___________________________________";
        }
    }
}