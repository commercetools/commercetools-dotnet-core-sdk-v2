// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.PaymentMethods
{

    public partial class PaymentMethodSetKeyActionQueryBuilderDsl
    {
        public PaymentMethodSetKeyActionQueryBuilderDsl()
        {
        }

        public static PaymentMethodSetKeyActionQueryBuilderDsl Of()
        {
            return new PaymentMethodSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentMethodSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentMethodSetKeyActionQueryBuilderDsl>(p, PaymentMethodSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<PaymentMethodSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<PaymentMethodSetKeyActionQueryBuilderDsl>(p, PaymentMethodSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
