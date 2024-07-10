using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ZoneRateQueryBuilderDsl
    {
        public ZoneRateQueryBuilderDsl()
        {
        }

        public static ZoneRateQueryBuilderDsl Of()
        {
            return new ZoneRateQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ZoneRateQueryBuilderDsl> Zone(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneRateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("zone"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneReferenceQueryBuilderDsl.Of())),
                ZoneRateQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ZoneRateQueryBuilderDsl> ShippingRates(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneRateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateQueryBuilderDsl.Of())),
                ZoneRateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ZoneRateQueryBuilderDsl> ShippingRates()
        {
            return new CollectionPredicateBuilder<ZoneRateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingRates")),
                    p => new CombinationQueryPredicate<ZoneRateQueryBuilderDsl>(p, ZoneRateQueryBuilderDsl.Of));
        }

    }
}
