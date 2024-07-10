using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerAddBillingAddressIdActionQueryBuilderDsl
    {
        public MyCustomerAddBillingAddressIdActionQueryBuilderDsl()
        {
        }

        public static MyCustomerAddBillingAddressIdActionQueryBuilderDsl Of()
        {
            return new MyCustomerAddBillingAddressIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerAddBillingAddressIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerAddBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerAddBillingAddressIdActionQueryBuilderDsl>(p, MyCustomerAddBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerAddBillingAddressIdActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyCustomerAddBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyCustomerAddBillingAddressIdActionQueryBuilderDsl>(p, MyCustomerAddBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerAddBillingAddressIdActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyCustomerAddBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyCustomerAddBillingAddressIdActionQueryBuilderDsl>(p, MyCustomerAddBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
