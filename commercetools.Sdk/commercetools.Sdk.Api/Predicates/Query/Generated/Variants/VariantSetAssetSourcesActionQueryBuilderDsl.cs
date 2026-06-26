using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantSetAssetSourcesActionQueryBuilderDsl
    {
        public VariantSetAssetSourcesActionQueryBuilderDsl()
        {
        }

        public static VariantSetAssetSourcesActionQueryBuilderDsl Of()
        {
            return new VariantSetAssetSourcesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantSetAssetSourcesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetSourcesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantSetAssetSourcesActionQueryBuilderDsl>(p, VariantSetAssetSourcesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAssetSourcesActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetSourcesActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantSetAssetSourcesActionQueryBuilderDsl>(p, VariantSetAssetSourcesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAssetSourcesActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetSourcesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<VariantSetAssetSourcesActionQueryBuilderDsl>(p, VariantSetAssetSourcesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAssetSourcesActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetSourcesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<VariantSetAssetSourcesActionQueryBuilderDsl>(p, VariantSetAssetSourcesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantSetAssetSourcesActionQueryBuilderDsl> Sources(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetSourceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetSourceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantSetAssetSourcesActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("sources"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetSourceQueryBuilderDsl.Of())),
                VariantSetAssetSourcesActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantSetAssetSourcesActionQueryBuilderDsl> Sources()
        {
            return new CollectionPredicateBuilder<VariantSetAssetSourcesActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sources")),
                    p => new CombinationQueryPredicate<VariantSetAssetSourcesActionQueryBuilderDsl>(p, VariantSetAssetSourcesActionQueryBuilderDsl.Of));
        }

    }
}
