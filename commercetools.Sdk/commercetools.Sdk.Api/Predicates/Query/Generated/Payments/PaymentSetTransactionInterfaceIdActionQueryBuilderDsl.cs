// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentSetTransactionInterfaceIdActionQueryBuilderDsl
    {
        public PaymentSetTransactionInterfaceIdActionQueryBuilderDsl()
        {
        }

        public static PaymentSetTransactionInterfaceIdActionQueryBuilderDsl Of()
        {
            return new PaymentSetTransactionInterfaceIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentSetTransactionInterfaceIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentSetTransactionInterfaceIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentSetTransactionInterfaceIdActionQueryBuilderDsl>(p, PaymentSetTransactionInterfaceIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetTransactionInterfaceIdActionQueryBuilderDsl, string> TransactionId()
        {
            return new ComparisonPredicateBuilder<PaymentSetTransactionInterfaceIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transactionId")),
            p => new CombinationQueryPredicate<PaymentSetTransactionInterfaceIdActionQueryBuilderDsl>(p, PaymentSetTransactionInterfaceIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetTransactionInterfaceIdActionQueryBuilderDsl, string> InterfaceId()
        {
            return new ComparisonPredicateBuilder<PaymentSetTransactionInterfaceIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceId")),
            p => new CombinationQueryPredicate<PaymentSetTransactionInterfaceIdActionQueryBuilderDsl>(p, PaymentSetTransactionInterfaceIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
