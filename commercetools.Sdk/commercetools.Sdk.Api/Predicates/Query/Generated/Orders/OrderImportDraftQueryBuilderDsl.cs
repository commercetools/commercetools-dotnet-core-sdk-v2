using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderImportDraftQueryBuilderDsl
    {
        public OrderImportDraftQueryBuilderDsl()
        {
        }

        public static OrderImportDraftQueryBuilderDsl Of()
        {
            return new OrderImportDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string> OrderNumber()
        {
            return new ComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderNumber")),
            p => new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(p, OrderImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string> CustomerId()
        {
            return new ComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerId")),
            p => new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(p, OrderImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string> CustomerEmail()
        {
            return new ComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerEmail")),
            p => new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(p, OrderImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl> LineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.LineItemImportDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.LineItemImportDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.LineItemImportDraftQueryBuilderDsl.Of())),
                OrderImportDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderImportDraftQueryBuilderDsl> LineItems()
        {
            return new CollectionPredicateBuilder<OrderImportDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItems")),
                    p => new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(p, OrderImportDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl> CustomLineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemImportDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemImportDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customLineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemImportDraftQueryBuilderDsl.Of())),
                OrderImportDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderImportDraftQueryBuilderDsl> CustomLineItems()
        {
            return new CollectionPredicateBuilder<OrderImportDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItems")),
                    p => new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(p, OrderImportDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl> TotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                OrderImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl> TaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedPriceDraftQueryBuilderDsl.Of())),
                OrderImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl> ShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                OrderImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl> BillingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("billingAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                OrderImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                OrderImportDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(p, OrderImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string> OrderState()
        {
            return new ComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderState")),
            p => new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(p, OrderImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                OrderImportDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string> ShipmentState()
        {
            return new ComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipmentState")),
            p => new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(p, OrderImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string> PaymentState()
        {
            return new ComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentState")),
            p => new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(p, OrderImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl> ShippingInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ShippingInfoImportDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ShippingInfoImportDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ShippingInfoImportDraftQueryBuilderDsl.Of())),
                OrderImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl> PaymentInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.PaymentInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.PaymentInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.PaymentInfoQueryBuilderDsl.Of())),
                OrderImportDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, DateTime> CompletedAt()
        {
            return new ComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("completedAt")),
            p => new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(p, OrderImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                OrderImportDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string> InventoryMode()
        {
            return new ComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inventoryMode")),
            p => new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(p, OrderImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string> TaxRoundingMode()
        {
            return new ComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxRoundingMode")),
            p => new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(p, OrderImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl> ItemShippingAddresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("itemShippingAddresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                OrderImportDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderImportDraftQueryBuilderDsl> ItemShippingAddresses()
        {
            return new CollectionPredicateBuilder<OrderImportDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("itemShippingAddresses")),
                    p => new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(p, OrderImportDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl.Of())),
                OrderImportDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                OrderImportDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string> Origin()
        {
            return new ComparisonPredicateBuilder<OrderImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("origin")),
            p => new CombinationQueryPredicate<OrderImportDraftQueryBuilderDsl>(p, OrderImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
