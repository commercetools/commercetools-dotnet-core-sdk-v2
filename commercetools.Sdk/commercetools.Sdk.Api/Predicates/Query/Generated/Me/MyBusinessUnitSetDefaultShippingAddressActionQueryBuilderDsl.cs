// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl
    {
        public MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl>(p, MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl>(p, MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl>(p, MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
