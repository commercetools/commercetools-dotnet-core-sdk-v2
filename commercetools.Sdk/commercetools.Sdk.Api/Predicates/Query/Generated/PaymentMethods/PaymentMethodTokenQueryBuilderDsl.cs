// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.PaymentMethods
{

    public partial class PaymentMethodTokenQueryBuilderDsl
    {
        public PaymentMethodTokenQueryBuilderDsl()
        {
        }

        public static PaymentMethodTokenQueryBuilderDsl Of()
        {
            return new PaymentMethodTokenQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodTokenQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<PaymentMethodTokenQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<PaymentMethodTokenQueryBuilderDsl>(p, PaymentMethodTokenQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
