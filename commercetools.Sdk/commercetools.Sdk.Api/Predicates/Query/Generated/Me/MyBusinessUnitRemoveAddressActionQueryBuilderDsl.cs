// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitRemoveAddressActionQueryBuilderDsl
    {
        public MyBusinessUnitRemoveAddressActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitRemoveAddressActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitRemoveAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitRemoveAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitRemoveAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitRemoveAddressActionQueryBuilderDsl>(p, MyBusinessUnitRemoveAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitRemoveAddressActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitRemoveAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyBusinessUnitRemoveAddressActionQueryBuilderDsl>(p, MyBusinessUnitRemoveAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitRemoveAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitRemoveAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyBusinessUnitRemoveAddressActionQueryBuilderDsl>(p, MyBusinessUnitRemoveAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
