using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderPaymentStateChangedMessageQueryBuilderDsl
    {
        public OrderPaymentStateChangedMessageQueryBuilderDsl()
        {
        }

        public static OrderPaymentStateChangedMessageQueryBuilderDsl Of()
        {
            return new OrderPaymentStateChangedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl>(p, OrderPaymentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl>(p, OrderPaymentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl>(p, OrderPaymentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl>(p, OrderPaymentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderPaymentStateChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderPaymentStateChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl>(p, OrderPaymentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderPaymentStateChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl>(p, OrderPaymentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl>(p, OrderPaymentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderPaymentStateChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, string> PaymentState()
        {
            return new ComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentState")),
            p => new CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl>(p, OrderPaymentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, string> OldPaymentState()
        {
            return new ComparisonPredicateBuilder<OrderPaymentStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldPaymentState")),
            p => new CombinationQueryPredicate<OrderPaymentStateChangedMessageQueryBuilderDsl>(p, OrderPaymentStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
