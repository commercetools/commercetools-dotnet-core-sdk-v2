using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class InheritedAssociateQueryBuilderDsl
    {
        public InheritedAssociateQueryBuilderDsl()
        {
        }

        public static InheritedAssociateQueryBuilderDsl Of()
        {
            return new InheritedAssociateQueryBuilderDsl();
        }

        public CombinationQueryPredicate<InheritedAssociateQueryBuilderDsl> AssociateRoleAssignments(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.InheritedAssociateRoleAssignmentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.InheritedAssociateRoleAssignmentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InheritedAssociateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateRoleAssignments"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.InheritedAssociateRoleAssignmentQueryBuilderDsl.Of())),
                InheritedAssociateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<InheritedAssociateQueryBuilderDsl> AssociateRoleAssignments()
        {
            return new CollectionPredicateBuilder<InheritedAssociateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associateRoleAssignments")),
                    p => new CombinationQueryPredicate<InheritedAssociateQueryBuilderDsl>(p, InheritedAssociateQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<InheritedAssociateQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InheritedAssociateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                InheritedAssociateQueryBuilderDsl.Of);
        }


    }
}
