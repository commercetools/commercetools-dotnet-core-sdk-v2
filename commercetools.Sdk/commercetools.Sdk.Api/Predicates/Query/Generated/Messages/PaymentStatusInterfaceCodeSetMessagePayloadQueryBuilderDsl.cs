// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentStatusInterfaceCodeSetMessagePayloadQueryBuilderDsl
    {
        public PaymentStatusInterfaceCodeSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentStatusInterfaceCodeSetMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentStatusInterfaceCodeSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessagePayloadQueryBuilderDsl>(p, PaymentStatusInterfaceCodeSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessagePayloadQueryBuilderDsl, string> InterfaceCode()
        {
            return new ComparisonPredicateBuilder<PaymentStatusInterfaceCodeSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceCode")),
            p => new CombinationQueryPredicate<PaymentStatusInterfaceCodeSetMessagePayloadQueryBuilderDsl>(p, PaymentStatusInterfaceCodeSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
