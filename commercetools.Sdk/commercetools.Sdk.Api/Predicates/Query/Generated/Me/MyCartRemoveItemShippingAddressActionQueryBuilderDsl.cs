using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartRemoveItemShippingAddressActionQueryBuilderDsl
    {
        public MyCartRemoveItemShippingAddressActionQueryBuilderDsl()
        {
        }

        public static MyCartRemoveItemShippingAddressActionQueryBuilderDsl Of()
        {
            return new MyCartRemoveItemShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartRemoveItemShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartRemoveItemShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartRemoveItemShippingAddressActionQueryBuilderDsl>(p, MyCartRemoveItemShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartRemoveItemShippingAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyCartRemoveItemShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyCartRemoveItemShippingAddressActionQueryBuilderDsl>(p, MyCartRemoveItemShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
