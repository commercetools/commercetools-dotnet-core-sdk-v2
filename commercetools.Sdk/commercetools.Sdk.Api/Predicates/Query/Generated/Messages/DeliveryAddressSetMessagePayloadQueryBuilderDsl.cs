using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DeliveryAddressSetMessagePayloadQueryBuilderDsl
    {
        public DeliveryAddressSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static DeliveryAddressSetMessagePayloadQueryBuilderDsl Of()
        {
            return new DeliveryAddressSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DeliveryAddressSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DeliveryAddressSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DeliveryAddressSetMessagePayloadQueryBuilderDsl>(p, DeliveryAddressSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryAddressSetMessagePayloadQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<DeliveryAddressSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<DeliveryAddressSetMessagePayloadQueryBuilderDsl>(p, DeliveryAddressSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DeliveryAddressSetMessagePayloadQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryAddressSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                DeliveryAddressSetMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DeliveryAddressSetMessagePayloadQueryBuilderDsl> OldAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryAddressSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                DeliveryAddressSetMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DeliveryAddressSetMessagePayloadQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<DeliveryAddressSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<DeliveryAddressSetMessagePayloadQueryBuilderDsl>(p, DeliveryAddressSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
