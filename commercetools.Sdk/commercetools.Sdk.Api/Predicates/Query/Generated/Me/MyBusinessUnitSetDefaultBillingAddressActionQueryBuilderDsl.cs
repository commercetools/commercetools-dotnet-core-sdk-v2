// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl
    {
        public MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl>(p, MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl>(p, MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl>(p, MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
