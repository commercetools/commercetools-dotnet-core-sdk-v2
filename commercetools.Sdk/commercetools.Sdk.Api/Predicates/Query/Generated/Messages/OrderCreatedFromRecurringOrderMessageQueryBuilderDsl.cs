using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCreatedFromRecurringOrderMessageQueryBuilderDsl
    {
        public OrderCreatedFromRecurringOrderMessageQueryBuilderDsl()
        {
        }

        public static OrderCreatedFromRecurringOrderMessageQueryBuilderDsl Of()
        {
            return new OrderCreatedFromRecurringOrderMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl>(p, OrderCreatedFromRecurringOrderMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl>(p, OrderCreatedFromRecurringOrderMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl>(p, OrderCreatedFromRecurringOrderMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl>(p, OrderCreatedFromRecurringOrderMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderCreatedFromRecurringOrderMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderCreatedFromRecurringOrderMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl>(p, OrderCreatedFromRecurringOrderMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderCreatedFromRecurringOrderMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl>(p, OrderCreatedFromRecurringOrderMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl>(p, OrderCreatedFromRecurringOrderMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderCreatedFromRecurringOrderMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl> Order(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("order"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl.Of())),
                OrderCreatedFromRecurringOrderMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl> RecurringOrderRef(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurringOrderRef"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderReferenceQueryBuilderDsl.Of())),
                OrderCreatedFromRecurringOrderMessageQueryBuilderDsl.Of);
        }


    }
}
