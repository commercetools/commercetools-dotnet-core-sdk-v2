// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLExtensionDependencyExistsErrorQueryBuilderDsl
    {
        public GraphQLExtensionDependencyExistsErrorQueryBuilderDsl()
        {
        }

        public static GraphQLExtensionDependencyExistsErrorQueryBuilderDsl Of()
        {
            return new GraphQLExtensionDependencyExistsErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLExtensionDependencyExistsErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionDependencyExistsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLExtensionDependencyExistsErrorQueryBuilderDsl>(p, GraphQLExtensionDependencyExistsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
