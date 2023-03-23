using System;

class Order {
    private Customer _customer;
    private Product[] _products;

    public Order(Customer customer, Product[] products) 
    {
        this._customer = customer;
        this._products = products;
    }

    public string PackingLabel() 
    {
            string packingLabel = "";
            foreach (Product p in _products) {
                packingLabel += $"   Item: {p.Item()} | ID: #{p.ProductId()}\n";
            }
            return packingLabel;
    }

    public string ShippingLabel () 
    {
            return $"   {_customer.Name()}\n{_customer.Address().FullAddress()}\n___________________________________";
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product p in _products) {
            totalPrice += p.CalculatePrice();
        }
        double shippingFee;
        if (_customer.IsInUSA())
        {
            shippingFee = 5;
        }
        else
        {
            shippingFee = 35;
        }
        double total = totalPrice + shippingFee;
        return Math.Round(total, 2);
    }
}