using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLBadGatewayErrorQueryBuilderDsl
    {
        public GraphQLBadGatewayErrorQueryBuilderDsl()
        {
        }

        public static GraphQLBadGatewayErrorQueryBuilderDsl Of()
        {
            return new GraphQLBadGatewayErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLBadGatewayErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLBadGatewayErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLBadGatewayErrorQueryBuilderDsl>(p, GraphQLBadGatewayErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
