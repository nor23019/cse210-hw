using System.Security.Cryptography.X509Certificates;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double productTotal = 0;
        
        foreach (Product product in _products)
        {
            productTotal += product.GetPrice() * product.GetQuantity();
        }

        double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00;
        
        return productTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = $"Order for {_customer.GetString()}\n";
        
        foreach (var product in _products)
        {
            packingLabel += $"- {product.GetProductDetails()}";
        }

        return packingLabel;
    }

        public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetString()}";
    }
}
    