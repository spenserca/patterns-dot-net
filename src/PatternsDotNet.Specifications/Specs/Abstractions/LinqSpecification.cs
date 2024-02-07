using System.Linq.Expressions;

namespace PatternsDotNet.Specifications.Specs.Abstractions;

public abstract record LinqSpecification<T> : CompositeSpecification<T>
{
    public abstract Expression<Func<T, bool>> AsExpression();

    public override bool IsSatisfiedBy(T candidate) => AsExpression().Compile()(candidate);
}
