// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLExtensionNoResponseErrorQueryBuilderDsl
    {
        public GraphQLExtensionNoResponseErrorQueryBuilderDsl()
        {
        }

        public static GraphQLExtensionNoResponseErrorQueryBuilderDsl Of()
        {
            return new GraphQLExtensionNoResponseErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLExtensionNoResponseErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionNoResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLExtensionNoResponseErrorQueryBuilderDsl>(p, GraphQLExtensionNoResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLExtensionNoResponseErrorQueryBuilderDsl, string> ExtensionId()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionNoResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionId")),
            p => new CombinationQueryPredicate<GraphQLExtensionNoResponseErrorQueryBuilderDsl>(p, GraphQLExtensionNoResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLExtensionNoResponseErrorQueryBuilderDsl, string> ExtensionKey()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionNoResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionKey")),
            p => new CombinationQueryPredicate<GraphQLExtensionNoResponseErrorQueryBuilderDsl>(p, GraphQLExtensionNoResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
