// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLCircularDependencyErrorQueryBuilderDsl
    {
        public GraphQLCircularDependencyErrorQueryBuilderDsl()
        {
        }

        public static GraphQLCircularDependencyErrorQueryBuilderDsl Of()
        {
            return new GraphQLCircularDependencyErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLCircularDependencyErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLCircularDependencyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLCircularDependencyErrorQueryBuilderDsl>(p, GraphQLCircularDependencyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
