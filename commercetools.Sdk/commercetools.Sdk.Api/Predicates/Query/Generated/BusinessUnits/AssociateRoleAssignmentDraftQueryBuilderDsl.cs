using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class AssociateRoleAssignmentDraftQueryBuilderDsl
    {
        public AssociateRoleAssignmentDraftQueryBuilderDsl()
        {
        }

        public static AssociateRoleAssignmentDraftQueryBuilderDsl Of()
        {
            return new AssociateRoleAssignmentDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<AssociateRoleAssignmentDraftQueryBuilderDsl> AssociateRole(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleAssignmentDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateRole"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleResourceIdentifierQueryBuilderDsl.Of())),
                AssociateRoleAssignmentDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssociateRoleAssignmentDraftQueryBuilderDsl, string> Inheritance()
        {
            return new ComparisonPredicateBuilder<AssociateRoleAssignmentDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inheritance")),
            p => new CombinationQueryPredicate<AssociateRoleAssignmentDraftQueryBuilderDsl>(p, AssociateRoleAssignmentDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
