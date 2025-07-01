// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.PaymentMethods
{

    public partial class PaymentMethodSetMethodActionQueryBuilderDsl
    {
        public PaymentMethodSetMethodActionQueryBuilderDsl()
        {
        }

        public static PaymentMethodSetMethodActionQueryBuilderDsl Of()
        {
            return new PaymentMethodSetMethodActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodSetMethodActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentMethodSetMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentMethodSetMethodActionQueryBuilderDsl>(p, PaymentMethodSetMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodSetMethodActionQueryBuilderDsl, string> Method()
        {
            return new ComparisonPredicateBuilder<PaymentMethodSetMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("method")),
            p => new CombinationQueryPredicate<PaymentMethodSetMethodActionQueryBuilderDsl>(p, PaymentMethodSetMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
