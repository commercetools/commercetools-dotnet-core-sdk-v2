using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AssociateRoles
{

    public partial class AssociateRoleQueryBuilderDsl
    {
        public AssociateRoleQueryBuilderDsl()
        {
        }

        public static AssociateRoleQueryBuilderDsl Of()
        {
            return new AssociateRoleQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<AssociateRoleQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<AssociateRoleQueryBuilderDsl>(p, AssociateRoleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<AssociateRoleQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<AssociateRoleQueryBuilderDsl>(p, AssociateRoleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<AssociateRoleQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<AssociateRoleQueryBuilderDsl>(p, AssociateRoleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<AssociateRoleQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<AssociateRoleQueryBuilderDsl>(p, AssociateRoleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRoleQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                AssociateRoleQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AssociateRoleQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                AssociateRoleQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssociateRoleQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AssociateRoleQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AssociateRoleQueryBuilderDsl>(p, AssociateRoleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleQueryBuilderDsl, bool> BuyerAssignable()
        {
            return new ComparisonPredicateBuilder<AssociateRoleQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("buyerAssignable")),
            p => new CombinationQueryPredicate<AssociateRoleQueryBuilderDsl>(p, AssociateRoleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AssociateRoleQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AssociateRoleQueryBuilderDsl>(p, AssociateRoleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<AssociateRoleQueryBuilderDsl, string> Permissions()
        {
            return new ComparableCollectionPredicateBuilder<AssociateRoleQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permissions")),
            p => new CombinationQueryPredicate<AssociateRoleQueryBuilderDsl>(p, AssociateRoleQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRoleQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                AssociateRoleQueryBuilderDsl.Of);
        }


    }
}
