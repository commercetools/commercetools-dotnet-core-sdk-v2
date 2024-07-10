using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLResourceSizeLimitExceededErrorQueryBuilderDsl
    {
        public GraphQLResourceSizeLimitExceededErrorQueryBuilderDsl()
        {
        }

        public static GraphQLResourceSizeLimitExceededErrorQueryBuilderDsl Of()
        {
            return new GraphQLResourceSizeLimitExceededErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLResourceSizeLimitExceededErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLResourceSizeLimitExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLResourceSizeLimitExceededErrorQueryBuilderDsl>(p, GraphQLResourceSizeLimitExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
