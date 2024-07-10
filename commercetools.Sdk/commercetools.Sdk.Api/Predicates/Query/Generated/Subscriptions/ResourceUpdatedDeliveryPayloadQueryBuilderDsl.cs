using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class ResourceUpdatedDeliveryPayloadQueryBuilderDsl
    {
        public ResourceUpdatedDeliveryPayloadQueryBuilderDsl()
        {
        }

        public static ResourceUpdatedDeliveryPayloadQueryBuilderDsl Of()
        {
            return new ResourceUpdatedDeliveryPayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ResourceUpdatedDeliveryPayloadQueryBuilderDsl, string> ProjectKey()
        {
            return new ComparisonPredicateBuilder<ResourceUpdatedDeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("projectKey")),
            p => new CombinationQueryPredicate<ResourceUpdatedDeliveryPayloadQueryBuilderDsl>(p, ResourceUpdatedDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ResourceUpdatedDeliveryPayloadQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<ResourceUpdatedDeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<ResourceUpdatedDeliveryPayloadQueryBuilderDsl>(p, ResourceUpdatedDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ResourceUpdatedDeliveryPayloadQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceUpdatedDeliveryPayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ResourceUpdatedDeliveryPayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ResourceUpdatedDeliveryPayloadQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceUpdatedDeliveryPayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ResourceUpdatedDeliveryPayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ResourceUpdatedDeliveryPayloadQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ResourceUpdatedDeliveryPayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ResourceUpdatedDeliveryPayloadQueryBuilderDsl>(p, ResourceUpdatedDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ResourceUpdatedDeliveryPayloadQueryBuilderDsl, long> OldVersion()
        {
            return new ComparisonPredicateBuilder<ResourceUpdatedDeliveryPayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldVersion")),
            p => new CombinationQueryPredicate<ResourceUpdatedDeliveryPayloadQueryBuilderDsl>(p, ResourceUpdatedDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ResourceUpdatedDeliveryPayloadQueryBuilderDsl, DateTime> ModifiedAt()
        {
            return new ComparisonPredicateBuilder<ResourceUpdatedDeliveryPayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("modifiedAt")),
            p => new CombinationQueryPredicate<ResourceUpdatedDeliveryPayloadQueryBuilderDsl>(p, ResourceUpdatedDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
