// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartUnfreezeCartActionQueryBuilderDsl
    {
        public CartUnfreezeCartActionQueryBuilderDsl()
        {
        }

        public static CartUnfreezeCartActionQueryBuilderDsl Of()
        {
            return new CartUnfreezeCartActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartUnfreezeCartActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartUnfreezeCartActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartUnfreezeCartActionQueryBuilderDsl>(p, CartUnfreezeCartActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
