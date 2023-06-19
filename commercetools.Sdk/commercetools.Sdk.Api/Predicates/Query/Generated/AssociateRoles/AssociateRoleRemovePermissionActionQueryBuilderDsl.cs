// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AssociateRoles
{

    public partial class AssociateRoleRemovePermissionActionQueryBuilderDsl
    {
        public AssociateRoleRemovePermissionActionQueryBuilderDsl()
        {
        }

        public static AssociateRoleRemovePermissionActionQueryBuilderDsl Of()
        {
            return new AssociateRoleRemovePermissionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleRemovePermissionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<AssociateRoleRemovePermissionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<AssociateRoleRemovePermissionActionQueryBuilderDsl>(p, AssociateRoleRemovePermissionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleRemovePermissionActionQueryBuilderDsl, string> Permission()
        {
            return new ComparisonPredicateBuilder<AssociateRoleRemovePermissionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permission")),
            p => new CombinationQueryPredicate<AssociateRoleRemovePermissionActionQueryBuilderDsl>(p, AssociateRoleRemovePermissionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
