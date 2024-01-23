using PatternsDotNet.Specifications.Abstractions;

namespace PatternsDotNet.Specifications;

public record NotSpecification<T>(ISpecification<T> Other) : CompositeSpecification<T>
{
    public override bool IsSatisfiedBy(T candidate) => !Other.IsSatisfiedBy(candidate);
}