using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class SubscriptionNotificationQueryBuilderDsl
    {
        public SubscriptionNotificationQueryBuilderDsl()
        {
        }

        public static SubscriptionNotificationQueryBuilderDsl Of()
        {
            return new SubscriptionNotificationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SubscriptionNotificationQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<SubscriptionNotificationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<SubscriptionNotificationQueryBuilderDsl>(p, SubscriptionNotificationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<SubscriptionNotificationQueryBuilderDsl> AsDeliveryPayload(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.DeliveryPayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.DeliveryPayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionNotificationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.DeliveryPayloadQueryBuilderDsl.Of()),
                SubscriptionNotificationQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SubscriptionNotificationQueryBuilderDsl> AsEvent(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.EventDeliveryPayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.EventDeliveryPayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionNotificationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.EventDeliveryPayloadQueryBuilderDsl.Of()),
                SubscriptionNotificationQueryBuilderDsl.Of);
        }
    }
}
