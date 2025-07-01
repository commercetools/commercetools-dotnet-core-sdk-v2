// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl, string> Interface()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interface")),
            p => new CombinationQueryPredicate<PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl, string> OldInterface()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldInterface")),
            p => new CombinationQueryPredicate<PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodInfoInterfaceSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
