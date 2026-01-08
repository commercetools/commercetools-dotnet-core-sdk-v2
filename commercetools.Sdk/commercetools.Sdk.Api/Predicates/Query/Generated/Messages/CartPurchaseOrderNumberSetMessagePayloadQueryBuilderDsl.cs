// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl
    {
        public CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl Of()
        {
            return new CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl>(p, CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl, string> PurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("purchaseOrderNumber")),
            p => new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl>(p, CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl, string> OldPurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldPurchaseOrderNumber")),
            p => new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl>(p, CartPurchaseOrderNumberSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
