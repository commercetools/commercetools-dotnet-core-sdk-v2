using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl
    {
        public GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl()
        {
        }

        public static GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl Of()
        {
            return new GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl>(p, GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl, string> Subject()
        {
            return new ComparisonPredicateBuilder<GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("subject")),
            p => new CombinationQueryPredicate<GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl>(p, GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl, string> ItemId()
        {
            return new ComparisonPredicateBuilder<GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("itemId")),
            p => new CombinationQueryPredicate<GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl>(p, GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
