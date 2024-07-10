using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerRemoveAddressActionQueryBuilderDsl
    {
        public MyCustomerRemoveAddressActionQueryBuilderDsl()
        {
        }

        public static MyCustomerRemoveAddressActionQueryBuilderDsl Of()
        {
            return new MyCustomerRemoveAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerRemoveAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerRemoveAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerRemoveAddressActionQueryBuilderDsl>(p, MyCustomerRemoveAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerRemoveAddressActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyCustomerRemoveAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyCustomerRemoveAddressActionQueryBuilderDsl>(p, MyCustomerRemoveAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerRemoveAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyCustomerRemoveAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyCustomerRemoveAddressActionQueryBuilderDsl>(p, MyCustomerRemoveAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
