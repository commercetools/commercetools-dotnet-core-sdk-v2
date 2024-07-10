using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class SubscriptionDraftQueryBuilderDsl
    {
        public SubscriptionDraftQueryBuilderDsl()
        {
        }

        public static SubscriptionDraftQueryBuilderDsl Of()
        {
            return new SubscriptionDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SubscriptionDraftQueryBuilderDsl> Changes(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.ChangeSubscriptionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.ChangeSubscriptionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("changes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.ChangeSubscriptionQueryBuilderDsl.Of())),
                SubscriptionDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<SubscriptionDraftQueryBuilderDsl> Changes()
        {
            return new CollectionPredicateBuilder<SubscriptionDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("changes")),
                    p => new CombinationQueryPredicate<SubscriptionDraftQueryBuilderDsl>(p, SubscriptionDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<SubscriptionDraftQueryBuilderDsl> Destination(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.DestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.DestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("destination"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.DestinationQueryBuilderDsl.Of())),
                SubscriptionDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<SubscriptionDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<SubscriptionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<SubscriptionDraftQueryBuilderDsl>(p, SubscriptionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<SubscriptionDraftQueryBuilderDsl> Messages(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.MessageSubscriptionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.MessageSubscriptionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("messages"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.MessageSubscriptionQueryBuilderDsl.Of())),
                SubscriptionDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<SubscriptionDraftQueryBuilderDsl> Messages()
        {
            return new CollectionPredicateBuilder<SubscriptionDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("messages")),
                    p => new CombinationQueryPredicate<SubscriptionDraftQueryBuilderDsl>(p, SubscriptionDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<SubscriptionDraftQueryBuilderDsl> Format(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.DeliveryFormatQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.DeliveryFormatQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("format"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.DeliveryFormatQueryBuilderDsl.Of())),
                SubscriptionDraftQueryBuilderDsl.Of);
        }


    }
}
