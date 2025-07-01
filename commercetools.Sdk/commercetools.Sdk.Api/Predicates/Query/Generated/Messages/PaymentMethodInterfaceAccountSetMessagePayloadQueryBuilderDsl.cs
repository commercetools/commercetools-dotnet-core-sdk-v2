// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl, string> InterfaceAccount()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceAccount")),
            p => new CombinationQueryPredicate<PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl, string> OldInterfaceAccount()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldInterfaceAccount")),
            p => new CombinationQueryPredicate<PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodInterfaceAccountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
