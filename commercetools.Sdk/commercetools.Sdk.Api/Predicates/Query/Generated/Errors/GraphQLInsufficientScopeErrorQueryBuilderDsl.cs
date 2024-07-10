using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLInsufficientScopeErrorQueryBuilderDsl
    {
        public GraphQLInsufficientScopeErrorQueryBuilderDsl()
        {
        }

        public static GraphQLInsufficientScopeErrorQueryBuilderDsl Of()
        {
            return new GraphQLInsufficientScopeErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLInsufficientScopeErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLInsufficientScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLInsufficientScopeErrorQueryBuilderDsl>(p, GraphQLInsufficientScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
