using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodCustomTypeSetMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodCustomTypeSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodCustomTypeSetMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodCustomTypeSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodCustomTypeSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodCustomTypeSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodCustomTypeSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodCustomTypeSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodCustomTypeSetMessagePayloadQueryBuilderDsl> CustomFields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodCustomTypeSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customFields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                PaymentMethodCustomTypeSetMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentMethodCustomTypeSetMessagePayloadQueryBuilderDsl, string> OldTypeId()
        {
            return new ComparisonPredicateBuilder<PaymentMethodCustomTypeSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldTypeId")),
            p => new CombinationQueryPredicate<PaymentMethodCustomTypeSetMessagePayloadQueryBuilderDsl>(p, PaymentMethodCustomTypeSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
