namespace PatternsDotNet.Specifications.Products;

public record Transaction(
    TransactionType Type,
    TransactionPaymentMethod PaymentMethod,
    Product Product,
    TransactionModifier Modifier = TransactionModifier.None
);

public enum TransactionPaymentMethod
{
    Cash,
    Credit
}

public enum TransactionModifier
{
    None,
    Coupon
}

public enum TransactionType
{
    Sale,
    Discount,
    Refund
}
