// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountChangeSortOrderActionQueryBuilderDsl
    {
        public ProductDiscountChangeSortOrderActionQueryBuilderDsl()
        {
        }

        public static ProductDiscountChangeSortOrderActionQueryBuilderDsl Of()
        {
            return new ProductDiscountChangeSortOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountChangeSortOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductDiscountChangeSortOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductDiscountChangeSortOrderActionQueryBuilderDsl>(p, ProductDiscountChangeSortOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountChangeSortOrderActionQueryBuilderDsl, string> SortOrder()
        {
            return new ComparisonPredicateBuilder<ProductDiscountChangeSortOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sortOrder")),
            p => new CombinationQueryPredicate<ProductDiscountChangeSortOrderActionQueryBuilderDsl>(p, ProductDiscountChangeSortOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
