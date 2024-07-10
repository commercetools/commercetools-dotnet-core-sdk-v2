// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl
    {
        public MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl()
        {
        }

        public static MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl Of()
        {
            return new MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl>(p, MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl>(p, MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl>(p, MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
