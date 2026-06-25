// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CartUnlockedMessagePayloadQueryBuilderDsl
    {
        public CartUnlockedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CartUnlockedMessagePayloadQueryBuilderDsl Of()
        {
            return new CartUnlockedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartUnlockedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartUnlockedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartUnlockedMessagePayloadQueryBuilderDsl>(p, CartUnlockedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
