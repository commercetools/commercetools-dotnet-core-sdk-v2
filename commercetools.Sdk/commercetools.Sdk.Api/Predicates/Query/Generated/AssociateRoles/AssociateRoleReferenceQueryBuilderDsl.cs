using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AssociateRoles
{

    public partial class AssociateRoleReferenceQueryBuilderDsl
    {
        public AssociateRoleReferenceQueryBuilderDsl()
        {
        }

        public static AssociateRoleReferenceQueryBuilderDsl Of()
        {
            return new AssociateRoleReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<AssociateRoleReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<AssociateRoleReferenceQueryBuilderDsl>(p, AssociateRoleReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<AssociateRoleReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<AssociateRoleReferenceQueryBuilderDsl>(p, AssociateRoleReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRoleReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl.Of())),
                AssociateRoleReferenceQueryBuilderDsl.Of);
        }


    }
}
