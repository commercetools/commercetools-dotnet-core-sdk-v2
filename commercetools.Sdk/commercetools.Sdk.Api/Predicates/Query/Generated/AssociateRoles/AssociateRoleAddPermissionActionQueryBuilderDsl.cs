// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AssociateRoles
{

    public partial class AssociateRoleAddPermissionActionQueryBuilderDsl
    {
        public AssociateRoleAddPermissionActionQueryBuilderDsl()
        {
        }

        public static AssociateRoleAddPermissionActionQueryBuilderDsl Of()
        {
            return new AssociateRoleAddPermissionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleAddPermissionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<AssociateRoleAddPermissionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<AssociateRoleAddPermissionActionQueryBuilderDsl>(p, AssociateRoleAddPermissionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleAddPermissionActionQueryBuilderDsl, string> Permission()
        {
            return new ComparisonPredicateBuilder<AssociateRoleAddPermissionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permission")),
            p => new CombinationQueryPredicate<AssociateRoleAddPermissionActionQueryBuilderDsl>(p, AssociateRoleAddPermissionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
