using System;

class Product {
    private string _item;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string item, int productId, double price, int quantity) 
    {
        this._item = item;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;
    }

    public double Price() 
    {
        return _price * _quantity;
    }

    public string Item() 
    {
        return _item; 
    }

    public int ProductId() 
    {
         return _productId;
    }

    public double CalculatePrice()
    {
        return _price * _quantity;
    }

}