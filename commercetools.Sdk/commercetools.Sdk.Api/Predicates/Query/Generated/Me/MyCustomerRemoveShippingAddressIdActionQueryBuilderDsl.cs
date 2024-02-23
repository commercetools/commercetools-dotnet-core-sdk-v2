// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl
    {
        public MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl()
        {
        }

        public static MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl Of()
        {
            return new MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl>(p, MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl>(p, MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl>(p, MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
