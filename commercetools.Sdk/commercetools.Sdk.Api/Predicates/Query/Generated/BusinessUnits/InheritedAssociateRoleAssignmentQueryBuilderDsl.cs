using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class InheritedAssociateRoleAssignmentQueryBuilderDsl
    {
        public InheritedAssociateRoleAssignmentQueryBuilderDsl()
        {
        }

        public static InheritedAssociateRoleAssignmentQueryBuilderDsl Of()
        {
            return new InheritedAssociateRoleAssignmentQueryBuilderDsl();
        }

        public CombinationQueryPredicate<InheritedAssociateRoleAssignmentQueryBuilderDsl> AssociateRole(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InheritedAssociateRoleAssignmentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateRole"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl.Of())),
                InheritedAssociateRoleAssignmentQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<InheritedAssociateRoleAssignmentQueryBuilderDsl> Source(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InheritedAssociateRoleAssignmentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("source"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                InheritedAssociateRoleAssignmentQueryBuilderDsl.Of);
        }


    }
}
