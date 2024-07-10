using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLExternalOAuthFailedErrorQueryBuilderDsl
    {
        public GraphQLExternalOAuthFailedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLExternalOAuthFailedErrorQueryBuilderDsl Of()
        {
            return new GraphQLExternalOAuthFailedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLExternalOAuthFailedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLExternalOAuthFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLExternalOAuthFailedErrorQueryBuilderDsl>(p, GraphQLExternalOAuthFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
