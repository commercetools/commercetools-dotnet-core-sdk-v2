using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLDuplicatePriceScopeErrorQueryBuilderDsl
    {
        public GraphQLDuplicatePriceScopeErrorQueryBuilderDsl()
        {
        }

        public static GraphQLDuplicatePriceScopeErrorQueryBuilderDsl Of()
        {
            return new GraphQLDuplicatePriceScopeErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLDuplicatePriceScopeErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicatePriceScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLDuplicatePriceScopeErrorQueryBuilderDsl>(p, GraphQLDuplicatePriceScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLDuplicatePriceScopeErrorQueryBuilderDsl> ConflictingPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLDuplicatePriceScopeErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("conflictingPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl.Of())),
                GraphQLDuplicatePriceScopeErrorQueryBuilderDsl.Of);
        }


    }
}
