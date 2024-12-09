class Product
{
    private string _productName;
    private int _id;

    private double _price;
    private int _quantity;

    public string GetProductName()
    {
        return _productName;
    }

    public int GetId()
    {
        return _id;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetProductName(string productName)
    {
        _productName = productName;
    }

    public void SetId(int id)
    {
        _id = id;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public Product(string productName, int id, double price, int quantity)
    {
        _productName = productName;
        _id = id;
        _price = price;
        _quantity = quantity; 
    }
    
    public string GetProductDetails()
    {
        return $"{_productName} (ID: {_id})";
    }

    public string GetTotalCost()
    {
        return $"Total Cost: ${_price * _quantity}";
    }
}