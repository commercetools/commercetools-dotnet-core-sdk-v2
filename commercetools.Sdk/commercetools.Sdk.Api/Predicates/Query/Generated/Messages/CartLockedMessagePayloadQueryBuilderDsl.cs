// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CartLockedMessagePayloadQueryBuilderDsl
    {
        public CartLockedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CartLockedMessagePayloadQueryBuilderDsl Of()
        {
            return new CartLockedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartLockedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartLockedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartLockedMessagePayloadQueryBuilderDsl>(p, CartLockedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
