// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CartDiscountDeletedMessagePayloadQueryBuilderDsl
    {
        public CartDiscountDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CartDiscountDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new CartDiscountDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountDeletedMessagePayloadQueryBuilderDsl>(p, CartDiscountDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
