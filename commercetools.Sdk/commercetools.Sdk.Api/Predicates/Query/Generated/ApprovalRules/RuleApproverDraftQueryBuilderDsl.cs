using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class RuleApproverDraftQueryBuilderDsl
    {
        public RuleApproverDraftQueryBuilderDsl()
        {
        }

        public static RuleApproverDraftQueryBuilderDsl Of()
        {
            return new RuleApproverDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<RuleApproverDraftQueryBuilderDsl> AssociateRole(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RuleApproverDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateRole"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleResourceIdentifierQueryBuilderDsl.Of())),
                RuleApproverDraftQueryBuilderDsl.Of);
        }


    }
}
