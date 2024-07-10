// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl
    {
        public MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl>(p, MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl>(p, MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl>(p, MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
