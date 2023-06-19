// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartChangeCustomLineItemPriceModeActionQueryBuilderDsl
    {
        public CartChangeCustomLineItemPriceModeActionQueryBuilderDsl()
        {
        }

        public static CartChangeCustomLineItemPriceModeActionQueryBuilderDsl Of()
        {
            return new CartChangeCustomLineItemPriceModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartChangeCustomLineItemPriceModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartChangeCustomLineItemPriceModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartChangeCustomLineItemPriceModeActionQueryBuilderDsl>(p, CartChangeCustomLineItemPriceModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartChangeCustomLineItemPriceModeActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<CartChangeCustomLineItemPriceModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<CartChangeCustomLineItemPriceModeActionQueryBuilderDsl>(p, CartChangeCustomLineItemPriceModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartChangeCustomLineItemPriceModeActionQueryBuilderDsl, string> Mode()
        {
            return new ComparisonPredicateBuilder<CartChangeCustomLineItemPriceModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mode")),
            p => new CombinationQueryPredicate<CartChangeCustomLineItemPriceModeActionQueryBuilderDsl>(p, CartChangeCustomLineItemPriceModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
