// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentSetTransactionCustomFieldActionQueryBuilderDsl
    {
        public PaymentSetTransactionCustomFieldActionQueryBuilderDsl()
        {
        }

        public static PaymentSetTransactionCustomFieldActionQueryBuilderDsl Of()
        {
            return new PaymentSetTransactionCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentSetTransactionCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentSetTransactionCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentSetTransactionCustomFieldActionQueryBuilderDsl>(p, PaymentSetTransactionCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetTransactionCustomFieldActionQueryBuilderDsl, string> TransactionId()
        {
            return new ComparisonPredicateBuilder<PaymentSetTransactionCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transactionId")),
            p => new CombinationQueryPredicate<PaymentSetTransactionCustomFieldActionQueryBuilderDsl>(p, PaymentSetTransactionCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetTransactionCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<PaymentSetTransactionCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<PaymentSetTransactionCustomFieldActionQueryBuilderDsl>(p, PaymentSetTransactionCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetTransactionCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<PaymentSetTransactionCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<PaymentSetTransactionCustomFieldActionQueryBuilderDsl>(p, PaymentSetTransactionCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
