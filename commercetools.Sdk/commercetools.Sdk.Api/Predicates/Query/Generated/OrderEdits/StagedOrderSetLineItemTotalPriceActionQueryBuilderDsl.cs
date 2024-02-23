using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl
    {
        public StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl>(p, StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl>(p, StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl>(p, StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl> ExternalTotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTotalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl.Of())),
                StagedOrderSetLineItemTotalPriceActionQueryBuilderDsl.Of);
        }


    }
}
