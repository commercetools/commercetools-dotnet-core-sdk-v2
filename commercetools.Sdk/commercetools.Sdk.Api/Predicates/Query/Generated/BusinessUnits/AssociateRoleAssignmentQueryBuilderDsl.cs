using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class AssociateRoleAssignmentQueryBuilderDsl
    {
        public AssociateRoleAssignmentQueryBuilderDsl()
        {
        }

        public static AssociateRoleAssignmentQueryBuilderDsl Of()
        {
            return new AssociateRoleAssignmentQueryBuilderDsl();
        }

        public CombinationQueryPredicate<AssociateRoleAssignmentQueryBuilderDsl> AssociateRole(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleAssignmentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateRole"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl.Of())),
                AssociateRoleAssignmentQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssociateRoleAssignmentQueryBuilderDsl, string> Inheritance()
        {
            return new ComparisonPredicateBuilder<AssociateRoleAssignmentQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inheritance")),
            p => new CombinationQueryPredicate<AssociateRoleAssignmentQueryBuilderDsl>(p, AssociateRoleAssignmentQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
