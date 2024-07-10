using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLQueryTimedOutErrorQueryBuilderDsl
    {
        public GraphQLQueryTimedOutErrorQueryBuilderDsl()
        {
        }

        public static GraphQLQueryTimedOutErrorQueryBuilderDsl Of()
        {
            return new GraphQLQueryTimedOutErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLQueryTimedOutErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLQueryTimedOutErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLQueryTimedOutErrorQueryBuilderDsl>(p, GraphQLQueryTimedOutErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
