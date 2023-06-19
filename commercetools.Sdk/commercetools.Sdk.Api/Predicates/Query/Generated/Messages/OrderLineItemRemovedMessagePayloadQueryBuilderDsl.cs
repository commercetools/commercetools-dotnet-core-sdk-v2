using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderLineItemRemovedMessagePayloadQueryBuilderDsl
    {
        public OrderLineItemRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderLineItemRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderLineItemRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderLineItemRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderLineItemRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderLineItemRemovedMessagePayloadQueryBuilderDsl>(p, OrderLineItemRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemRemovedMessagePayloadQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<OrderLineItemRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<OrderLineItemRemovedMessagePayloadQueryBuilderDsl>(p, OrderLineItemRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemRemovedMessagePayloadQueryBuilderDsl, long> RemovedQuantity()
        {
            return new ComparisonPredicateBuilder<OrderLineItemRemovedMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedQuantity")),
            p => new CombinationQueryPredicate<OrderLineItemRemovedMessagePayloadQueryBuilderDsl>(p, OrderLineItemRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemRemovedMessagePayloadQueryBuilderDsl, long> NewQuantity()
        {
            return new ComparisonPredicateBuilder<OrderLineItemRemovedMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newQuantity")),
            p => new CombinationQueryPredicate<OrderLineItemRemovedMessagePayloadQueryBuilderDsl>(p, OrderLineItemRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderLineItemRemovedMessagePayloadQueryBuilderDsl> NewState(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl.Of())),
                OrderLineItemRemovedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderLineItemRemovedMessagePayloadQueryBuilderDsl> NewState()
        {
            return new CollectionPredicateBuilder<OrderLineItemRemovedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newState")),
                    p => new CombinationQueryPredicate<OrderLineItemRemovedMessagePayloadQueryBuilderDsl>(p, OrderLineItemRemovedMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderLineItemRemovedMessagePayloadQueryBuilderDsl> NewTotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newTotalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                OrderLineItemRemovedMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderLineItemRemovedMessagePayloadQueryBuilderDsl> NewTaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newTaxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl.Of())),
                OrderLineItemRemovedMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderLineItemRemovedMessagePayloadQueryBuilderDsl> NewPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl.Of())),
                OrderLineItemRemovedMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderLineItemRemovedMessagePayloadQueryBuilderDsl> NewShippingDetail(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newShippingDetail"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsQueryBuilderDsl.Of())),
                OrderLineItemRemovedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
