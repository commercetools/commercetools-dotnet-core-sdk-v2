using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class ResourceDeletedDeliveryPayloadQueryBuilderDsl
    {
        public ResourceDeletedDeliveryPayloadQueryBuilderDsl()
        {
        }

        public static ResourceDeletedDeliveryPayloadQueryBuilderDsl Of()
        {
            return new ResourceDeletedDeliveryPayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ResourceDeletedDeliveryPayloadQueryBuilderDsl, string> ProjectKey()
        {
            return new ComparisonPredicateBuilder<ResourceDeletedDeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("projectKey")),
            p => new CombinationQueryPredicate<ResourceDeletedDeliveryPayloadQueryBuilderDsl>(p, ResourceDeletedDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ResourceDeletedDeliveryPayloadQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<ResourceDeletedDeliveryPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<ResourceDeletedDeliveryPayloadQueryBuilderDsl>(p, ResourceDeletedDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ResourceDeletedDeliveryPayloadQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceDeletedDeliveryPayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ResourceDeletedDeliveryPayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ResourceDeletedDeliveryPayloadQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ResourceDeletedDeliveryPayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ResourceDeletedDeliveryPayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ResourceDeletedDeliveryPayloadQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ResourceDeletedDeliveryPayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ResourceDeletedDeliveryPayloadQueryBuilderDsl>(p, ResourceDeletedDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ResourceDeletedDeliveryPayloadQueryBuilderDsl, DateTime> ModifiedAt()
        {
            return new ComparisonPredicateBuilder<ResourceDeletedDeliveryPayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("modifiedAt")),
            p => new CombinationQueryPredicate<ResourceDeletedDeliveryPayloadQueryBuilderDsl>(p, ResourceDeletedDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ResourceDeletedDeliveryPayloadQueryBuilderDsl, bool> DataErasure()
        {
            return new ComparisonPredicateBuilder<ResourceDeletedDeliveryPayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("dataErasure")),
            p => new CombinationQueryPredicate<ResourceDeletedDeliveryPayloadQueryBuilderDsl>(p, ResourceDeletedDeliveryPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
