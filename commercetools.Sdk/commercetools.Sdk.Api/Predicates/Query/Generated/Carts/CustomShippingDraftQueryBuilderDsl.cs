using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CustomShippingDraftQueryBuilderDsl
    {
        public CustomShippingDraftQueryBuilderDsl()
        {
        }

        public static CustomShippingDraftQueryBuilderDsl Of()
        {
            return new CustomShippingDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomShippingDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CustomShippingDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl>(p, CustomShippingDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomShippingDraftQueryBuilderDsl, string> ShippingMethodName()
        {
            return new ComparisonPredicateBuilder<CustomShippingDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingMethodName")),
            p => new CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl>(p, CustomShippingDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl> ShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                CustomShippingDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl> ShippingRate(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl.Of())),
                CustomShippingDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl> ShippingRateInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRateInput"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputDraftQueryBuilderDsl.Of())),
                CustomShippingDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl> TaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxCategory"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl.Of())),
                CustomShippingDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl> ExternalTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                CustomShippingDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl> Deliveries(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("deliveries"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryDraftQueryBuilderDsl.Of())),
                CustomShippingDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomShippingDraftQueryBuilderDsl> Deliveries()
        {
            return new CollectionPredicateBuilder<CustomShippingDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveries")),
                    p => new CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl>(p, CustomShippingDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomShippingDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                CustomShippingDraftQueryBuilderDsl.Of);
        }


    }
}
