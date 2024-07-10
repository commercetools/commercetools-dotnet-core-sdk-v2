using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class SubscriptionQueryBuilderDsl
    {
        public SubscriptionQueryBuilderDsl()
        {
        }

        public static SubscriptionQueryBuilderDsl Of()
        {
            return new SubscriptionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SubscriptionQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<SubscriptionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<SubscriptionQueryBuilderDsl>(p, SubscriptionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SubscriptionQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<SubscriptionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<SubscriptionQueryBuilderDsl>(p, SubscriptionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SubscriptionQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<SubscriptionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<SubscriptionQueryBuilderDsl>(p, SubscriptionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SubscriptionQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<SubscriptionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<SubscriptionQueryBuilderDsl>(p, SubscriptionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<SubscriptionQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                SubscriptionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<SubscriptionQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                SubscriptionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<SubscriptionQueryBuilderDsl> Changes(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.ChangeSubscriptionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.ChangeSubscriptionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("changes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.ChangeSubscriptionQueryBuilderDsl.Of())),
                SubscriptionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<SubscriptionQueryBuilderDsl> Changes()
        {
            return new CollectionPredicateBuilder<SubscriptionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("changes")),
                    p => new CombinationQueryPredicate<SubscriptionQueryBuilderDsl>(p, SubscriptionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<SubscriptionQueryBuilderDsl> Destination(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.DestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.DestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("destination"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.DestinationQueryBuilderDsl.Of())),
                SubscriptionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<SubscriptionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<SubscriptionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<SubscriptionQueryBuilderDsl>(p, SubscriptionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<SubscriptionQueryBuilderDsl> Messages(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.MessageSubscriptionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.MessageSubscriptionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("messages"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.MessageSubscriptionQueryBuilderDsl.Of())),
                SubscriptionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<SubscriptionQueryBuilderDsl> Messages()
        {
            return new CollectionPredicateBuilder<SubscriptionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("messages")),
                    p => new CombinationQueryPredicate<SubscriptionQueryBuilderDsl>(p, SubscriptionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<SubscriptionQueryBuilderDsl> Format(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.DeliveryFormatQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.DeliveryFormatQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("format"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.DeliveryFormatQueryBuilderDsl.Of())),
                SubscriptionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<SubscriptionQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<SubscriptionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<SubscriptionQueryBuilderDsl>(p, SubscriptionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
