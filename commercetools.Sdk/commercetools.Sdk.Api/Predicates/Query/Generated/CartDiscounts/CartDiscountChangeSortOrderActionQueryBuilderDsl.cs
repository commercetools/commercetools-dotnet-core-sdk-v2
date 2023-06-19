// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountChangeSortOrderActionQueryBuilderDsl
    {
        public CartDiscountChangeSortOrderActionQueryBuilderDsl()
        {
        }

        public static CartDiscountChangeSortOrderActionQueryBuilderDsl Of()
        {
            return new CartDiscountChangeSortOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountChangeSortOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountChangeSortOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountChangeSortOrderActionQueryBuilderDsl>(p, CartDiscountChangeSortOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountChangeSortOrderActionQueryBuilderDsl, string> SortOrder()
        {
            return new ComparisonPredicateBuilder<CartDiscountChangeSortOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sortOrder")),
            p => new CombinationQueryPredicate<CartDiscountChangeSortOrderActionQueryBuilderDsl>(p, CartDiscountChangeSortOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
