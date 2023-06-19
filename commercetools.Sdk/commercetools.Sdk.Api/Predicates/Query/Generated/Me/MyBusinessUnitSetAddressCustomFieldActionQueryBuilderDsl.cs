// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl
    {
        public MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl>(p, MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl>(p, MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl>(p, MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl>(p, MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
