using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class AssociateQueryBuilderDsl
    {
        public AssociateQueryBuilderDsl()
        {
        }

        public static AssociateQueryBuilderDsl Of()
        {
            return new AssociateQueryBuilderDsl();
        }

        public CombinationQueryPredicate<AssociateQueryBuilderDsl> AssociateRoleAssignments(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateRoleAssignmentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateRoleAssignmentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateRoleAssignments"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateRoleAssignmentQueryBuilderDsl.Of())),
                AssociateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AssociateQueryBuilderDsl> AssociateRoleAssignments()
        {
            return new CollectionPredicateBuilder<AssociateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associateRoleAssignments")),
                    p => new CombinationQueryPredicate<AssociateQueryBuilderDsl>(p, AssociateQueryBuilderDsl.Of));
        }
        public IComparableCollectionPredicateBuilder<AssociateQueryBuilderDsl, string> Roles()
        {
            return new ComparableCollectionPredicateBuilder<AssociateQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("roles")),
            p => new CombinationQueryPredicate<AssociateQueryBuilderDsl>(p, AssociateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                AssociateQueryBuilderDsl.Of);
        }


    }
}
