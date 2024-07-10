// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentSetMethodInfoMethodActionQueryBuilderDsl
    {
        public PaymentSetMethodInfoMethodActionQueryBuilderDsl()
        {
        }

        public static PaymentSetMethodInfoMethodActionQueryBuilderDsl Of()
        {
            return new PaymentSetMethodInfoMethodActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentSetMethodInfoMethodActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentSetMethodInfoMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentSetMethodInfoMethodActionQueryBuilderDsl>(p, PaymentSetMethodInfoMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetMethodInfoMethodActionQueryBuilderDsl, string> Method()
        {
            return new ComparisonPredicateBuilder<PaymentSetMethodInfoMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("method")),
            p => new CombinationQueryPredicate<PaymentSetMethodInfoMethodActionQueryBuilderDsl>(p, PaymentSetMethodInfoMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
