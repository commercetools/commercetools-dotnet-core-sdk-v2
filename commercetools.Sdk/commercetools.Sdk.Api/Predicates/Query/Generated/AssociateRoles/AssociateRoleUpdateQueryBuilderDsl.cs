using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AssociateRoles
{

    public partial class AssociateRoleUpdateQueryBuilderDsl
    {
        public AssociateRoleUpdateQueryBuilderDsl()
        {
        }

        public static AssociateRoleUpdateQueryBuilderDsl Of()
        {
            return new AssociateRoleUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<AssociateRoleUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<AssociateRoleUpdateQueryBuilderDsl>(p, AssociateRoleUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRoleUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleUpdateActionQueryBuilderDsl.Of())),
                AssociateRoleUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AssociateRoleUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<AssociateRoleUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<AssociateRoleUpdateQueryBuilderDsl>(p, AssociateRoleUpdateQueryBuilderDsl.Of));
        }

    }
}
