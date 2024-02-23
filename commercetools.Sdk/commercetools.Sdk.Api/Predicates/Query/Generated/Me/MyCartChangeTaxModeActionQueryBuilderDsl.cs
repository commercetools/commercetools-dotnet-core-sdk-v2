// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartChangeTaxModeActionQueryBuilderDsl
    {
        public MyCartChangeTaxModeActionQueryBuilderDsl()
        {
        }

        public static MyCartChangeTaxModeActionQueryBuilderDsl Of()
        {
            return new MyCartChangeTaxModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartChangeTaxModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartChangeTaxModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartChangeTaxModeActionQueryBuilderDsl>(p, MyCartChangeTaxModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartChangeTaxModeActionQueryBuilderDsl, string> TaxMode()
        {
            return new ComparisonPredicateBuilder<MyCartChangeTaxModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxMode")),
            p => new CombinationQueryPredicate<MyCartChangeTaxModeActionQueryBuilderDsl>(p, MyCartChangeTaxModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
