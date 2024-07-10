using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderLineItemDiscountSetMessageQueryBuilderDsl
    {
        public OrderLineItemDiscountSetMessageQueryBuilderDsl()
        {
        }

        public static OrderLineItemDiscountSetMessageQueryBuilderDsl Of()
        {
            return new OrderLineItemDiscountSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderLineItemDiscountSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderLineItemDiscountSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderLineItemDiscountSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderLineItemDiscountSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl> DiscountedPricePerQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountedPricePerQuantity"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl.Of())),
                OrderLineItemDiscountSetMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl> DiscountedPricePerQuantity()
        {
            return new CollectionPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountedPricePerQuantity")),
                    p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderLineItemDiscountSetMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl> TotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                OrderLineItemDiscountSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl> TaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl.Of())),
                OrderLineItemDiscountSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl> TaxedPricePortions(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.MethodTaxedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.MethodTaxedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPricePortions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.MethodTaxedPriceQueryBuilderDsl.Of())),
                OrderLineItemDiscountSetMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl> TaxedPricePortions()
        {
            return new CollectionPredicateBuilder<OrderLineItemDiscountSetMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxedPricePortions")),
                    p => new CombinationQueryPredicate<OrderLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderLineItemDiscountSetMessageQueryBuilderDsl.Of));
        }

    }
}
