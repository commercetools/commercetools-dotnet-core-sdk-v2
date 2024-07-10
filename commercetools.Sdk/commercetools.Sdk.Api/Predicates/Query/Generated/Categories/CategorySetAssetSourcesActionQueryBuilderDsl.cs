using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategorySetAssetSourcesActionQueryBuilderDsl
    {
        public CategorySetAssetSourcesActionQueryBuilderDsl()
        {
        }

        public static CategorySetAssetSourcesActionQueryBuilderDsl Of()
        {
            return new CategorySetAssetSourcesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategorySetAssetSourcesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetSourcesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategorySetAssetSourcesActionQueryBuilderDsl>(p, CategorySetAssetSourcesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetAssetSourcesActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetSourcesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<CategorySetAssetSourcesActionQueryBuilderDsl>(p, CategorySetAssetSourcesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetAssetSourcesActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetSourcesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<CategorySetAssetSourcesActionQueryBuilderDsl>(p, CategorySetAssetSourcesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategorySetAssetSourcesActionQueryBuilderDsl> Sources(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetSourceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetSourceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategorySetAssetSourcesActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("sources"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetSourceQueryBuilderDsl.Of())),
                CategorySetAssetSourcesActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CategorySetAssetSourcesActionQueryBuilderDsl> Sources()
        {
            return new CollectionPredicateBuilder<CategorySetAssetSourcesActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sources")),
                    p => new CombinationQueryPredicate<CategorySetAssetSourcesActionQueryBuilderDsl>(p, CategorySetAssetSourcesActionQueryBuilderDsl.Of));
        }

    }
}
