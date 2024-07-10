// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl
    {
        public MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl>(p, MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl>(p, MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl>(p, MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
