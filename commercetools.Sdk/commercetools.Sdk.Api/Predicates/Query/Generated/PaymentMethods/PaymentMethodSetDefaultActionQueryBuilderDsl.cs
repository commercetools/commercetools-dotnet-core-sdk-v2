// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.PaymentMethods
{

    public partial class PaymentMethodSetDefaultActionQueryBuilderDsl
    {
        public PaymentMethodSetDefaultActionQueryBuilderDsl()
        {
        }

        public static PaymentMethodSetDefaultActionQueryBuilderDsl Of()
        {
            return new PaymentMethodSetDefaultActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodSetDefaultActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentMethodSetDefaultActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentMethodSetDefaultActionQueryBuilderDsl>(p, PaymentMethodSetDefaultActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodSetDefaultActionQueryBuilderDsl, bool> Default()
        {
            return new ComparisonPredicateBuilder<PaymentMethodSetDefaultActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("default")),
            p => new CombinationQueryPredicate<PaymentMethodSetDefaultActionQueryBuilderDsl>(p, PaymentMethodSetDefaultActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
