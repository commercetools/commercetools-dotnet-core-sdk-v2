// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryChangeOrderHintActionQueryBuilderDsl
    {
        public CategoryChangeOrderHintActionQueryBuilderDsl()
        {
        }

        public static CategoryChangeOrderHintActionQueryBuilderDsl Of()
        {
            return new CategoryChangeOrderHintActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryChangeOrderHintActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategoryChangeOrderHintActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategoryChangeOrderHintActionQueryBuilderDsl>(p, CategoryChangeOrderHintActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategoryChangeOrderHintActionQueryBuilderDsl, string> OrderHint()
        {
            return new ComparisonPredicateBuilder<CategoryChangeOrderHintActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderHint")),
            p => new CombinationQueryPredicate<CategoryChangeOrderHintActionQueryBuilderDsl>(p, CategoryChangeOrderHintActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
