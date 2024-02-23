using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Channels
{

    public partial class ChannelSetGeoLocationActionQueryBuilderDsl
    {
        public ChannelSetGeoLocationActionQueryBuilderDsl()
        {
        }

        public static ChannelSetGeoLocationActionQueryBuilderDsl Of()
        {
            return new ChannelSetGeoLocationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChannelSetGeoLocationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ChannelSetGeoLocationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ChannelSetGeoLocationActionQueryBuilderDsl>(p, ChannelSetGeoLocationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ChannelSetGeoLocationActionQueryBuilderDsl> GeoLocation(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.GeoJsonQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.GeoJsonQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelSetGeoLocationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("geoLocation"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.GeoJsonQueryBuilderDsl.Of())),
                ChannelSetGeoLocationActionQueryBuilderDsl.Of);
        }
        public GeoJsonPredicateBuilder<ChannelSetGeoLocationActionQueryBuilderDsl> GeoLocation()
        {
            return new GeoJsonPredicateBuilder<ChannelSetGeoLocationActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("geoLocation")),
                    p => new CombinationQueryPredicate<ChannelSetGeoLocationActionQueryBuilderDsl>(p, ChannelSetGeoLocationActionQueryBuilderDsl.Of));
        }

    }
}
