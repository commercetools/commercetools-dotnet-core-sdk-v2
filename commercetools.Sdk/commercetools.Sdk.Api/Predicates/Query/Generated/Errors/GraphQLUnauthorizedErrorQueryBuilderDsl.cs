// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLUnauthorizedErrorQueryBuilderDsl
    {
        public GraphQLUnauthorizedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLUnauthorizedErrorQueryBuilderDsl Of()
        {
            return new GraphQLUnauthorizedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLUnauthorizedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLUnauthorizedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLUnauthorizedErrorQueryBuilderDsl>(p, GraphQLUnauthorizedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<GraphQLUnauthorizedErrorQueryBuilderDsl, string> StoresWithoutPermission()
        {
            return new ComparableCollectionPredicateBuilder<GraphQLUnauthorizedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("storesWithoutPermission")),
            p => new CombinationQueryPredicate<GraphQLUnauthorizedErrorQueryBuilderDsl>(p, GraphQLUnauthorizedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
