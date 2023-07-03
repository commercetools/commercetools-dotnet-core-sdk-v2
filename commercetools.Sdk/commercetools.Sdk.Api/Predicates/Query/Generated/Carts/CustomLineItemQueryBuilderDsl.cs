using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CustomLineItemQueryBuilderDsl
    {
        public CustomLineItemQueryBuilderDsl()
        {
        }

        public static CustomLineItemQueryBuilderDsl Of()
        {
            return new CustomLineItemQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomLineItemQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomLineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(p, CustomLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CustomLineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(p, CustomLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomLineItemQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CustomLineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomLineItemQueryBuilderDsl> Money(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("money"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of())),
                CustomLineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomLineItemQueryBuilderDsl> TaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl.Of())),
                CustomLineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomLineItemQueryBuilderDsl> TotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                CustomLineItemQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomLineItemQueryBuilderDsl, string> Slug()
        {
            return new ComparisonPredicateBuilder<CustomLineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("slug")),
            p => new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(p, CustomLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<CustomLineItemQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(p, CustomLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomLineItemQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl.Of())),
                CustomLineItemQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomLineItemQueryBuilderDsl> State()
        {
            return new CollectionPredicateBuilder<CustomLineItemQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
                    p => new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(p, CustomLineItemQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CustomLineItemQueryBuilderDsl> TaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxCategory"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl.Of())),
                CustomLineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomLineItemQueryBuilderDsl> TaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl.Of())),
                CustomLineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomLineItemQueryBuilderDsl> PerMethodTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.MethodTaxRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.MethodTaxRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("perMethodTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.MethodTaxRateQueryBuilderDsl.Of())),
                CustomLineItemQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomLineItemQueryBuilderDsl> PerMethodTaxRate()
        {
            return new CollectionPredicateBuilder<CustomLineItemQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("perMethodTaxRate")),
                    p => new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(p, CustomLineItemQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CustomLineItemQueryBuilderDsl> DiscountedPricePerQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountedPricePerQuantity"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl.Of())),
                CustomLineItemQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomLineItemQueryBuilderDsl> DiscountedPricePerQuantity()
        {
            return new CollectionPredicateBuilder<CustomLineItemQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountedPricePerQuantity")),
                    p => new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(p, CustomLineItemQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CustomLineItemQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                CustomLineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomLineItemQueryBuilderDsl> ShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingDetails"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsQueryBuilderDsl.Of())),
                CustomLineItemQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomLineItemQueryBuilderDsl, string> PriceMode()
        {
            return new ComparisonPredicateBuilder<CustomLineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceMode")),
            p => new CombinationQueryPredicate<CustomLineItemQueryBuilderDsl>(p, CustomLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
