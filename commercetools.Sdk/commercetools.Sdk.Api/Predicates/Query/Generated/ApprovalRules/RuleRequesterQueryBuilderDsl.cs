using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class RuleRequesterQueryBuilderDsl
    {
        public RuleRequesterQueryBuilderDsl()
        {
        }

        public static RuleRequesterQueryBuilderDsl Of()
        {
            return new RuleRequesterQueryBuilderDsl();
        }

        public CombinationQueryPredicate<RuleRequesterQueryBuilderDsl> AssociateRole(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RuleRequesterQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateRole"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl.Of())),
                RuleRequesterQueryBuilderDsl.Of);
        }


    }
}
