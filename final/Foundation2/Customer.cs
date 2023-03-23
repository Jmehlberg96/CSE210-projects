using System;

class Customer {
    private string _name;
    private Address _address;

    public Customer(string name, Address address) {
        this._name = name;
        this._address = address;
    }

    public bool IsInUSA() {
        return _address.IsInUSA();
    }

    public string Name {
        get { return _name; }
    }

    public Address Address {
        get { return _address; }
    }
}