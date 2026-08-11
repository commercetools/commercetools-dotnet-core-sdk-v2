using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantChangeAssetNameActionQueryBuilderDsl
    {
        public VariantChangeAssetNameActionQueryBuilderDsl()
        {
        }

        public static VariantChangeAssetNameActionQueryBuilderDsl Of()
        {
            return new VariantChangeAssetNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantChangeAssetNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantChangeAssetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantChangeAssetNameActionQueryBuilderDsl>(p, VariantChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantChangeAssetNameActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantChangeAssetNameActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantChangeAssetNameActionQueryBuilderDsl>(p, VariantChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantChangeAssetNameActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<VariantChangeAssetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<VariantChangeAssetNameActionQueryBuilderDsl>(p, VariantChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantChangeAssetNameActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<VariantChangeAssetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<VariantChangeAssetNameActionQueryBuilderDsl>(p, VariantChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantChangeAssetNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantChangeAssetNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                VariantChangeAssetNameActionQueryBuilderDsl.Of);
        }


    }
}
