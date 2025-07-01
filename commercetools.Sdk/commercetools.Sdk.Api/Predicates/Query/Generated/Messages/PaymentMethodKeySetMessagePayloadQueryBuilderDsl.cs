// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodKeySetMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodKeySetMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodKeySetMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodKeySetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodKeySetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodKeySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodKeySetMessagePayloadQueryBuilderDsl>(p, PaymentMethodKeySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodKeySetMessagePayloadQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<PaymentMethodKeySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<PaymentMethodKeySetMessagePayloadQueryBuilderDsl>(p, PaymentMethodKeySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodKeySetMessagePayloadQueryBuilderDsl, string> OldKey()
        {
            return new ComparisonPredicateBuilder<PaymentMethodKeySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldKey")),
            p => new CombinationQueryPredicate<PaymentMethodKeySetMessagePayloadQueryBuilderDsl>(p, PaymentMethodKeySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
