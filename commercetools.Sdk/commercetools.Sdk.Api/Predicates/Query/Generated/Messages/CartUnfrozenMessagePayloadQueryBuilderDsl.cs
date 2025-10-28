// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CartUnfrozenMessagePayloadQueryBuilderDsl
    {
        public CartUnfrozenMessagePayloadQueryBuilderDsl()
        {
        }

        public static CartUnfrozenMessagePayloadQueryBuilderDsl Of()
        {
            return new CartUnfrozenMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartUnfrozenMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartUnfrozenMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartUnfrozenMessagePayloadQueryBuilderDsl>(p, CartUnfrozenMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
