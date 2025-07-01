// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl, string> Method()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("method")),
            p => new CombinationQueryPredicate<PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl, string> OldMethod()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldMethod")),
            p => new CombinationQueryPredicate<PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodInfoMethodSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
