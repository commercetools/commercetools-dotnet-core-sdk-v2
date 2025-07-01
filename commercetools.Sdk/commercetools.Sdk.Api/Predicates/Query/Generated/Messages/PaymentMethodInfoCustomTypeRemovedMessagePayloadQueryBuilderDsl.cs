// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodInfoCustomTypeRemovedMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodInfoCustomTypeRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodInfoCustomTypeRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodInfoCustomTypeRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodInfoCustomTypeRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoCustomTypeRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodInfoCustomTypeRemovedMessagePayloadQueryBuilderDsl>(p, PaymentMethodInfoCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInfoCustomTypeRemovedMessagePayloadQueryBuilderDsl, string> OldTypeId()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoCustomTypeRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldTypeId")),
            p => new CombinationQueryPredicate<PaymentMethodInfoCustomTypeRemovedMessagePayloadQueryBuilderDsl>(p, PaymentMethodInfoCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
