using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLSearchFacetPathNotFoundErrorQueryBuilderDsl
    {
        public GraphQLSearchFacetPathNotFoundErrorQueryBuilderDsl()
        {
        }

        public static GraphQLSearchFacetPathNotFoundErrorQueryBuilderDsl Of()
        {
            return new GraphQLSearchFacetPathNotFoundErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLSearchFacetPathNotFoundErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLSearchFacetPathNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLSearchFacetPathNotFoundErrorQueryBuilderDsl>(p, GraphQLSearchFacetPathNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
