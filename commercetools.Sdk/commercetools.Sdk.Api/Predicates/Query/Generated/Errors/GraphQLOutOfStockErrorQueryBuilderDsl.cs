using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLOutOfStockErrorQueryBuilderDsl
    {
        public GraphQLOutOfStockErrorQueryBuilderDsl()
        {
        }

        public static GraphQLOutOfStockErrorQueryBuilderDsl Of()
        {
            return new GraphQLOutOfStockErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLOutOfStockErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLOutOfStockErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLOutOfStockErrorQueryBuilderDsl>(p, GraphQLOutOfStockErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<GraphQLOutOfStockErrorQueryBuilderDsl, string> LineItems()
        {
            return new ComparableCollectionPredicateBuilder<GraphQLOutOfStockErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItems")),
            p => new CombinationQueryPredicate<GraphQLOutOfStockErrorQueryBuilderDsl>(p, GraphQLOutOfStockErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<GraphQLOutOfStockErrorQueryBuilderDsl, string> Skus()
        {
            return new ComparableCollectionPredicateBuilder<GraphQLOutOfStockErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("skus")),
            p => new CombinationQueryPredicate<GraphQLOutOfStockErrorQueryBuilderDsl>(p, GraphQLOutOfStockErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
