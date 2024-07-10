using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AssociateRoles
{

    public partial class AssociateRoleSetCustomFieldActionQueryBuilderDsl
    {
        public AssociateRoleSetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static AssociateRoleSetCustomFieldActionQueryBuilderDsl Of()
        {
            return new AssociateRoleSetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleSetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<AssociateRoleSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<AssociateRoleSetCustomFieldActionQueryBuilderDsl>(p, AssociateRoleSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleSetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AssociateRoleSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AssociateRoleSetCustomFieldActionQueryBuilderDsl>(p, AssociateRoleSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleSetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<AssociateRoleSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<AssociateRoleSetCustomFieldActionQueryBuilderDsl>(p, AssociateRoleSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
