using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerRemoveShippingAddressIdActionQueryBuilderDsl
    {
        public CustomerRemoveShippingAddressIdActionQueryBuilderDsl()
        {
        }

        public static CustomerRemoveShippingAddressIdActionQueryBuilderDsl Of()
        {
            return new CustomerRemoveShippingAddressIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerRemoveShippingAddressIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerRemoveShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerRemoveShippingAddressIdActionQueryBuilderDsl>(p, CustomerRemoveShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerRemoveShippingAddressIdActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<CustomerRemoveShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<CustomerRemoveShippingAddressIdActionQueryBuilderDsl>(p, CustomerRemoveShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerRemoveShippingAddressIdActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<CustomerRemoveShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<CustomerRemoveShippingAddressIdActionQueryBuilderDsl>(p, CustomerRemoveShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
