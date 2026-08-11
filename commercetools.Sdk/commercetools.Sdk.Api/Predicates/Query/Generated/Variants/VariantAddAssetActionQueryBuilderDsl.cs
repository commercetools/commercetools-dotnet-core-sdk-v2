using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantAddAssetActionQueryBuilderDsl
    {
        public VariantAddAssetActionQueryBuilderDsl()
        {
        }

        public static VariantAddAssetActionQueryBuilderDsl Of()
        {
            return new VariantAddAssetActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantAddAssetActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantAddAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantAddAssetActionQueryBuilderDsl>(p, VariantAddAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantAddAssetActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantAddAssetActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantAddAssetActionQueryBuilderDsl>(p, VariantAddAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantAddAssetActionQueryBuilderDsl> Asset(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantAddAssetActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("asset"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl.Of())),
                VariantAddAssetActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantAddAssetActionQueryBuilderDsl, long> Position()
        {
            return new ComparisonPredicateBuilder<VariantAddAssetActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("position")),
            p => new CombinationQueryPredicate<VariantAddAssetActionQueryBuilderDsl>(p, VariantAddAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
