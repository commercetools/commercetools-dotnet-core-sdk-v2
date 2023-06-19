// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountCustomLineItemsTargetQueryBuilderDsl
    {
        public CartDiscountCustomLineItemsTargetQueryBuilderDsl()
        {
        }

        public static CartDiscountCustomLineItemsTargetQueryBuilderDsl Of()
        {
            return new CartDiscountCustomLineItemsTargetQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountCustomLineItemsTargetQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountCustomLineItemsTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountCustomLineItemsTargetQueryBuilderDsl>(p, CartDiscountCustomLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountCustomLineItemsTargetQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<CartDiscountCustomLineItemsTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<CartDiscountCustomLineItemsTargetQueryBuilderDsl>(p, CartDiscountCustomLineItemsTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
