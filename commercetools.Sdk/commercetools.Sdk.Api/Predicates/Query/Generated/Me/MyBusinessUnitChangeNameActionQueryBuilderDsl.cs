// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitChangeNameActionQueryBuilderDsl
    {
        public MyBusinessUnitChangeNameActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitChangeNameActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitChangeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitChangeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitChangeNameActionQueryBuilderDsl>(p, MyBusinessUnitChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitChangeNameActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<MyBusinessUnitChangeNameActionQueryBuilderDsl>(p, MyBusinessUnitChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
