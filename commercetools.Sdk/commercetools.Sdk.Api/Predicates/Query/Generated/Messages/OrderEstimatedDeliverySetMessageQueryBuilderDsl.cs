using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderEstimatedDeliverySetMessageQueryBuilderDsl
    {
        public OrderEstimatedDeliverySetMessageQueryBuilderDsl()
        {
        }

        public static OrderEstimatedDeliverySetMessageQueryBuilderDsl Of()
        {
            return new OrderEstimatedDeliverySetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl>(p, OrderEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl>(p, OrderEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl>(p, OrderEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl>(p, OrderEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderEstimatedDeliverySetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderEstimatedDeliverySetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl>(p, OrderEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderEstimatedDeliverySetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl>(p, OrderEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl>(p, OrderEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderEstimatedDeliverySetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl> EstimatedDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("estimatedDelivery"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl.Of())),
                OrderEstimatedDeliverySetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<OrderEstimatedDeliverySetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<OrderEstimatedDeliverySetMessageQueryBuilderDsl>(p, OrderEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
