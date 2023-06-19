// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetCategoryOrderHintActionQueryBuilderDsl
    {
        public ProductSetCategoryOrderHintActionQueryBuilderDsl()
        {
        }

        public static ProductSetCategoryOrderHintActionQueryBuilderDsl Of()
        {
            return new ProductSetCategoryOrderHintActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetCategoryOrderHintActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetCategoryOrderHintActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetCategoryOrderHintActionQueryBuilderDsl>(p, ProductSetCategoryOrderHintActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetCategoryOrderHintActionQueryBuilderDsl, string> CategoryId()
        {
            return new ComparisonPredicateBuilder<ProductSetCategoryOrderHintActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("categoryId")),
            p => new CombinationQueryPredicate<ProductSetCategoryOrderHintActionQueryBuilderDsl>(p, ProductSetCategoryOrderHintActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetCategoryOrderHintActionQueryBuilderDsl, string> OrderHint()
        {
            return new ComparisonPredicateBuilder<ProductSetCategoryOrderHintActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderHint")),
            p => new CombinationQueryPredicate<ProductSetCategoryOrderHintActionQueryBuilderDsl>(p, ProductSetCategoryOrderHintActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetCategoryOrderHintActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetCategoryOrderHintActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetCategoryOrderHintActionQueryBuilderDsl>(p, ProductSetCategoryOrderHintActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
