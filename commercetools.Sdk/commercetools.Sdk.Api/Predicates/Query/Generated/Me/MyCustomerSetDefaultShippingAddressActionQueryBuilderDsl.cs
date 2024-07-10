using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl
    {
        public MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl()
        {
        }

        public static MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl Of()
        {
            return new MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl>(p, MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl>(p, MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl>(p, MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
