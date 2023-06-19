// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartRemoveCustomLineItemActionQueryBuilderDsl
    {
        public CartRemoveCustomLineItemActionQueryBuilderDsl()
        {
        }

        public static CartRemoveCustomLineItemActionQueryBuilderDsl Of()
        {
            return new CartRemoveCustomLineItemActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartRemoveCustomLineItemActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartRemoveCustomLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartRemoveCustomLineItemActionQueryBuilderDsl>(p, CartRemoveCustomLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartRemoveCustomLineItemActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<CartRemoveCustomLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<CartRemoveCustomLineItemActionQueryBuilderDsl>(p, CartRemoveCustomLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
