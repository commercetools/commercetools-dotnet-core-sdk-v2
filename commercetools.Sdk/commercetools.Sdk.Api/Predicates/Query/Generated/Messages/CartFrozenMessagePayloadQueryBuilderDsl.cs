// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CartFrozenMessagePayloadQueryBuilderDsl
    {
        public CartFrozenMessagePayloadQueryBuilderDsl()
        {
        }

        public static CartFrozenMessagePayloadQueryBuilderDsl Of()
        {
            return new CartFrozenMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartFrozenMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartFrozenMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartFrozenMessagePayloadQueryBuilderDsl>(p, CartFrozenMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
