using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLMaxCartDiscountsReachedErrorQueryBuilderDsl
    {
        public GraphQLMaxCartDiscountsReachedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLMaxCartDiscountsReachedErrorQueryBuilderDsl Of()
        {
            return new GraphQLMaxCartDiscountsReachedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLMaxCartDiscountsReachedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLMaxCartDiscountsReachedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLMaxCartDiscountsReachedErrorQueryBuilderDsl>(p, GraphQLMaxCartDiscountsReachedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
