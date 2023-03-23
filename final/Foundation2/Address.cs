using System;


class Address {
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _zipCode;

    public Address(string street, string city, string state, string zip, string country) {
        this._street = street;
        this._city = city;
        this._state = state;
        this._zipCode = zip;
        this._country = country;
        
    }

    public string FullAddress ()
    {
         return $"   {_street}\n   {_city}, {_state} {_zipCode}\n   {_country}"; 
    }

    public bool IsInUSA() {
        return _country.Equals("USA");
    }
}