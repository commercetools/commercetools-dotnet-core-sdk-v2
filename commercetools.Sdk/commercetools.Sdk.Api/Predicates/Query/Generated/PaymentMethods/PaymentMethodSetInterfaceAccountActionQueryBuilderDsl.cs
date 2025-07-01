// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.PaymentMethods
{

    public partial class PaymentMethodSetInterfaceAccountActionQueryBuilderDsl
    {
        public PaymentMethodSetInterfaceAccountActionQueryBuilderDsl()
        {
        }

        public static PaymentMethodSetInterfaceAccountActionQueryBuilderDsl Of()
        {
            return new PaymentMethodSetInterfaceAccountActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodSetInterfaceAccountActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentMethodSetInterfaceAccountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentMethodSetInterfaceAccountActionQueryBuilderDsl>(p, PaymentMethodSetInterfaceAccountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodSetInterfaceAccountActionQueryBuilderDsl, string> InterfaceAccount()
        {
            return new ComparisonPredicateBuilder<PaymentMethodSetInterfaceAccountActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceAccount")),
            p => new CombinationQueryPredicate<PaymentMethodSetInterfaceAccountActionQueryBuilderDsl>(p, PaymentMethodSetInterfaceAccountActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
