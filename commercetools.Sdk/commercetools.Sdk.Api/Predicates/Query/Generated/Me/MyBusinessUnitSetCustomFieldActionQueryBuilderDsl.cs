// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitSetCustomFieldActionQueryBuilderDsl
    {
        public MyBusinessUnitSetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitSetCustomFieldActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitSetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitSetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetCustomFieldActionQueryBuilderDsl>(p, MyBusinessUnitSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitSetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetCustomFieldActionQueryBuilderDsl>(p, MyBusinessUnitSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitSetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetCustomFieldActionQueryBuilderDsl>(p, MyBusinessUnitSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
