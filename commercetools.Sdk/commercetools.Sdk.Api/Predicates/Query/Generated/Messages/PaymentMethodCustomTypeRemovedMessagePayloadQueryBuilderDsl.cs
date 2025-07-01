// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodCustomTypeRemovedMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodCustomTypeRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodCustomTypeRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodCustomTypeRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodCustomTypeRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodCustomTypeRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodCustomTypeRemovedMessagePayloadQueryBuilderDsl>(p, PaymentMethodCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodCustomTypeRemovedMessagePayloadQueryBuilderDsl, string> OldTypeId()
        {
            return new ComparisonPredicateBuilder<PaymentMethodCustomTypeRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldTypeId")),
            p => new CombinationQueryPredicate<PaymentMethodCustomTypeRemovedMessagePayloadQueryBuilderDsl>(p, PaymentMethodCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
