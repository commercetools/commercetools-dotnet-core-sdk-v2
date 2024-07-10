using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerAddAddressActionQueryBuilderDsl
    {
        public MyCustomerAddAddressActionQueryBuilderDsl()
        {
        }

        public static MyCustomerAddAddressActionQueryBuilderDsl Of()
        {
            return new MyCustomerAddAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerAddAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerAddAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerAddAddressActionQueryBuilderDsl>(p, MyCustomerAddAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCustomerAddAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerAddAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                MyCustomerAddAddressActionQueryBuilderDsl.Of);
        }


    }
}
