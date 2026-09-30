// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLExtensionCircularDependencyErrorQueryBuilderDsl
    {
        public GraphQLExtensionCircularDependencyErrorQueryBuilderDsl()
        {
        }

        public static GraphQLExtensionCircularDependencyErrorQueryBuilderDsl Of()
        {
            return new GraphQLExtensionCircularDependencyErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLExtensionCircularDependencyErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionCircularDependencyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLExtensionCircularDependencyErrorQueryBuilderDsl>(p, GraphQLExtensionCircularDependencyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
