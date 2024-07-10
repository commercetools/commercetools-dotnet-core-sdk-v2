using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitRemoveAssociateActionQueryBuilderDsl
    {
        public MyBusinessUnitRemoveAssociateActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitRemoveAssociateActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitRemoveAssociateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitRemoveAssociateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitRemoveAssociateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitRemoveAssociateActionQueryBuilderDsl>(p, MyBusinessUnitRemoveAssociateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyBusinessUnitRemoveAssociateActionQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitRemoveAssociateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of())),
                MyBusinessUnitRemoveAssociateActionQueryBuilderDsl.Of);
        }


    }
}
