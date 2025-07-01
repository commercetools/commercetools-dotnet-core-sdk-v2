// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodInfoCustomFieldRemovedMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodInfoCustomFieldRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodInfoCustomFieldRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodInfoCustomFieldRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodInfoCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodInfoCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, PaymentMethodInfoCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInfoCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<PaymentMethodInfoCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, PaymentMethodInfoCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
