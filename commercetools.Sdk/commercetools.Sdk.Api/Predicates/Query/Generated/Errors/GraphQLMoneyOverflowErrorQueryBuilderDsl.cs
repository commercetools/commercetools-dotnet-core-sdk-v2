using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLMoneyOverflowErrorQueryBuilderDsl
    {
        public GraphQLMoneyOverflowErrorQueryBuilderDsl()
        {
        }

        public static GraphQLMoneyOverflowErrorQueryBuilderDsl Of()
        {
            return new GraphQLMoneyOverflowErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLMoneyOverflowErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLMoneyOverflowErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLMoneyOverflowErrorQueryBuilderDsl>(p, GraphQLMoneyOverflowErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
