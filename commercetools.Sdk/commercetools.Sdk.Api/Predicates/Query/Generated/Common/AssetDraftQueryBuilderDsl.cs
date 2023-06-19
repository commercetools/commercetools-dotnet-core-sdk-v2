using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class AssetDraftQueryBuilderDsl
    {
        public AssetDraftQueryBuilderDsl()
        {
        }

        public static AssetDraftQueryBuilderDsl Of()
        {
            return new AssetDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<AssetDraftQueryBuilderDsl> Sources(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetSourceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetSourceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssetDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("sources"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetSourceQueryBuilderDsl.Of())),
                AssetDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AssetDraftQueryBuilderDsl> Sources()
        {
            return new CollectionPredicateBuilder<AssetDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sources")),
                    p => new CombinationQueryPredicate<AssetDraftQueryBuilderDsl>(p, AssetDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<AssetDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssetDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                AssetDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AssetDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssetDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                AssetDraftQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<AssetDraftQueryBuilderDsl, string> Tags()
        {
            return new ComparableCollectionPredicateBuilder<AssetDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tags")),
            p => new CombinationQueryPredicate<AssetDraftQueryBuilderDsl>(p, AssetDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssetDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssetDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                AssetDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssetDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AssetDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AssetDraftQueryBuilderDsl>(p, AssetDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
