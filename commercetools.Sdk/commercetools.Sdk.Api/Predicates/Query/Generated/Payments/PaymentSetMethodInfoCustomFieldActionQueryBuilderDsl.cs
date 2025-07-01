// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl
    {
        public PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl()
        {
        }

        public static PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl Of()
        {
            return new PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl>(p, PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl>(p, PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl>(p, PaymentSetMethodInfoCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
