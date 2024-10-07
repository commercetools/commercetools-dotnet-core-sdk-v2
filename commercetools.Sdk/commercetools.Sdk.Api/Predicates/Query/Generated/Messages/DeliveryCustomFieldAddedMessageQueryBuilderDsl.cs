using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DeliveryCustomFieldAddedMessageQueryBuilderDsl
    {
        public DeliveryCustomFieldAddedMessageQueryBuilderDsl()
        {
        }

        public static DeliveryCustomFieldAddedMessageQueryBuilderDsl Of()
        {
            return new DeliveryCustomFieldAddedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl>(p, DeliveryCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl>(p, DeliveryCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl>(p, DeliveryCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl>(p, DeliveryCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                DeliveryCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                DeliveryCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl>(p, DeliveryCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                DeliveryCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl>(p, DeliveryCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl>(p, DeliveryCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                DeliveryCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl>(p, DeliveryCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl>(p, DeliveryCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<DeliveryCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<DeliveryCustomFieldAddedMessageQueryBuilderDsl>(p, DeliveryCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
