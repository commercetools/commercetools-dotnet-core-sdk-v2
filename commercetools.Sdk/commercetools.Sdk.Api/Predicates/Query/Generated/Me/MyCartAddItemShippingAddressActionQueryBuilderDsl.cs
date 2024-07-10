using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartAddItemShippingAddressActionQueryBuilderDsl
    {
        public MyCartAddItemShippingAddressActionQueryBuilderDsl()
        {
        }

        public static MyCartAddItemShippingAddressActionQueryBuilderDsl Of()
        {
            return new MyCartAddItemShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartAddItemShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartAddItemShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartAddItemShippingAddressActionQueryBuilderDsl>(p, MyCartAddItemShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartAddItemShippingAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartAddItemShippingAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                MyCartAddItemShippingAddressActionQueryBuilderDsl.Of);
        }


    }
}
