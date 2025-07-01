// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.PaymentMethods
{

    public partial class PaymentMethodSetCustomFieldActionQueryBuilderDsl
    {
        public PaymentMethodSetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static PaymentMethodSetCustomFieldActionQueryBuilderDsl Of()
        {
            return new PaymentMethodSetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodSetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentMethodSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentMethodSetCustomFieldActionQueryBuilderDsl>(p, PaymentMethodSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodSetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<PaymentMethodSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<PaymentMethodSetCustomFieldActionQueryBuilderDsl>(p, PaymentMethodSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodSetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<PaymentMethodSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<PaymentMethodSetCustomFieldActionQueryBuilderDsl>(p, PaymentMethodSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
