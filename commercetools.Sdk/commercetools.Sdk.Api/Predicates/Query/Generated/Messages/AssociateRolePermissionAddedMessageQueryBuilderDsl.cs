using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class AssociateRolePermissionAddedMessageQueryBuilderDsl
    {
        public AssociateRolePermissionAddedMessageQueryBuilderDsl()
        {
        }

        public static AssociateRolePermissionAddedMessageQueryBuilderDsl Of()
        {
            return new AssociateRolePermissionAddedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl>(p, AssociateRolePermissionAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl>(p, AssociateRolePermissionAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl>(p, AssociateRolePermissionAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl>(p, AssociateRolePermissionAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                AssociateRolePermissionAddedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                AssociateRolePermissionAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl>(p, AssociateRolePermissionAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                AssociateRolePermissionAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl>(p, AssociateRolePermissionAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl>(p, AssociateRolePermissionAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                AssociateRolePermissionAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, string> Permission()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permission")),
            p => new CombinationQueryPredicate<AssociateRolePermissionAddedMessageQueryBuilderDsl>(p, AssociateRolePermissionAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
