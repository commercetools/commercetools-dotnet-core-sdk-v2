using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreDraftQueryBuilderDsl
    {
        public StoreDraftQueryBuilderDsl()
        {
        }

        public static StoreDraftQueryBuilderDsl Of()
        {
            return new StoreDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<StoreDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<StoreDraftQueryBuilderDsl>(p, StoreDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                StoreDraftQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<StoreDraftQueryBuilderDsl, string> Languages()
        {
            return new ComparableCollectionPredicateBuilder<StoreDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("languages")),
            p => new CombinationQueryPredicate<StoreDraftQueryBuilderDsl>(p, StoreDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreDraftQueryBuilderDsl> Countries(
            Func<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("countries"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl.Of())),
                StoreDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreDraftQueryBuilderDsl> Countries()
        {
            return new CollectionPredicateBuilder<StoreDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("countries")),
                    p => new CombinationQueryPredicate<StoreDraftQueryBuilderDsl>(p, StoreDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreDraftQueryBuilderDsl> DistributionChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                StoreDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreDraftQueryBuilderDsl> DistributionChannels()
        {
            return new CollectionPredicateBuilder<StoreDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("distributionChannels")),
                    p => new CombinationQueryPredicate<StoreDraftQueryBuilderDsl>(p, StoreDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreDraftQueryBuilderDsl> SupplyChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                StoreDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreDraftQueryBuilderDsl> SupplyChannels()
        {
            return new CollectionPredicateBuilder<StoreDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("supplyChannels")),
                    p => new CombinationQueryPredicate<StoreDraftQueryBuilderDsl>(p, StoreDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreDraftQueryBuilderDsl> ProductSelections(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productSelections"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingDraftQueryBuilderDsl.Of())),
                StoreDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreDraftQueryBuilderDsl> ProductSelections()
        {
            return new CollectionPredicateBuilder<StoreDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productSelections")),
                    p => new CombinationQueryPredicate<StoreDraftQueryBuilderDsl>(p, StoreDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                StoreDraftQueryBuilderDsl.Of);
        }


    }
}
