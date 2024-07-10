// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartSetLocaleActionQueryBuilderDsl
    {
        public MyCartSetLocaleActionQueryBuilderDsl()
        {
        }

        public static MyCartSetLocaleActionQueryBuilderDsl Of()
        {
            return new MyCartSetLocaleActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartSetLocaleActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartSetLocaleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartSetLocaleActionQueryBuilderDsl>(p, MyCartSetLocaleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartSetLocaleActionQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<MyCartSetLocaleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<MyCartSetLocaleActionQueryBuilderDsl>(p, MyCartSetLocaleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
