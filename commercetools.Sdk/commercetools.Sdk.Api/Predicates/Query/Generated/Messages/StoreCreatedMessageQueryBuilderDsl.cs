using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreCreatedMessageQueryBuilderDsl
    {
        public StoreCreatedMessageQueryBuilderDsl()
        {
        }

        public static StoreCreatedMessageQueryBuilderDsl Of()
        {
            return new StoreCreatedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(p, StoreCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(p, StoreCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(p, StoreCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(p, StoreCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StoreCreatedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StoreCreatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(p, StoreCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StoreCreatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(p, StoreCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(p, StoreCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StoreCreatedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                StoreCreatedMessageQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, string> Languages()
        {
            return new ComparableCollectionPredicateBuilder<StoreCreatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("languages")),
            p => new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(p, StoreCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl> Countries(
            Func<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("countries"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StoreCountries.StoreCountryQueryBuilderDsl.Of())),
                StoreCreatedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreCreatedMessageQueryBuilderDsl> Countries()
        {
            return new CollectionPredicateBuilder<StoreCreatedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("countries")),
                    p => new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(p, StoreCreatedMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl> DistributionChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                StoreCreatedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreCreatedMessageQueryBuilderDsl> DistributionChannels()
        {
            return new CollectionPredicateBuilder<StoreCreatedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("distributionChannels")),
                    p => new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(p, StoreCreatedMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl> SupplyChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                StoreCreatedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreCreatedMessageQueryBuilderDsl> SupplyChannels()
        {
            return new CollectionPredicateBuilder<StoreCreatedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("supplyChannels")),
                    p => new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(p, StoreCreatedMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl> ProductSelections(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productSelections"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.ProductSelectionSettingQueryBuilderDsl.Of())),
                StoreCreatedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreCreatedMessageQueryBuilderDsl> ProductSelections()
        {
            return new CollectionPredicateBuilder<StoreCreatedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productSelections")),
                    p => new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(p, StoreCreatedMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                StoreCreatedMessageQueryBuilderDsl.Of);
        }


    }
}
