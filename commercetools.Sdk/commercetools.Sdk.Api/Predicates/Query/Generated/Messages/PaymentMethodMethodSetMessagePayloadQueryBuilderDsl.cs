// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodMethodSetMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodMethodSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodMethodSetMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodMethodSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodMethodSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodMethodSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodMethodSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodMethodSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodMethodSetMessagePayloadQueryBuilderDsl, string> Method()
        {
            return new ComparisonPredicateBuilder<PaymentMethodMethodSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("method")),
            p => new CombinationQueryPredicate<PaymentMethodMethodSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodMethodSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodMethodSetMessagePayloadQueryBuilderDsl, string> OldMethod()
        {
            return new ComparisonPredicateBuilder<PaymentMethodMethodSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldMethod")),
            p => new CombinationQueryPredicate<PaymentMethodMethodSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodMethodSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
