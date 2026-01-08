// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetPurchaseOrderNumberActionQueryBuilderDsl
    {
        public CartSetPurchaseOrderNumberActionQueryBuilderDsl()
        {
        }

        public static CartSetPurchaseOrderNumberActionQueryBuilderDsl Of()
        {
            return new CartSetPurchaseOrderNumberActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetPurchaseOrderNumberActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetPurchaseOrderNumberActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetPurchaseOrderNumberActionQueryBuilderDsl>(p, CartSetPurchaseOrderNumberActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetPurchaseOrderNumberActionQueryBuilderDsl, string> PurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<CartSetPurchaseOrderNumberActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("purchaseOrderNumber")),
            p => new CombinationQueryPredicate<CartSetPurchaseOrderNumberActionQueryBuilderDsl>(p, CartSetPurchaseOrderNumberActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
