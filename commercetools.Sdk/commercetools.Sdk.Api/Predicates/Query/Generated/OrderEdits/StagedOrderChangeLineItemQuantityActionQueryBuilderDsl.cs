using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderChangeLineItemQuantityActionQueryBuilderDsl
    {
        public StagedOrderChangeLineItemQuantityActionQueryBuilderDsl()
        {
        }

        public static StagedOrderChangeLineItemQuantityActionQueryBuilderDsl Of()
        {
            return new StagedOrderChangeLineItemQuantityActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderChangeLineItemQuantityActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderChangeLineItemQuantityActionQueryBuilderDsl>(p, StagedOrderChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderChangeLineItemQuantityActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<StagedOrderChangeLineItemQuantityActionQueryBuilderDsl>(p, StagedOrderChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderChangeLineItemQuantityActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeLineItemQuantityActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<StagedOrderChangeLineItemQuantityActionQueryBuilderDsl>(p, StagedOrderChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderChangeLineItemQuantityActionQueryBuilderDsl> ExternalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderChangeLineItemQuantityActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                StagedOrderChangeLineItemQuantityActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderChangeLineItemQuantityActionQueryBuilderDsl> ExternalTotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderChangeLineItemQuantityActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTotalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl.Of())),
                StagedOrderChangeLineItemQuantityActionQueryBuilderDsl.Of);
        }


    }
}
