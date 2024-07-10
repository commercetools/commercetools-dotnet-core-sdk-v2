using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class DeliveryFormatQueryBuilderDsl
    {
        public DeliveryFormatQueryBuilderDsl()
        {
        }

        public static DeliveryFormatQueryBuilderDsl Of()
        {
            return new DeliveryFormatQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DeliveryFormatQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DeliveryFormatQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DeliveryFormatQueryBuilderDsl>(p, DeliveryFormatQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<DeliveryFormatQueryBuilderDsl> AsCloudEvents(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.CloudEventsFormatQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.CloudEventsFormatQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryFormatQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.CloudEventsFormatQueryBuilderDsl.Of()),
                DeliveryFormatQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DeliveryFormatQueryBuilderDsl> AsPlatform(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.PlatformFormatQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.PlatformFormatQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryFormatQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.PlatformFormatQueryBuilderDsl.Of()),
                DeliveryFormatQueryBuilderDsl.Of);
        }
    }
}
