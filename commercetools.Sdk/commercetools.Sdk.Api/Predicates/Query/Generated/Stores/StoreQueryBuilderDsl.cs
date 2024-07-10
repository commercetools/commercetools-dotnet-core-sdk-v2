using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreQueryBuilderDsl
    {
        public StoreQueryBuilderDsl()
        {
        }

        public static StoreQueryBuilderDsl Of()
        {
            return new StoreQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StoreQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StoreQueryBuilderDsl>(p, StoreQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StoreQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StoreQueryBuilderDsl>(p, StoreQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StoreQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StoreQueryBuilderDsl>(p, StoreQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StoreQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StoreQueryBuilderDsl>(p, StoreQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StoreQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StoreQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StoreQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<StoreQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<StoreQueryBuilderDsl>(p, StoreQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                StoreQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<StoreQueryBuilderDsl, string> Languages()
        {
            return new ComparableCollectionPredicateBuilder<StoreQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("languages")),
            p => new CombinationQueryPredicate<StoreQueryBuilderDsl>(p, StoreQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreQueryBuilderDsl> Countries(
            Func<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("countries"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl.Of())),
                StoreQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreQueryBuilderDsl> Countries()
        {
            return new CollectionPredicateBuilder<StoreQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("countries")),
                    p => new CombinationQueryPredicate<StoreQueryBuilderDsl>(p, StoreQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreQueryBuilderDsl> DistributionChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                StoreQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreQueryBuilderDsl> DistributionChannels()
        {
            return new CollectionPredicateBuilder<StoreQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("distributionChannels")),
                    p => new CombinationQueryPredicate<StoreQueryBuilderDsl>(p, StoreQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreQueryBuilderDsl> SupplyChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                StoreQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreQueryBuilderDsl> SupplyChannels()
        {
            return new CollectionPredicateBuilder<StoreQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("supplyChannels")),
                    p => new CombinationQueryPredicate<StoreQueryBuilderDsl>(p, StoreQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreQueryBuilderDsl> ProductSelections(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productSelections"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl.Of())),
                StoreQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreQueryBuilderDsl> ProductSelections()
        {
            return new CollectionPredicateBuilder<StoreQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productSelections")),
                    p => new CombinationQueryPredicate<StoreQueryBuilderDsl>(p, StoreQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                StoreQueryBuilderDsl.Of);
        }


    }
}
