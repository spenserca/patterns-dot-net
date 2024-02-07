namespace PatternsDotNet.Specifications.Products;

public record Product(
    Guid Id,
    string Description,
    double Price,
    int CurrentStock,
    AgeRestriction? AgeRestriction
);
