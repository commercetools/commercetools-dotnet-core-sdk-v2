// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetReturnPaymentStateActionQueryBuilderDsl
    {
        public OrderSetReturnPaymentStateActionQueryBuilderDsl()
        {
        }

        public static OrderSetReturnPaymentStateActionQueryBuilderDsl Of()
        {
            return new OrderSetReturnPaymentStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetReturnPaymentStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetReturnPaymentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetReturnPaymentStateActionQueryBuilderDsl>(p, OrderSetReturnPaymentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetReturnPaymentStateActionQueryBuilderDsl, string> ReturnItemId()
        {
            return new ComparisonPredicateBuilder<OrderSetReturnPaymentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnItemId")),
            p => new CombinationQueryPredicate<OrderSetReturnPaymentStateActionQueryBuilderDsl>(p, OrderSetReturnPaymentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetReturnPaymentStateActionQueryBuilderDsl, string> PaymentState()
        {
            return new ComparisonPredicateBuilder<OrderSetReturnPaymentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentState")),
            p => new CombinationQueryPredicate<OrderSetReturnPaymentStateActionQueryBuilderDsl>(p, OrderSetReturnPaymentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
