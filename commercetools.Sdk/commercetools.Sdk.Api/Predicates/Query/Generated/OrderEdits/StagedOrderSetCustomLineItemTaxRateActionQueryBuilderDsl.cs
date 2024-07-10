using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl
    {
        public StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl>(p, StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl>(p, StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl>(p, StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl> ExternalTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl>(p, StagedOrderSetCustomLineItemTaxRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
