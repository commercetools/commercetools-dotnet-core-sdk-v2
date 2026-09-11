// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class MissingDependencyErrorQueryBuilderDsl
    {
        public MissingDependencyErrorQueryBuilderDsl()
        {
        }

        public static MissingDependencyErrorQueryBuilderDsl Of()
        {
            return new MissingDependencyErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MissingDependencyErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<MissingDependencyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<MissingDependencyErrorQueryBuilderDsl>(p, MissingDependencyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MissingDependencyErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<MissingDependencyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<MissingDependencyErrorQueryBuilderDsl>(p, MissingDependencyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
