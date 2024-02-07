// See https://aka.ms/new-console-template for more information

using PatternsDotNet.Specifications;
using PatternsDotNet.Specifications.Products;

var discountSpec = new DiscountTransactionSpecification();

var product = new Product(Guid.NewGuid(), "Pepsi 20oz", 2.50, 5, null);
var isIntStock = new InStockSpecification();
var hasEnoughMoney = new CustomerHasEnoughCashSpecification(product);

var customer = new Customer("Spenser", "Andreassen", 30, 100);

if (isIntStock.IsSatisfiedBy(product) && hasEnoughMoney.IsSatisfiedBy(customer))
{
    customer.Purchase(product);
    Console.WriteLine(
        $"Customer purchased {product.Description} for {product.Price} and has {customer.TotalMoney} left."
    );
}

Console.WriteLine("Hello, World!");
