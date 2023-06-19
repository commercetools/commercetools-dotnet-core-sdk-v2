// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerRemoveBillingAddressIdActionQueryBuilderDsl
    {
        public CustomerRemoveBillingAddressIdActionQueryBuilderDsl()
        {
        }

        public static CustomerRemoveBillingAddressIdActionQueryBuilderDsl Of()
        {
            return new CustomerRemoveBillingAddressIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerRemoveBillingAddressIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerRemoveBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerRemoveBillingAddressIdActionQueryBuilderDsl>(p, CustomerRemoveBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerRemoveBillingAddressIdActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<CustomerRemoveBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<CustomerRemoveBillingAddressIdActionQueryBuilderDsl>(p, CustomerRemoveBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerRemoveBillingAddressIdActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<CustomerRemoveBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<CustomerRemoveBillingAddressIdActionQueryBuilderDsl>(p, CustomerRemoveBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
