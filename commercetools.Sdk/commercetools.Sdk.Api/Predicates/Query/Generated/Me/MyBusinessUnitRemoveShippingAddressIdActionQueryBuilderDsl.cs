// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl
    {
        public MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl>(p, MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl>(p, MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl>(p, MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
