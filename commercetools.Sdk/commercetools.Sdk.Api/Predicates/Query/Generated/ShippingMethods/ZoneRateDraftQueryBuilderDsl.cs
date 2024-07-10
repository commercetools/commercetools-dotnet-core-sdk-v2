using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ZoneRateDraftQueryBuilderDsl
    {
        public ZoneRateDraftQueryBuilderDsl()
        {
        }

        public static ZoneRateDraftQueryBuilderDsl Of()
        {
            return new ZoneRateDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ZoneRateDraftQueryBuilderDsl> Zone(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneRateDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("zone"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl.Of())),
                ZoneRateDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ZoneRateDraftQueryBuilderDsl> ShippingRates(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneRateDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl.Of())),
                ZoneRateDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ZoneRateDraftQueryBuilderDsl> ShippingRates()
        {
            return new CollectionPredicateBuilder<ZoneRateDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingRates")),
                    p => new CombinationQueryPredicate<ZoneRateDraftQueryBuilderDsl>(p, ZoneRateDraftQueryBuilderDsl.Of));
        }

    }
}
