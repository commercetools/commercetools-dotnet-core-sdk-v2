using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AssociateRoles
{

    public partial class AssociateRoleUpdateActionQueryBuilderDsl
    {
        public AssociateRoleUpdateActionQueryBuilderDsl()
        {
        }

        public static AssociateRoleUpdateActionQueryBuilderDsl Of()
        {
            return new AssociateRoleUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<AssociateRoleUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<AssociateRoleUpdateActionQueryBuilderDsl>(p, AssociateRoleUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<AssociateRoleUpdateActionQueryBuilderDsl> AsAddPermission(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleAddPermissionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleAddPermissionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleAddPermissionActionQueryBuilderDsl.Of()),
                AssociateRoleUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AssociateRoleUpdateActionQueryBuilderDsl> AsChangeBuyerAssignable(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleChangeBuyerAssignableActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleChangeBuyerAssignableActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleChangeBuyerAssignableActionQueryBuilderDsl.Of()),
                AssociateRoleUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AssociateRoleUpdateActionQueryBuilderDsl> AsRemovePermission(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleRemovePermissionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleRemovePermissionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleRemovePermissionActionQueryBuilderDsl.Of()),
                AssociateRoleUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AssociateRoleUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleSetCustomFieldActionQueryBuilderDsl.Of()),
                AssociateRoleUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AssociateRoleUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleSetCustomTypeActionQueryBuilderDsl.Of()),
                AssociateRoleUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AssociateRoleUpdateActionQueryBuilderDsl> AsSetName(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleSetNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleSetNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleSetNameActionQueryBuilderDsl.Of()),
                AssociateRoleUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AssociateRoleUpdateActionQueryBuilderDsl> AsSetPermissions(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleSetPermissionsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleSetPermissionsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleSetPermissionsActionQueryBuilderDsl.Of()),
                AssociateRoleUpdateActionQueryBuilderDsl.Of);
        }
    }
}
