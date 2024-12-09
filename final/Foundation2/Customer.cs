class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetString()
    {
        return $"Name: {_name}\nAddress: {_address.GetString()}";
    }

    public bool LivesInUSA()
    {
        return _address.AddressInUSA();
    }
}