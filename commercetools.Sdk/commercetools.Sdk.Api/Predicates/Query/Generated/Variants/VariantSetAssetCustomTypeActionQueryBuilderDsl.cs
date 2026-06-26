using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantSetAssetCustomTypeActionQueryBuilderDsl
    {
        public VariantSetAssetCustomTypeActionQueryBuilderDsl()
        {
        }

        public static VariantSetAssetCustomTypeActionQueryBuilderDsl Of()
        {
            return new VariantSetAssetCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantSetAssetCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantSetAssetCustomTypeActionQueryBuilderDsl>(p, VariantSetAssetCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAssetCustomTypeActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetCustomTypeActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantSetAssetCustomTypeActionQueryBuilderDsl>(p, VariantSetAssetCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAssetCustomTypeActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<VariantSetAssetCustomTypeActionQueryBuilderDsl>(p, VariantSetAssetCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAssetCustomTypeActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<VariantSetAssetCustomTypeActionQueryBuilderDsl>(p, VariantSetAssetCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantSetAssetCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantSetAssetCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                VariantSetAssetCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<VariantSetAssetCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantSetAssetCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                VariantSetAssetCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
