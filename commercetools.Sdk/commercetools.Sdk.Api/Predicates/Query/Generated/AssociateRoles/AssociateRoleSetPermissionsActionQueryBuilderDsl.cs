using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AssociateRoles
{

    public partial class AssociateRoleSetPermissionsActionQueryBuilderDsl
    {
        public AssociateRoleSetPermissionsActionQueryBuilderDsl()
        {
        }

        public static AssociateRoleSetPermissionsActionQueryBuilderDsl Of()
        {
            return new AssociateRoleSetPermissionsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleSetPermissionsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<AssociateRoleSetPermissionsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<AssociateRoleSetPermissionsActionQueryBuilderDsl>(p, AssociateRoleSetPermissionsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<AssociateRoleSetPermissionsActionQueryBuilderDsl, string> Permissions()
        {
            return new ComparableCollectionPredicateBuilder<AssociateRoleSetPermissionsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permissions")),
            p => new CombinationQueryPredicate<AssociateRoleSetPermissionsActionQueryBuilderDsl>(p, AssociateRoleSetPermissionsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
