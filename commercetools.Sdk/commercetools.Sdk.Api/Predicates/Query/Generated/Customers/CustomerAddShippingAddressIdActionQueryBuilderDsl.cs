using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerAddShippingAddressIdActionQueryBuilderDsl
    {
        public CustomerAddShippingAddressIdActionQueryBuilderDsl()
        {
        }

        public static CustomerAddShippingAddressIdActionQueryBuilderDsl Of()
        {
            return new CustomerAddShippingAddressIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerAddShippingAddressIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerAddShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerAddShippingAddressIdActionQueryBuilderDsl>(p, CustomerAddShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddShippingAddressIdActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<CustomerAddShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<CustomerAddShippingAddressIdActionQueryBuilderDsl>(p, CustomerAddShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddShippingAddressIdActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<CustomerAddShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<CustomerAddShippingAddressIdActionQueryBuilderDsl>(p, CustomerAddShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
