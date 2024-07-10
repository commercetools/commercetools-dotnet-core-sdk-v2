using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitRemoveAssociateActionQueryBuilderDsl
    {
        public BusinessUnitRemoveAssociateActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitRemoveAssociateActionQueryBuilderDsl Of()
        {
            return new BusinessUnitRemoveAssociateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitRemoveAssociateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitRemoveAssociateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitRemoveAssociateActionQueryBuilderDsl>(p, BusinessUnitRemoveAssociateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitRemoveAssociateActionQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitRemoveAssociateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of())),
                BusinessUnitRemoveAssociateActionQueryBuilderDsl.Of);
        }


    }
}
