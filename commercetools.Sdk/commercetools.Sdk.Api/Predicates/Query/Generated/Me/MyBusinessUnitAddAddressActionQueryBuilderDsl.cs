using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitAddAddressActionQueryBuilderDsl
    {
        public MyBusinessUnitAddAddressActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitAddAddressActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitAddAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitAddAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitAddAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitAddAddressActionQueryBuilderDsl>(p, MyBusinessUnitAddAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyBusinessUnitAddAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitAddAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                MyBusinessUnitAddAddressActionQueryBuilderDsl.Of);
        }


    }
}
