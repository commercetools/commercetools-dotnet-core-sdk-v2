using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartSetShippingAddressActionQueryBuilderDsl
    {
        public MyCartSetShippingAddressActionQueryBuilderDsl()
        {
        }

        public static MyCartSetShippingAddressActionQueryBuilderDsl Of()
        {
            return new MyCartSetShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartSetShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartSetShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartSetShippingAddressActionQueryBuilderDsl>(p, MyCartSetShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartSetShippingAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartSetShippingAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                MyCartSetShippingAddressActionQueryBuilderDsl.Of);
        }


    }
}
