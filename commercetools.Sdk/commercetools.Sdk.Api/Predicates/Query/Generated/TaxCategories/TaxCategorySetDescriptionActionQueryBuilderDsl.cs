// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class TaxCategorySetDescriptionActionQueryBuilderDsl
    {
        public TaxCategorySetDescriptionActionQueryBuilderDsl()
        {
        }

        public static TaxCategorySetDescriptionActionQueryBuilderDsl Of()
        {
            return new TaxCategorySetDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxCategorySetDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TaxCategorySetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TaxCategorySetDescriptionActionQueryBuilderDsl>(p, TaxCategorySetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategorySetDescriptionActionQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<TaxCategorySetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<TaxCategorySetDescriptionActionQueryBuilderDsl>(p, TaxCategorySetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
