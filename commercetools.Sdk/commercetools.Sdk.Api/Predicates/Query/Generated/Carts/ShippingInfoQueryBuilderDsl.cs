using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ShippingInfoQueryBuilderDsl
    {
        public ShippingInfoQueryBuilderDsl()
        {
        }

        public static ShippingInfoQueryBuilderDsl Of()
        {
            return new ShippingInfoQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingInfoQueryBuilderDsl, string> ShippingMethodName()
        {
            return new ComparisonPredicateBuilder<ShippingInfoQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingMethodName")),
            p => new CombinationQueryPredicate<ShippingInfoQueryBuilderDsl>(p, ShippingInfoQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingInfoQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingInfoQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                ShippingInfoQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingInfoQueryBuilderDsl> ShippingRate(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingInfoQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateQueryBuilderDsl.Of())),
                ShippingInfoQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingInfoQueryBuilderDsl> TaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingInfoQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl.Of())),
                ShippingInfoQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingInfoQueryBuilderDsl> TaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingInfoQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl.Of())),
                ShippingInfoQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingInfoQueryBuilderDsl> TaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingInfoQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxCategory"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl.Of())),
                ShippingInfoQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingInfoQueryBuilderDsl> ShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingInfoQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingMethod"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodReferenceQueryBuilderDsl.Of())),
                ShippingInfoQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingInfoQueryBuilderDsl> Deliveries(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingInfoQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("deliveries"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryQueryBuilderDsl.Of())),
                ShippingInfoQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShippingInfoQueryBuilderDsl> Deliveries()
        {
            return new CollectionPredicateBuilder<ShippingInfoQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveries")),
                    p => new CombinationQueryPredicate<ShippingInfoQueryBuilderDsl>(p, ShippingInfoQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ShippingInfoQueryBuilderDsl> DiscountedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingInfoQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceQueryBuilderDsl.Of())),
                ShippingInfoQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShippingInfoQueryBuilderDsl, string> ShippingMethodState()
        {
            return new ComparisonPredicateBuilder<ShippingInfoQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingMethodState")),
            p => new CombinationQueryPredicate<ShippingInfoQueryBuilderDsl>(p, ShippingInfoQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
