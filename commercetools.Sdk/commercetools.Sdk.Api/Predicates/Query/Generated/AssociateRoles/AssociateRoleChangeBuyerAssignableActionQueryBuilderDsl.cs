using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AssociateRoles
{

    public partial class AssociateRoleChangeBuyerAssignableActionQueryBuilderDsl
    {
        public AssociateRoleChangeBuyerAssignableActionQueryBuilderDsl()
        {
        }

        public static AssociateRoleChangeBuyerAssignableActionQueryBuilderDsl Of()
        {
            return new AssociateRoleChangeBuyerAssignableActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleChangeBuyerAssignableActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<AssociateRoleChangeBuyerAssignableActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<AssociateRoleChangeBuyerAssignableActionQueryBuilderDsl>(p, AssociateRoleChangeBuyerAssignableActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleChangeBuyerAssignableActionQueryBuilderDsl, bool> BuyerAssignable()
        {
            return new ComparisonPredicateBuilder<AssociateRoleChangeBuyerAssignableActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("buyerAssignable")),
            p => new CombinationQueryPredicate<AssociateRoleChangeBuyerAssignableActionQueryBuilderDsl>(p, AssociateRoleChangeBuyerAssignableActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
