// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentSetMethodInfoInterfaceActionQueryBuilderDsl
    {
        public PaymentSetMethodInfoInterfaceActionQueryBuilderDsl()
        {
        }

        public static PaymentSetMethodInfoInterfaceActionQueryBuilderDsl Of()
        {
            return new PaymentSetMethodInfoInterfaceActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentSetMethodInfoInterfaceActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentSetMethodInfoInterfaceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentSetMethodInfoInterfaceActionQueryBuilderDsl>(p, PaymentSetMethodInfoInterfaceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetMethodInfoInterfaceActionQueryBuilderDsl, string> Interface()
        {
            return new ComparisonPredicateBuilder<PaymentSetMethodInfoInterfaceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interface")),
            p => new CombinationQueryPredicate<PaymentSetMethodInfoInterfaceActionQueryBuilderDsl>(p, PaymentSetMethodInfoInterfaceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
