using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetLineItemPriceActionQueryBuilderDsl
    {
        public StagedOrderSetLineItemPriceActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetLineItemPriceActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetLineItemPriceActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetLineItemPriceActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLineItemPriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetLineItemPriceActionQueryBuilderDsl>(p, StagedOrderSetLineItemPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetLineItemPriceActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLineItemPriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<StagedOrderSetLineItemPriceActionQueryBuilderDsl>(p, StagedOrderSetLineItemPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetLineItemPriceActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLineItemPriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<StagedOrderSetLineItemPriceActionQueryBuilderDsl>(p, StagedOrderSetLineItemPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetLineItemPriceActionQueryBuilderDsl> ExternalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetLineItemPriceActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                StagedOrderSetLineItemPriceActionQueryBuilderDsl.Of);
        }


    }
}
