// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl
    {
        public MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl()
        {
        }

        public static MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl Of()
        {
            return new MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl>(p, MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl>(p, MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl>(p, MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
