using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class DeliveryPayloadQueryBuilderDsl
    {
        public DeliveryPayloadQueryBuilderDsl()
        {
        }

        public static DeliveryPayloadQueryBuilderDsl Of()
        {
            return new DeliveryPayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DeliveryPayloadQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<DeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<DeliveryPayloadQueryBuilderDsl>(p, DeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryPayloadQueryBuilderDsl, string> ProjectKey()
        {
            return new ComparisonPredicateBuilder<DeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("projectKey")),
            p => new CombinationQueryPredicate<DeliveryPayloadQueryBuilderDsl>(p, DeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DeliveryPayloadQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryPayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                DeliveryPayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DeliveryPayloadQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryPayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                DeliveryPayloadQueryBuilderDsl.Of);
        }


        public CombinationQueryPredicate<DeliveryPayloadQueryBuilderDsl> AsMessage(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.MessageDeliveryPayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.MessageDeliveryPayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryPayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.MessageDeliveryPayloadQueryBuilderDsl.Of()),
                DeliveryPayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DeliveryPayloadQueryBuilderDsl> AsResourceCreated(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.ResourceCreatedDeliveryPayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.ResourceCreatedDeliveryPayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryPayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.ResourceCreatedDeliveryPayloadQueryBuilderDsl.Of()),
                DeliveryPayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DeliveryPayloadQueryBuilderDsl> AsResourceDeleted(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.ResourceDeletedDeliveryPayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.ResourceDeletedDeliveryPayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryPayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.ResourceDeletedDeliveryPayloadQueryBuilderDsl.Of()),
                DeliveryPayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DeliveryPayloadQueryBuilderDsl> AsResourceUpdated(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.ResourceUpdatedDeliveryPayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.ResourceUpdatedDeliveryPayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryPayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.ResourceUpdatedDeliveryPayloadQueryBuilderDsl.Of()),
                DeliveryPayloadQueryBuilderDsl.Of);
        }
    }
}
