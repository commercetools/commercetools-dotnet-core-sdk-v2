// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodCustomFieldRemovedMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodCustomFieldRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodCustomFieldRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodCustomFieldRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, PaymentMethodCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<PaymentMethodCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<PaymentMethodCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, PaymentMethodCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
