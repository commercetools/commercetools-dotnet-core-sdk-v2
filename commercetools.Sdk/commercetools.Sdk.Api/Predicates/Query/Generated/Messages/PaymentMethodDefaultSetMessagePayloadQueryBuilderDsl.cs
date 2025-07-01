// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl, bool> Default()
        {
            return new ComparisonPredicateBuilder<PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("default")),
            p => new CombinationQueryPredicate<PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl, bool> OldDefault()
        {
            return new ComparisonPredicateBuilder<PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldDefault")),
            p => new CombinationQueryPredicate<PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodDefaultSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
