// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class CircularDependencyErrorQueryBuilderDsl
    {
        public CircularDependencyErrorQueryBuilderDsl()
        {
        }

        public static CircularDependencyErrorQueryBuilderDsl Of()
        {
            return new CircularDependencyErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CircularDependencyErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<CircularDependencyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<CircularDependencyErrorQueryBuilderDsl>(p, CircularDependencyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CircularDependencyErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<CircularDependencyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<CircularDependencyErrorQueryBuilderDsl>(p, CircularDependencyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
