using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class DiscountTypeCombinationQueryBuilderDsl
    {
        public DiscountTypeCombinationQueryBuilderDsl()
        {
        }

        public static DiscountTypeCombinationQueryBuilderDsl Of()
        {
            return new DiscountTypeCombinationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountTypeCombinationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DiscountTypeCombinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DiscountTypeCombinationQueryBuilderDsl>(p, DiscountTypeCombinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<DiscountTypeCombinationQueryBuilderDsl> AsBestDeal(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.BestDealQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.BestDealQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountTypeCombinationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.BestDealQueryBuilderDsl.Of()),
                DiscountTypeCombinationQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountTypeCombinationQueryBuilderDsl> AsStacking(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.StackingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.StackingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountTypeCombinationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.StackingQueryBuilderDsl.Of()),
                DiscountTypeCombinationQueryBuilderDsl.Of);
        }
    }
}
