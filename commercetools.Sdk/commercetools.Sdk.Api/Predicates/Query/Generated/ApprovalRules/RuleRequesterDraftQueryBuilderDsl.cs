using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class RuleRequesterDraftQueryBuilderDsl
    {
        public RuleRequesterDraftQueryBuilderDsl()
        {
        }

        public static RuleRequesterDraftQueryBuilderDsl Of()
        {
            return new RuleRequesterDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<RuleRequesterDraftQueryBuilderDsl> AssociateRole(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RuleRequesterDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateRole"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleResourceIdentifierQueryBuilderDsl.Of())),
                RuleRequesterDraftQueryBuilderDsl.Of);
        }


    }
}
