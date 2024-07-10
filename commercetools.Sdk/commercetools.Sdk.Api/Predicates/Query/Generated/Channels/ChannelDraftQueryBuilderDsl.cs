using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Channels
{

    public partial class ChannelDraftQueryBuilderDsl
    {
        public ChannelDraftQueryBuilderDsl()
        {
        }

        public static ChannelDraftQueryBuilderDsl Of()
        {
            return new ChannelDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChannelDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ChannelDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ChannelDraftQueryBuilderDsl>(p, ChannelDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ChannelDraftQueryBuilderDsl, string> Roles()
        {
            return new ComparableCollectionPredicateBuilder<ChannelDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("roles")),
            p => new CombinationQueryPredicate<ChannelDraftQueryBuilderDsl>(p, ChannelDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ChannelDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ChannelDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ChannelDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ChannelDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ChannelDraftQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                ChannelDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ChannelDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                ChannelDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ChannelDraftQueryBuilderDsl> GeoLocation(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.GeoJsonQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.GeoJsonQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("geoLocation"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.GeoJsonQueryBuilderDsl.Of())),
                ChannelDraftQueryBuilderDsl.Of);
        }
        public GeoJsonPredicateBuilder<ChannelDraftQueryBuilderDsl> GeoLocation()
        {
            return new GeoJsonPredicateBuilder<ChannelDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("geoLocation")),
                    p => new CombinationQueryPredicate<ChannelDraftQueryBuilderDsl>(p, ChannelDraftQueryBuilderDsl.Of));
        }

    }
}
