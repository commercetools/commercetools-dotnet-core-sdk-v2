// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetPurchaseOrderNumberActionQueryBuilderDsl
    {
        public OrderSetPurchaseOrderNumberActionQueryBuilderDsl()
        {
        }

        public static OrderSetPurchaseOrderNumberActionQueryBuilderDsl Of()
        {
            return new OrderSetPurchaseOrderNumberActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetPurchaseOrderNumberActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetPurchaseOrderNumberActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetPurchaseOrderNumberActionQueryBuilderDsl>(p, OrderSetPurchaseOrderNumberActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetPurchaseOrderNumberActionQueryBuilderDsl, string> PurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<OrderSetPurchaseOrderNumberActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("purchaseOrderNumber")),
            p => new CombinationQueryPredicate<OrderSetPurchaseOrderNumberActionQueryBuilderDsl>(p, OrderSetPurchaseOrderNumberActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
