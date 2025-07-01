// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl
    {
        public PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl>(p, PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl, string> InterfaceId()
        {
            return new ComparisonPredicateBuilder<PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceId")),
            p => new CombinationQueryPredicate<PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl>(p, PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl, string> OldInterfaceId()
        {
            return new ComparisonPredicateBuilder<PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldInterfaceId")),
            p => new CombinationQueryPredicate<PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl>(p, PaymentInterfaceIdSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
