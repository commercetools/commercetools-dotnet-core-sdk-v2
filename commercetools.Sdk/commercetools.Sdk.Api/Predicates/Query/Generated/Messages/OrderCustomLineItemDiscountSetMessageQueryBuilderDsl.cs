using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCustomLineItemDiscountSetMessageQueryBuilderDsl
    {
        public OrderCustomLineItemDiscountSetMessageQueryBuilderDsl()
        {
        }

        public static OrderCustomLineItemDiscountSetMessageQueryBuilderDsl Of()
        {
            return new OrderCustomLineItemDiscountSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, string> CustomLineItemKey()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemKey")),
            p => new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl> DiscountedPricePerQuantity(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountedPricePerQuantity"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPriceForQuantityQueryBuilderDsl.Of())),
                OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl> DiscountedPricePerQuantity()
        {
            return new CollectionPredicateBuilder<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountedPricePerQuantity")),
                    p => new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(p, OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl> TaxedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomLineItemDiscountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxedItemPriceQueryBuilderDsl.Of())),
                OrderCustomLineItemDiscountSetMessageQueryBuilderDsl.Of);
        }


    }
}
