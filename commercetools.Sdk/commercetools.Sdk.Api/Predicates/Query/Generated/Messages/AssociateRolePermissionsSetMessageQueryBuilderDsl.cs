using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class AssociateRolePermissionsSetMessageQueryBuilderDsl
    {
        public AssociateRolePermissionsSetMessageQueryBuilderDsl()
        {
        }

        public static AssociateRolePermissionsSetMessageQueryBuilderDsl Of()
        {
            return new AssociateRolePermissionsSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl>(p, AssociateRolePermissionsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl>(p, AssociateRolePermissionsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl>(p, AssociateRolePermissionsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl>(p, AssociateRolePermissionsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                AssociateRolePermissionsSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                AssociateRolePermissionsSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl>(p, AssociateRolePermissionsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                AssociateRolePermissionsSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl>(p, AssociateRolePermissionsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl>(p, AssociateRolePermissionsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                AssociateRolePermissionsSetMessageQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, string> Permissions()
        {
            return new ComparableCollectionPredicateBuilder<AssociateRolePermissionsSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permissions")),
            p => new CombinationQueryPredicate<AssociateRolePermissionsSetMessageQueryBuilderDsl>(p, AssociateRolePermissionsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
