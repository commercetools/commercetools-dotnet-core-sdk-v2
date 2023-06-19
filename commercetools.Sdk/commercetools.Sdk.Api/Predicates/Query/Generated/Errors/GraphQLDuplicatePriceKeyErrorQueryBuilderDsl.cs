using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLDuplicatePriceKeyErrorQueryBuilderDsl
    {
        public GraphQLDuplicatePriceKeyErrorQueryBuilderDsl()
        {
        }

        public static GraphQLDuplicatePriceKeyErrorQueryBuilderDsl Of()
        {
            return new GraphQLDuplicatePriceKeyErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLDuplicatePriceKeyErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLDuplicatePriceKeyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLDuplicatePriceKeyErrorQueryBuilderDsl>(p, GraphQLDuplicatePriceKeyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLDuplicatePriceKeyErrorQueryBuilderDsl> ConflictingPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLDuplicatePriceKeyErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("conflictingPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl.Of())),
                GraphQLDuplicatePriceKeyErrorQueryBuilderDsl.Of);
        }


    }
}
