using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class RuleApproverQueryBuilderDsl
    {
        public RuleApproverQueryBuilderDsl()
        {
        }

        public static RuleApproverQueryBuilderDsl Of()
        {
            return new RuleApproverQueryBuilderDsl();
        }

        public CombinationQueryPredicate<RuleApproverQueryBuilderDsl> AssociateRole(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RuleApproverQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateRole"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl.Of())),
                RuleApproverQueryBuilderDsl.Of);
        }


    }
}
