// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLPriceChangedErrorQueryBuilderDsl
    {
        public GraphQLPriceChangedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLPriceChangedErrorQueryBuilderDsl Of()
        {
            return new GraphQLPriceChangedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLPriceChangedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLPriceChangedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLPriceChangedErrorQueryBuilderDsl>(p, GraphQLPriceChangedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<GraphQLPriceChangedErrorQueryBuilderDsl, string> LineItems()
        {
            return new ComparableCollectionPredicateBuilder<GraphQLPriceChangedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItems")),
            p => new CombinationQueryPredicate<GraphQLPriceChangedErrorQueryBuilderDsl>(p, GraphQLPriceChangedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLPriceChangedErrorQueryBuilderDsl, bool> Shipping()
        {
            return new ComparisonPredicateBuilder<GraphQLPriceChangedErrorQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipping")),
            p => new CombinationQueryPredicate<GraphQLPriceChangedErrorQueryBuilderDsl>(p, GraphQLPriceChangedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
