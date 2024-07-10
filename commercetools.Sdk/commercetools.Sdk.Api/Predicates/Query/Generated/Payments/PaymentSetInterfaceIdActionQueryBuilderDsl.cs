// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentSetInterfaceIdActionQueryBuilderDsl
    {
        public PaymentSetInterfaceIdActionQueryBuilderDsl()
        {
        }

        public static PaymentSetInterfaceIdActionQueryBuilderDsl Of()
        {
            return new PaymentSetInterfaceIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentSetInterfaceIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentSetInterfaceIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentSetInterfaceIdActionQueryBuilderDsl>(p, PaymentSetInterfaceIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetInterfaceIdActionQueryBuilderDsl, string> InterfaceId()
        {
            return new ComparisonPredicateBuilder<PaymentSetInterfaceIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceId")),
            p => new CombinationQueryPredicate<PaymentSetInterfaceIdActionQueryBuilderDsl>(p, PaymentSetInterfaceIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
