using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderLineItemRemovedMessageQueryBuilderDsl
    {
        public OrderLineItemRemovedMessageQueryBuilderDsl()
        {
        }

        public static OrderLineItemRemovedMessageQueryBuilderDsl Of()
        {
            return new OrderLineItemRemovedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(p, OrderLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(p, OrderLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(p, OrderLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(p, OrderLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderLineItemRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderLineItemRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(p, OrderLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderLineItemRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(p, OrderLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(p, OrderLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderLineItemRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(p, OrderLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(p, OrderLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, long> RemovedQuantity()
        {
            return new ComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedQuantity")),
            p => new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(p, OrderLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, long> NewQuantity()
        {
            return new ComparisonPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newQuantity")),
            p => new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(p, OrderLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl> NewState(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl.Of())),
                OrderLineItemRemovedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl> NewState()
        {
            return new CollectionPredicateBuilder<OrderLineItemRemovedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newState")),
                    p => new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(p, OrderLineItemRemovedMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl> NewTotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newTotalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                OrderLineItemRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl> NewTaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newTaxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl.Of())),
                OrderLineItemRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl> NewPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl.Of())),
                OrderLineItemRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl> NewShippingDetail(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newShippingDetail"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ItemShippingDetailsQueryBuilderDsl.Of())),
                OrderLineItemRemovedMessageQueryBuilderDsl.Of);
        }


    }
}
