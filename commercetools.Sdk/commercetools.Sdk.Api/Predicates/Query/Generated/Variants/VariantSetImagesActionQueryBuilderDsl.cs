using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantSetImagesActionQueryBuilderDsl
    {
        public VariantSetImagesActionQueryBuilderDsl()
        {
        }

        public static VariantSetImagesActionQueryBuilderDsl Of()
        {
            return new VariantSetImagesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantSetImagesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantSetImagesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantSetImagesActionQueryBuilderDsl>(p, VariantSetImagesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantSetImagesActionQueryBuilderDsl> Images(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantSetImagesActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("images"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                VariantSetImagesActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantSetImagesActionQueryBuilderDsl> Images()
        {
            return new CollectionPredicateBuilder<VariantSetImagesActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("images")),
                    p => new CombinationQueryPredicate<VariantSetImagesActionQueryBuilderDsl>(p, VariantSetImagesActionQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<VariantSetImagesActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantSetImagesActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantSetImagesActionQueryBuilderDsl>(p, VariantSetImagesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
