using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class MessageDeliveryPayloadQueryBuilderDsl
    {
        public MessageDeliveryPayloadQueryBuilderDsl()
        {
        }

        public static MessageDeliveryPayloadQueryBuilderDsl Of()
        {
            return new MessageDeliveryPayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, string> ProjectKey()
        {
            return new ComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("projectKey")),
            p => new CombinationQueryPredicate<MessageDeliveryPayloadQueryBuilderDsl>(p, MessageDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<MessageDeliveryPayloadQueryBuilderDsl>(p, MessageDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MessageDeliveryPayloadQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageDeliveryPayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                MessageDeliveryPayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MessageDeliveryPayloadQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageDeliveryPayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                MessageDeliveryPayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<MessageDeliveryPayloadQueryBuilderDsl>(p, MessageDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<MessageDeliveryPayloadQueryBuilderDsl>(p, MessageDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<MessageDeliveryPayloadQueryBuilderDsl>(p, MessageDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<MessageDeliveryPayloadQueryBuilderDsl>(p, MessageDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<MessageDeliveryPayloadQueryBuilderDsl>(p, MessageDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<MessageDeliveryPayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<MessageDeliveryPayloadQueryBuilderDsl>(p, MessageDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MessageDeliveryPayloadQueryBuilderDsl> PayloadNotIncluded(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.PayloadNotIncludedQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.PayloadNotIncludedQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MessageDeliveryPayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("payloadNotIncluded"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.PayloadNotIncludedQueryBuilderDsl.Of())),
                MessageDeliveryPayloadQueryBuilderDsl.Of);
        }


    }
}
