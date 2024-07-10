using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetShippingRateInputActionQueryBuilderDsl
    {
        public StagedOrderSetShippingRateInputActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetShippingRateInputActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetShippingRateInputActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetShippingRateInputActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetShippingRateInputActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetShippingRateInputActionQueryBuilderDsl>(p, StagedOrderSetShippingRateInputActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetShippingRateInputActionQueryBuilderDsl> ShippingRateInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetShippingRateInputActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRateInput"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputDraftQueryBuilderDsl.Of())),
                StagedOrderSetShippingRateInputActionQueryBuilderDsl.Of);
        }


    }
}
