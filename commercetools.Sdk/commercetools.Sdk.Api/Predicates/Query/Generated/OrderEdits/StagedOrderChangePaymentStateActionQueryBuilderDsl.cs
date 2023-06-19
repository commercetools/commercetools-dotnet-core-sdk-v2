// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderChangePaymentStateActionQueryBuilderDsl
    {
        public StagedOrderChangePaymentStateActionQueryBuilderDsl()
        {
        }

        public static StagedOrderChangePaymentStateActionQueryBuilderDsl Of()
        {
            return new StagedOrderChangePaymentStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderChangePaymentStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangePaymentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderChangePaymentStateActionQueryBuilderDsl>(p, StagedOrderChangePaymentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderChangePaymentStateActionQueryBuilderDsl, string> PaymentState()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangePaymentStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentState")),
            p => new CombinationQueryPredicate<StagedOrderChangePaymentStateActionQueryBuilderDsl>(p, StagedOrderChangePaymentStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
