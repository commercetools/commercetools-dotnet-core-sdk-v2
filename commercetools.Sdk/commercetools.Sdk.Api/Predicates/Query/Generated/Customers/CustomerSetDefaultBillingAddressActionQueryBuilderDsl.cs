using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetDefaultBillingAddressActionQueryBuilderDsl
    {
        public CustomerSetDefaultBillingAddressActionQueryBuilderDsl()
        {
        }

        public static CustomerSetDefaultBillingAddressActionQueryBuilderDsl Of()
        {
            return new CustomerSetDefaultBillingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetDefaultBillingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetDefaultBillingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetDefaultBillingAddressActionQueryBuilderDsl>(p, CustomerSetDefaultBillingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetDefaultBillingAddressActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<CustomerSetDefaultBillingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<CustomerSetDefaultBillingAddressActionQueryBuilderDsl>(p, CustomerSetDefaultBillingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetDefaultBillingAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<CustomerSetDefaultBillingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<CustomerSetDefaultBillingAddressActionQueryBuilderDsl>(p, CustomerSetDefaultBillingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
