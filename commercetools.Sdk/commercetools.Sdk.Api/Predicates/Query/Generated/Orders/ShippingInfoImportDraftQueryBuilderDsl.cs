using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class ShippingInfoImportDraftQueryBuilderDsl
    {
        public ShippingInfoImportDraftQueryBuilderDsl()
        {
        }

        public static ShippingInfoImportDraftQueryBuilderDsl Of()
        {
            return new ShippingInfoImportDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingInfoImportDraftQueryBuilderDsl, string> ShippingMethodName()
        {
            return new ComparisonPredicateBuilder<ShippingInfoImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingMethodName")),
            p => new CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl>(p, ShippingInfoImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                ShippingInfoImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl> ShippingRate(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl.Of())),
                ShippingInfoImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl> TaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl.Of())),
                ShippingInfoImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl> TaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxCategory"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl.Of())),
                ShippingInfoImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl> ShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingMethod"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl.Of())),
                ShippingInfoImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl> Deliveries(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("deliveries"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryDraftQueryBuilderDsl.Of())),
                ShippingInfoImportDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShippingInfoImportDraftQueryBuilderDsl> Deliveries()
        {
            return new CollectionPredicateBuilder<ShippingInfoImportDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveries")),
                    p => new CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl>(p, ShippingInfoImportDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl> DiscountedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DiscountedLineItemPriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DiscountedLineItemPriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DiscountedLineItemPriceDraftQueryBuilderDsl.Of())),
                ShippingInfoImportDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShippingInfoImportDraftQueryBuilderDsl, string> ShippingMethodState()
        {
            return new ComparisonPredicateBuilder<ShippingInfoImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingMethodState")),
            p => new CombinationQueryPredicate<ShippingInfoImportDraftQueryBuilderDsl>(p, ShippingInfoImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
