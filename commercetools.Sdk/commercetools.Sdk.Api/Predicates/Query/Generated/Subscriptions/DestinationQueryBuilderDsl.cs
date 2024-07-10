using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class DestinationQueryBuilderDsl
    {
        public DestinationQueryBuilderDsl()
        {
        }

        public static DestinationQueryBuilderDsl Of()
        {
            return new DestinationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DestinationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DestinationQueryBuilderDsl>(p, DestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<DestinationQueryBuilderDsl> AsEventGrid(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.AzureEventGridDestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.AzureEventGridDestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DestinationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.AzureEventGridDestinationQueryBuilderDsl.Of()),
                DestinationQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DestinationQueryBuilderDsl> AsAzureServiceBus(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.AzureServiceBusDestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.AzureServiceBusDestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DestinationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.AzureServiceBusDestinationQueryBuilderDsl.Of()),
                DestinationQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DestinationQueryBuilderDsl> AsConfluentCloud(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.ConfluentCloudDestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.ConfluentCloudDestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DestinationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.ConfluentCloudDestinationQueryBuilderDsl.Of()),
                DestinationQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DestinationQueryBuilderDsl> AsEventBridge(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.EventBridgeDestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.EventBridgeDestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DestinationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.EventBridgeDestinationQueryBuilderDsl.Of()),
                DestinationQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DestinationQueryBuilderDsl> AsGoogleCloudPubSub(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.GoogleCloudPubSubDestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.GoogleCloudPubSubDestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DestinationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.GoogleCloudPubSubDestinationQueryBuilderDsl.Of()),
                DestinationQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DestinationQueryBuilderDsl> AsSns(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SnsDestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SnsDestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DestinationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.SnsDestinationQueryBuilderDsl.Of()),
                DestinationQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DestinationQueryBuilderDsl> AsSqs(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SqsDestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SqsDestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DestinationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.SqsDestinationQueryBuilderDsl.Of()),
                DestinationQueryBuilderDsl.Of);
        }
    }
}
