using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantSetAssetDescriptionActionQueryBuilderDsl
    {
        public VariantSetAssetDescriptionActionQueryBuilderDsl()
        {
        }

        public static VariantSetAssetDescriptionActionQueryBuilderDsl Of()
        {
            return new VariantSetAssetDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantSetAssetDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantSetAssetDescriptionActionQueryBuilderDsl>(p, VariantSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAssetDescriptionActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetDescriptionActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantSetAssetDescriptionActionQueryBuilderDsl>(p, VariantSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAssetDescriptionActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<VariantSetAssetDescriptionActionQueryBuilderDsl>(p, VariantSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAssetDescriptionActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<VariantSetAssetDescriptionActionQueryBuilderDsl>(p, VariantSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantSetAssetDescriptionActionQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantSetAssetDescriptionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                VariantSetAssetDescriptionActionQueryBuilderDsl.Of);
        }


    }
}
