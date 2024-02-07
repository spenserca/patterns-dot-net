namespace PatternsDotNet.Specifications.Products;

public record Customer(string FirstName, string LastName, int Age, double TotalMoney)
{
    public double TotalMoney { get; private set; }

    public void Purchase(Product product)
    {
        TotalMoney -= product.Price;
    }
};
