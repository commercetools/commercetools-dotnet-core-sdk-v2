using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Channels
{

    public partial class ChannelQueryBuilderDsl
    {
        public ChannelQueryBuilderDsl()
        {
        }

        public static ChannelQueryBuilderDsl Of()
        {
            return new ChannelQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChannelQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ChannelQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ChannelQueryBuilderDsl>(p, ChannelQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ChannelQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ChannelQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ChannelQueryBuilderDsl>(p, ChannelQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ChannelQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ChannelQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ChannelQueryBuilderDsl>(p, ChannelQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ChannelQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ChannelQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ChannelQueryBuilderDsl>(p, ChannelQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ChannelQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ChannelQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ChannelQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ChannelQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ChannelQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ChannelQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ChannelQueryBuilderDsl>(p, ChannelQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ChannelQueryBuilderDsl, string> Roles()
        {
            return new ComparableCollectionPredicateBuilder<ChannelQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("roles")),
            p => new CombinationQueryPredicate<ChannelQueryBuilderDsl>(p, ChannelQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ChannelQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ChannelQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ChannelQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ChannelQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ChannelQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                ChannelQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ChannelQueryBuilderDsl> ReviewRatingStatistics(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewRatingStatisticsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewRatingStatisticsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("reviewRatingStatistics"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewRatingStatisticsQueryBuilderDsl.Of())),
                ChannelQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ChannelQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                ChannelQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ChannelQueryBuilderDsl> GeoLocation(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.GeoJsonQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.GeoJsonQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ChannelQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("geoLocation"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.GeoJsonQueryBuilderDsl.Of())),
                ChannelQueryBuilderDsl.Of);
        }
        public GeoJsonPredicateBuilder<ChannelQueryBuilderDsl> GeoLocation()
        {
            return new GeoJsonPredicateBuilder<ChannelQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("geoLocation")),
                    p => new CombinationQueryPredicate<ChannelQueryBuilderDsl>(p, ChannelQueryBuilderDsl.Of));
        }

    }
}
