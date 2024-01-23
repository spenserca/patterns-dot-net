using PatternsDotNet.Specifications.Abstractions;

namespace PatternsDotNet.Specifications;

public record OrNotSpecification<T>(ISpecification<T> Left, ISpecification<T> Right) : CompositeSpecification<T>
{
    public override bool IsSatisfiedBy(T candidate) => Left.IsSatisfiedBy(candidate) || !Right.IsSatisfiedBy(candidate);
}