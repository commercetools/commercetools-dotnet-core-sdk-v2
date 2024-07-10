using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCustomLineItemAddedMessageQueryBuilderDsl
    {
        public OrderCustomLineItemAddedMessageQueryBuilderDsl()
        {
        }

        public static OrderCustomLineItemAddedMessageQueryBuilderDsl Of()
        {
            return new OrderCustomLineItemAddedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCustomLineItemAddedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl>(p, OrderCustomLineItemAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomLineItemAddedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl>(p, OrderCustomLineItemAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomLineItemAddedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl>(p, OrderCustomLineItemAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomLineItemAddedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl>(p, OrderCustomLineItemAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderCustomLineItemAddedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderCustomLineItemAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderCustomLineItemAddedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl>(p, OrderCustomLineItemAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderCustomLineItemAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderCustomLineItemAddedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl>(p, OrderCustomLineItemAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomLineItemAddedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCustomLineItemAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl>(p, OrderCustomLineItemAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderCustomLineItemAddedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl> CustomLineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomLineItemAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customLineItem"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CustomLineItemQueryBuilderDsl.Of())),
                OrderCustomLineItemAddedMessageQueryBuilderDsl.Of);
        }


    }
}
