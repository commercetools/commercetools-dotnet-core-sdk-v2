// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetDefaultShippingAddressActionQueryBuilderDsl
    {
        public CustomerSetDefaultShippingAddressActionQueryBuilderDsl()
        {
        }

        public static CustomerSetDefaultShippingAddressActionQueryBuilderDsl Of()
        {
            return new CustomerSetDefaultShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetDefaultShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetDefaultShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetDefaultShippingAddressActionQueryBuilderDsl>(p, CustomerSetDefaultShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetDefaultShippingAddressActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<CustomerSetDefaultShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<CustomerSetDefaultShippingAddressActionQueryBuilderDsl>(p, CustomerSetDefaultShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetDefaultShippingAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<CustomerSetDefaultShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<CustomerSetDefaultShippingAddressActionQueryBuilderDsl>(p, CustomerSetDefaultShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
