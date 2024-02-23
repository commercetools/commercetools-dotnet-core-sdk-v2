using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class ResourceCreatedDeliveryPayloadQueryBuilderDsl
    {
        public ResourceCreatedDeliveryPayloadQueryBuilderDsl()
        {
        }

        public static ResourceCreatedDeliveryPayloadQueryBuilderDsl Of()
        {
            return new ResourceCreatedDeliveryPayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ResourceCreatedDeliveryPayloadQueryBuilderDsl, string> ProjectKey()
        {
            return new ComparisonPredicateBuilder<ResourceCreatedDeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("projectKey")),
            p => new CombinationQueryPredicate<ResourceCreatedDeliveryPayloadQueryBuilderDsl>(p, ResourceCreatedDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ResourceCreatedDeliveryPayloadQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<ResourceCreatedDeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<ResourceCreatedDeliveryPayloadQueryBuilderDsl>(p, ResourceCreatedDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ResourceCreatedDeliveryPayloadQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceCreatedDeliveryPayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ResourceCreatedDeliveryPayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ResourceCreatedDeliveryPayloadQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceCreatedDeliveryPayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ResourceCreatedDeliveryPayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ResourceCreatedDeliveryPayloadQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ResourceCreatedDeliveryPayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ResourceCreatedDeliveryPayloadQueryBuilderDsl>(p, ResourceCreatedDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ResourceCreatedDeliveryPayloadQueryBuilderDsl, DateTime> ModifiedAt()
        {
            return new ComparisonPredicateBuilder<ResourceCreatedDeliveryPayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("modifiedAt")),
            p => new CombinationQueryPredicate<ResourceCreatedDeliveryPayloadQueryBuilderDsl>(p, ResourceCreatedDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
