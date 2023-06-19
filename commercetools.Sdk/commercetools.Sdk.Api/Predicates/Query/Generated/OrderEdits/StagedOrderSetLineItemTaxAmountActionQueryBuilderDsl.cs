using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl
    {
        public StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl>(p, StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl>(p, StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl> ExternalTaxAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxAmountDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxAmountDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxAmount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxAmountDraftQueryBuilderDsl.Of())),
                StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl>(p, StagedOrderSetLineItemTaxAmountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
