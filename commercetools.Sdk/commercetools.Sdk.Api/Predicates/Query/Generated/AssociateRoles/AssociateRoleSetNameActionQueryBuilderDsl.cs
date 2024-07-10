using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AssociateRoles
{

    public partial class AssociateRoleSetNameActionQueryBuilderDsl
    {
        public AssociateRoleSetNameActionQueryBuilderDsl()
        {
        }

        public static AssociateRoleSetNameActionQueryBuilderDsl Of()
        {
            return new AssociateRoleSetNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleSetNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<AssociateRoleSetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<AssociateRoleSetNameActionQueryBuilderDsl>(p, AssociateRoleSetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleSetNameActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AssociateRoleSetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AssociateRoleSetNameActionQueryBuilderDsl>(p, AssociateRoleSetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
