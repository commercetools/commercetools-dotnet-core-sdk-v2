using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantSetAssetsActionQueryBuilderDsl
    {
        public VariantSetAssetsActionQueryBuilderDsl()
        {
        }

        public static VariantSetAssetsActionQueryBuilderDsl Of()
        {
            return new VariantSetAssetsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantSetAssetsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantSetAssetsActionQueryBuilderDsl>(p, VariantSetAssetsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantSetAssetsActionQueryBuilderDsl> Assets(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantSetAssetsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("assets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl.Of())),
                VariantSetAssetsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantSetAssetsActionQueryBuilderDsl> Assets()
        {
            return new CollectionPredicateBuilder<VariantSetAssetsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assets")),
                    p => new CombinationQueryPredicate<VariantSetAssetsActionQueryBuilderDsl>(p, VariantSetAssetsActionQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<VariantSetAssetsActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantSetAssetsActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantSetAssetsActionQueryBuilderDsl>(p, VariantSetAssetsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
