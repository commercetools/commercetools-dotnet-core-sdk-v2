// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class TaxCategorySetKeyActionQueryBuilderDsl
    {
        public TaxCategorySetKeyActionQueryBuilderDsl()
        {
        }

        public static TaxCategorySetKeyActionQueryBuilderDsl Of()
        {
            return new TaxCategorySetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxCategorySetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TaxCategorySetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TaxCategorySetKeyActionQueryBuilderDsl>(p, TaxCategorySetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategorySetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<TaxCategorySetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<TaxCategorySetKeyActionQueryBuilderDsl>(p, TaxCategorySetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
