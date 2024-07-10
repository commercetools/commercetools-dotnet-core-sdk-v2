using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartUpdateItemShippingAddressActionQueryBuilderDsl
    {
        public MyCartUpdateItemShippingAddressActionQueryBuilderDsl()
        {
        }

        public static MyCartUpdateItemShippingAddressActionQueryBuilderDsl Of()
        {
            return new MyCartUpdateItemShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartUpdateItemShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartUpdateItemShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartUpdateItemShippingAddressActionQueryBuilderDsl>(p, MyCartUpdateItemShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartUpdateItemShippingAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateItemShippingAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                MyCartUpdateItemShippingAddressActionQueryBuilderDsl.Of);
        }


    }
}
