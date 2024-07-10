using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl
    {
        public StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl>(p, StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl>(p, StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl> ExternalTaxAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxAmountDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxAmountDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxAmount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxAmountDraftQueryBuilderDsl.Of())),
                StagedOrderSetShippingMethodTaxAmountActionQueryBuilderDsl.Of);
        }


    }
}
