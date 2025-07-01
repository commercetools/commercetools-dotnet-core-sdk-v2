// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl, string> InterfaceAccount()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceAccount")),
            p => new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl, string> OldInterfaceAccount()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldInterfaceAccount")),
            p => new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodInfoInterfaceAccountSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
