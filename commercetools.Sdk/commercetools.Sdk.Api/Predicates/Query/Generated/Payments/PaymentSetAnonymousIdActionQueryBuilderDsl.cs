// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentSetAnonymousIdActionQueryBuilderDsl
    {
        public PaymentSetAnonymousIdActionQueryBuilderDsl()
        {
        }

        public static PaymentSetAnonymousIdActionQueryBuilderDsl Of()
        {
            return new PaymentSetAnonymousIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentSetAnonymousIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentSetAnonymousIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentSetAnonymousIdActionQueryBuilderDsl>(p, PaymentSetAnonymousIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentSetAnonymousIdActionQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<PaymentSetAnonymousIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<PaymentSetAnonymousIdActionQueryBuilderDsl>(p, PaymentSetAnonymousIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
