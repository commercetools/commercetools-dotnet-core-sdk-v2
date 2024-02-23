// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartSetCountryActionQueryBuilderDsl
    {
        public MyCartSetCountryActionQueryBuilderDsl()
        {
        }

        public static MyCartSetCountryActionQueryBuilderDsl Of()
        {
            return new MyCartSetCountryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartSetCountryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartSetCountryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartSetCountryActionQueryBuilderDsl>(p, MyCartSetCountryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartSetCountryActionQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<MyCartSetCountryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<MyCartSetCountryActionQueryBuilderDsl>(p, MyCartSetCountryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
