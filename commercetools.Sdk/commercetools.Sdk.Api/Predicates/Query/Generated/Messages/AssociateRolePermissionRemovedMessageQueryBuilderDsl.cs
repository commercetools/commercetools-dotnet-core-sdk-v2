using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class AssociateRolePermissionRemovedMessageQueryBuilderDsl
    {
        public AssociateRolePermissionRemovedMessageQueryBuilderDsl()
        {
        }

        public static AssociateRolePermissionRemovedMessageQueryBuilderDsl Of()
        {
            return new AssociateRolePermissionRemovedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl>(p, AssociateRolePermissionRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl>(p, AssociateRolePermissionRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl>(p, AssociateRolePermissionRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl>(p, AssociateRolePermissionRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                AssociateRolePermissionRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                AssociateRolePermissionRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl>(p, AssociateRolePermissionRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                AssociateRolePermissionRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl>(p, AssociateRolePermissionRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl>(p, AssociateRolePermissionRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                AssociateRolePermissionRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, string> Permission()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permission")),
            p => new CombinationQueryPredicate<AssociateRolePermissionRemovedMessageQueryBuilderDsl>(p, AssociateRolePermissionRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
