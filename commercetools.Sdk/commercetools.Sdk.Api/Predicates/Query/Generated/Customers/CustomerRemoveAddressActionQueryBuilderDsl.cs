// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerRemoveAddressActionQueryBuilderDsl
    {
        public CustomerRemoveAddressActionQueryBuilderDsl()
        {
        }

        public static CustomerRemoveAddressActionQueryBuilderDsl Of()
        {
            return new CustomerRemoveAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerRemoveAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerRemoveAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerRemoveAddressActionQueryBuilderDsl>(p, CustomerRemoveAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerRemoveAddressActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<CustomerRemoveAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<CustomerRemoveAddressActionQueryBuilderDsl>(p, CustomerRemoveAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerRemoveAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<CustomerRemoveAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<CustomerRemoveAddressActionQueryBuilderDsl>(p, CustomerRemoveAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
