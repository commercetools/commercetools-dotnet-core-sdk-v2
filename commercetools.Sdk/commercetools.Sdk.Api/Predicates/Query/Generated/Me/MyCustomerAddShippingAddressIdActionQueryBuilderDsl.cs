using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerAddShippingAddressIdActionQueryBuilderDsl
    {
        public MyCustomerAddShippingAddressIdActionQueryBuilderDsl()
        {
        }

        public static MyCustomerAddShippingAddressIdActionQueryBuilderDsl Of()
        {
            return new MyCustomerAddShippingAddressIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerAddShippingAddressIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerAddShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerAddShippingAddressIdActionQueryBuilderDsl>(p, MyCustomerAddShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerAddShippingAddressIdActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyCustomerAddShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyCustomerAddShippingAddressIdActionQueryBuilderDsl>(p, MyCustomerAddShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerAddShippingAddressIdActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyCustomerAddShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyCustomerAddShippingAddressIdActionQueryBuilderDsl>(p, MyCustomerAddShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
