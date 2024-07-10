// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartAddDiscountCodeActionQueryBuilderDsl
    {
        public CartAddDiscountCodeActionQueryBuilderDsl()
        {
        }

        public static CartAddDiscountCodeActionQueryBuilderDsl Of()
        {
            return new CartAddDiscountCodeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartAddDiscountCodeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartAddDiscountCodeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartAddDiscountCodeActionQueryBuilderDsl>(p, CartAddDiscountCodeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartAddDiscountCodeActionQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<CartAddDiscountCodeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<CartAddDiscountCodeActionQueryBuilderDsl>(p, CartAddDiscountCodeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
