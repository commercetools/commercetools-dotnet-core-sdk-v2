using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreCreatedMessagePayloadQueryBuilderDsl
    {
        public StoreCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl>(p, StoreCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                StoreCreatedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<StoreCreatedMessagePayloadQueryBuilderDsl, string> Languages()
        {
            return new ComparableCollectionPredicateBuilder<StoreCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("languages")),
            p => new CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl>(p, StoreCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl> Countries(
            Func<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("countries"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl.Of())),
                StoreCreatedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreCreatedMessagePayloadQueryBuilderDsl> Countries()
        {
            return new CollectionPredicateBuilder<StoreCreatedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("countries")),
                    p => new CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl>(p, StoreCreatedMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl> DistributionChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                StoreCreatedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreCreatedMessagePayloadQueryBuilderDsl> DistributionChannels()
        {
            return new CollectionPredicateBuilder<StoreCreatedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("distributionChannels")),
                    p => new CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl>(p, StoreCreatedMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl> SupplyChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                StoreCreatedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreCreatedMessagePayloadQueryBuilderDsl> SupplyChannels()
        {
            return new CollectionPredicateBuilder<StoreCreatedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("supplyChannels")),
                    p => new CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl>(p, StoreCreatedMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl> ProductSelections(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productSelections"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl.Of())),
                StoreCreatedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreCreatedMessagePayloadQueryBuilderDsl> ProductSelections()
        {
            return new CollectionPredicateBuilder<StoreCreatedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productSelections")),
                    p => new CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl>(p, StoreCreatedMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                StoreCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
