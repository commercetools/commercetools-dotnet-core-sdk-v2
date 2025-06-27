using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Quotes
{

    public partial class QuoteQueryBuilderDsl
    {
        public QuoteQueryBuilderDsl()
        {
        }

        public static QuoteQueryBuilderDsl Of()
        {
            return new QuoteQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteQueryBuilderDsl> QuoteRequest(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("quoteRequest"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestReferenceQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteQueryBuilderDsl> StagedQuote(
            Func<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stagedQuote"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteReferenceQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, DateTime> ValidTo()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validTo")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, string> SellerComment()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sellerComment")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, string> BuyerComment()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("buyerComment")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteQueryBuilderDsl> LineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<QuoteQueryBuilderDsl> LineItems()
        {
            return new CollectionPredicateBuilder<QuoteQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItems")),
                    p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<QuoteQueryBuilderDsl> CustomLineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customLineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<QuoteQueryBuilderDsl> CustomLineItems()
        {
            return new CollectionPredicateBuilder<QuoteQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItems")),
                    p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<QuoteQueryBuilderDsl> TotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteQueryBuilderDsl> TaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteQueryBuilderDsl> ShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteQueryBuilderDsl> BillingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("billingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, string> InventoryMode()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inventoryMode")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, string> TaxMode()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxMode")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, string> PriceRoundingMode()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceRoundingMode")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, string> TaxRoundingMode()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxRoundingMode")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, string> TaxCalculationMode()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxCalculationMode")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteQueryBuilderDsl> ShippingInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteQueryBuilderDsl> PaymentInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.PaymentInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.PaymentInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.PaymentInfoQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteQueryBuilderDsl> ShippingRateInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRateInput"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteQueryBuilderDsl> ItemShippingAddresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("itemShippingAddresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<QuoteQueryBuilderDsl> ItemShippingAddresses()
        {
            return new CollectionPredicateBuilder<QuoteQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("itemShippingAddresses")),
                    p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<QuoteQueryBuilderDsl> DirectDiscounts(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("directDiscounts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DirectDiscountQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<QuoteQueryBuilderDsl> DirectDiscounts()
        {
            return new CollectionPredicateBuilder<QuoteQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("directDiscounts")),
                    p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<QuoteQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, string> QuoteState()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quoteState")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteQueryBuilderDsl, string> PurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<QuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("purchaseOrderNumber")),
            p => new CombinationQueryPredicate<QuoteQueryBuilderDsl>(p, QuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                QuoteQueryBuilderDsl.Of);
        }


    }
}
