// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLMissingDependencyErrorQueryBuilderDsl
    {
        public GraphQLMissingDependencyErrorQueryBuilderDsl()
        {
        }

        public static GraphQLMissingDependencyErrorQueryBuilderDsl Of()
        {
            return new GraphQLMissingDependencyErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLMissingDependencyErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLMissingDependencyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLMissingDependencyErrorQueryBuilderDsl>(p, GraphQLMissingDependencyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
