using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitAssociateResponseQueryBuilderDsl
    {
        public BusinessUnitAssociateResponseQueryBuilderDsl()
        {
        }

        public static BusinessUnitAssociateResponseQueryBuilderDsl Of()
        {
            return new BusinessUnitAssociateResponseQueryBuilderDsl();
        }

        public CombinationQueryPredicate<BusinessUnitAssociateResponseQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAssociateResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                BusinessUnitAssociateResponseQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitAssociateResponseQueryBuilderDsl> AssociateRoles(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAssociateResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associateRoles"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl.Of())),
                BusinessUnitAssociateResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitAssociateResponseQueryBuilderDsl> AssociateRoles()
        {
            return new CollectionPredicateBuilder<BusinessUnitAssociateResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associateRoles")),
                    p => new CombinationQueryPredicate<BusinessUnitAssociateResponseQueryBuilderDsl>(p, BusinessUnitAssociateResponseQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<BusinessUnitAssociateResponseQueryBuilderDsl> InheritedAssociateRoles(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAssociateResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("inheritedAssociateRoles"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleQueryBuilderDsl.Of())),
                BusinessUnitAssociateResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitAssociateResponseQueryBuilderDsl> InheritedAssociateRoles()
        {
            return new CollectionPredicateBuilder<BusinessUnitAssociateResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inheritedAssociateRoles")),
                    p => new CombinationQueryPredicate<BusinessUnitAssociateResponseQueryBuilderDsl>(p, BusinessUnitAssociateResponseQueryBuilderDsl.Of));
        }
        public IComparableCollectionPredicateBuilder<BusinessUnitAssociateResponseQueryBuilderDsl, string> Permissions()
        {
            return new ComparableCollectionPredicateBuilder<BusinessUnitAssociateResponseQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permissions")),
            p => new CombinationQueryPredicate<BusinessUnitAssociateResponseQueryBuilderDsl>(p, BusinessUnitAssociateResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
