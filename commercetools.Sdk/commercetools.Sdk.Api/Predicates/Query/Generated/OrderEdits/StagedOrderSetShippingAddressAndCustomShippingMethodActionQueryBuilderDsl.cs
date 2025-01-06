using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl
    {
        public StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl>(p, StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl, string> ShippingMethodName()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingMethodName")),
            p => new CombinationQueryPredicate<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl>(p, StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl> ShippingRate(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl.Of())),
                StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl> TaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxCategory"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl> ExternalTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                StagedOrderSetShippingAddressAndCustomShippingMethodActionQueryBuilderDsl.Of);
        }


    }
}
