using PatternsDotNet.Specifications.Specs.Abstractions;

namespace PatternsDotNet.Specifications.Specs;

public record NotSpecification<T>(ISpecification<T> Other) : CompositeSpecification<T>
{
    public override bool IsSatisfiedBy(T candidate) => !Other.IsSatisfiedBy(candidate);
}
