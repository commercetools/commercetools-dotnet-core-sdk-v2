using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderReturnShipmentStateChangedMessageQueryBuilderDsl
    {
        public OrderReturnShipmentStateChangedMessageQueryBuilderDsl()
        {
        }

        public static OrderReturnShipmentStateChangedMessageQueryBuilderDsl Of()
        {
            return new OrderReturnShipmentStateChangedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl>(p, OrderReturnShipmentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl>(p, OrderReturnShipmentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl>(p, OrderReturnShipmentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl>(p, OrderReturnShipmentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderReturnShipmentStateChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderReturnShipmentStateChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl>(p, OrderReturnShipmentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderReturnShipmentStateChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl>(p, OrderReturnShipmentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl>(p, OrderReturnShipmentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderReturnShipmentStateChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, string> ReturnItemId()
        {
            return new ComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnItemId")),
            p => new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl>(p, OrderReturnShipmentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, string> ReturnShipmentState()
        {
            return new ComparisonPredicateBuilder<OrderReturnShipmentStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnShipmentState")),
            p => new CombinationQueryPredicate<OrderReturnShipmentStateChangedMessageQueryBuilderDsl>(p, OrderReturnShipmentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
