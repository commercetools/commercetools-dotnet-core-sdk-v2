using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetDirectDiscountsActionQueryBuilderDsl
    {
        public StagedOrderSetDirectDiscountsActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetDirectDiscountsActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetDirectDiscountsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetDirectDiscountsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetDirectDiscountsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetDirectDiscountsActionQueryBuilderDsl>(p, StagedOrderSetDirectDiscountsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetDirectDiscountsActionQueryBuilderDsl> Discounts(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetDirectDiscountsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discounts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountDraftQueryBuilderDsl.Of())),
                StagedOrderSetDirectDiscountsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderSetDirectDiscountsActionQueryBuilderDsl> Discounts()
        {
            return new CollectionPredicateBuilder<StagedOrderSetDirectDiscountsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discounts")),
                    p => new CombinationQueryPredicate<StagedOrderSetDirectDiscountsActionQueryBuilderDsl>(p, StagedOrderSetDirectDiscountsActionQueryBuilderDsl.Of));
        }

    }
}
