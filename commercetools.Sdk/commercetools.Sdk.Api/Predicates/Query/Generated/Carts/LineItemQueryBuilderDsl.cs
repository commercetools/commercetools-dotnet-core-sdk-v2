using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class LineItemQueryBuilderDsl
    {
        public LineItemQueryBuilderDsl()
        {
        }

        public static LineItemQueryBuilderDsl Of()
        {
            return new LineItemQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<LineItemQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<LineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<LineItemQueryBuilderDsl>(p, LineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<LineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<LineItemQueryBuilderDsl>(p, LineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemQueryBuilderDsl, string> ProductId()
        {
            return new ComparisonPredicateBuilder<LineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productId")),
            p => new CombinationQueryPredicate<LineItemQueryBuilderDsl>(p, LineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemQueryBuilderDsl, string> ProductKey()
        {
            return new ComparisonPredicateBuilder<LineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productKey")),
            p => new CombinationQueryPredicate<LineItemQueryBuilderDsl>(p, LineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<LineItemQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemQueryBuilderDsl> ProductSlug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productSlug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemQueryBuilderDsl> ProductType(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productType"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemQueryBuilderDsl> Variant(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variant"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<LineItemQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<LineItemQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<LineItemQueryBuilderDsl>(p, LineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<LineItemQueryBuilderDsl> TotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemQueryBuilderDsl> DiscountedPricePerQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountedPricePerQuantity"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<LineItemQueryBuilderDsl> DiscountedPricePerQuantity()
        {
            return new CollectionPredicateBuilder<LineItemQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountedPricePerQuantity")),
                    p => new CombinationQueryPredicate<LineItemQueryBuilderDsl>(p, LineItemQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<LineItemQueryBuilderDsl> TaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemQueryBuilderDsl> TaxedPricePortions(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.MethodTaxedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.MethodTaxedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPricePortions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.MethodTaxedPriceQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<LineItemQueryBuilderDsl> TaxedPricePortions()
        {
            return new CollectionPredicateBuilder<LineItemQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxedPricePortions")),
                    p => new CombinationQueryPredicate<LineItemQueryBuilderDsl>(p, LineItemQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<LineItemQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<LineItemQueryBuilderDsl> State()
        {
            return new CollectionPredicateBuilder<LineItemQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
                    p => new CombinationQueryPredicate<LineItemQueryBuilderDsl>(p, LineItemQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<LineItemQueryBuilderDsl> TaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemQueryBuilderDsl> PerMethodTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.MethodTaxRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.MethodTaxRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("perMethodTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.MethodTaxRateQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<LineItemQueryBuilderDsl> PerMethodTaxRate()
        {
            return new CollectionPredicateBuilder<LineItemQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("perMethodTaxRate")),
                    p => new CombinationQueryPredicate<LineItemQueryBuilderDsl>(p, LineItemQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<LineItemQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemQueryBuilderDsl> DistributionChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<LineItemQueryBuilderDsl, string> PriceMode()
        {
            return new ComparisonPredicateBuilder<LineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceMode")),
            p => new CombinationQueryPredicate<LineItemQueryBuilderDsl>(p, LineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemQueryBuilderDsl, string> LineItemMode()
        {
            return new ComparisonPredicateBuilder<LineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemMode")),
            p => new CombinationQueryPredicate<LineItemQueryBuilderDsl>(p, LineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemQueryBuilderDsl, string> InventoryMode()
        {
            return new ComparisonPredicateBuilder<LineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inventoryMode")),
            p => new CombinationQueryPredicate<LineItemQueryBuilderDsl>(p, LineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<LineItemQueryBuilderDsl> ShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingDetails"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<LineItemQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                LineItemQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<LineItemQueryBuilderDsl, DateTime> AddedAt()
        {
            return new ComparisonPredicateBuilder<LineItemQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedAt")),
            p => new CombinationQueryPredicate<LineItemQueryBuilderDsl>(p, LineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<LineItemQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<LineItemQueryBuilderDsl>(p, LineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
