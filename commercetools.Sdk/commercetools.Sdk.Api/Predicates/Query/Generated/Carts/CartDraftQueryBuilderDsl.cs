using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartDraftQueryBuilderDsl
    {
        public CartDraftQueryBuilderDsl()
        {
        }

        public static CartDraftQueryBuilderDsl Of()
        {
            return new CartDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string> Currency()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currency")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string> CustomerId()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerId")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string> CustomerEmail()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerEmail")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDraftQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                CartDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDraftQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl.Of())),
                CartDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartDraftQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CartDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartDraftQueryBuilderDsl> LineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.LineItemDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.LineItemDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.LineItemDraftQueryBuilderDsl.Of())),
                CartDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDraftQueryBuilderDsl> LineItems()
        {
            return new CollectionPredicateBuilder<CartDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItems")),
                    p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CartDraftQueryBuilderDsl> CustomLineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customLineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemDraftQueryBuilderDsl.Of())),
                CartDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDraftQueryBuilderDsl> CustomLineItems()
        {
            return new CollectionPredicateBuilder<CartDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItems")),
                    p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string> TaxMode()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxMode")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDraftQueryBuilderDsl> ExternalTaxRateForShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxRateForShippingMethod"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                CartDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string> PriceRoundingMode()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceRoundingMode")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string> TaxRoundingMode()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxRoundingMode")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string> TaxCalculationMode()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxCalculationMode")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string> InventoryMode()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inventoryMode")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDraftQueryBuilderDsl> BillingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("billingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                CartDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartDraftQueryBuilderDsl> ShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                CartDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartDraftQueryBuilderDsl> ShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingMethod"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl.Of())),
                CartDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartDraftQueryBuilderDsl> ShippingRateInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRateInput"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputDraftQueryBuilderDsl.Of())),
                CartDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string> ShippingMode()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingMode")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDraftQueryBuilderDsl> CustomShipping(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CustomShippingDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CustomShippingDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customShipping"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CustomShippingDraftQueryBuilderDsl.Of())),
                CartDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDraftQueryBuilderDsl> CustomShipping()
        {
            return new CollectionPredicateBuilder<CartDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customShipping")),
                    p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CartDraftQueryBuilderDsl> Shipping(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shipping"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingDraftQueryBuilderDsl.Of())),
                CartDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDraftQueryBuilderDsl> Shipping()
        {
            return new CollectionPredicateBuilder<CartDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipping")),
                    p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CartDraftQueryBuilderDsl> ItemShippingAddresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("itemShippingAddresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                CartDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CartDraftQueryBuilderDsl> ItemShippingAddresses()
        {
            return new CollectionPredicateBuilder<CartDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("itemShippingAddresses")),
                    p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of));
        }
        public IComparableCollectionPredicateBuilder<CartDraftQueryBuilderDsl, string> DiscountCodes()
        {
            return new ComparableCollectionPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountCodes")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string> Origin()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("origin")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, long> DeleteDaysAfterLastModification()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deleteDaysAfterLastModification")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                CartDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string> PurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<CartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("purchaseOrderNumber")),
            p => new CombinationQueryPredicate<CartDraftQueryBuilderDsl>(p, CartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
