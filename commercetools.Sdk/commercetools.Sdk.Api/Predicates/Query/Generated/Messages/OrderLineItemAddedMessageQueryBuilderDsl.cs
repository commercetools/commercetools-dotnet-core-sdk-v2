using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderLineItemAddedMessageQueryBuilderDsl
    {
        public OrderLineItemAddedMessageQueryBuilderDsl()
        {
        }

        public static OrderLineItemAddedMessageQueryBuilderDsl Of()
        {
            return new OrderLineItemAddedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl>(p, OrderLineItemAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl>(p, OrderLineItemAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl>(p, OrderLineItemAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl>(p, OrderLineItemAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderLineItemAddedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderLineItemAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl>(p, OrderLineItemAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderLineItemAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl>(p, OrderLineItemAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl>(p, OrderLineItemAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderLineItemAddedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl> LineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lineItem"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.LineItemQueryBuilderDsl.Of())),
                OrderLineItemAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, long> AddedQuantity()
        {
            return new ComparisonPredicateBuilder<OrderLineItemAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedQuantity")),
            p => new CombinationQueryPredicate<OrderLineItemAddedMessageQueryBuilderDsl>(p, OrderLineItemAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
