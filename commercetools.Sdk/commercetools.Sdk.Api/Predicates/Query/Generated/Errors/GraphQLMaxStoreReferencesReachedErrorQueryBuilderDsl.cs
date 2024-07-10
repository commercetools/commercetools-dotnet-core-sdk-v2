// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLMaxStoreReferencesReachedErrorQueryBuilderDsl
    {
        public GraphQLMaxStoreReferencesReachedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLMaxStoreReferencesReachedErrorQueryBuilderDsl Of()
        {
            return new GraphQLMaxStoreReferencesReachedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLMaxStoreReferencesReachedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLMaxStoreReferencesReachedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLMaxStoreReferencesReachedErrorQueryBuilderDsl>(p, GraphQLMaxStoreReferencesReachedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
