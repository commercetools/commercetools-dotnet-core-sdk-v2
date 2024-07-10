using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl
    {
        public StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl>(p, StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl> ShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingMethod"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl> ExternalTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                StagedOrderSetShippingAddressAndShippingMethodActionQueryBuilderDsl.Of);
        }


    }
}
