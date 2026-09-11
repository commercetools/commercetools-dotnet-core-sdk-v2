using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class VariantImagesSetMessagePayloadQueryBuilderDsl
    {
        public VariantImagesSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static VariantImagesSetMessagePayloadQueryBuilderDsl Of()
        {
            return new VariantImagesSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantImagesSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<VariantImagesSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<VariantImagesSetMessagePayloadQueryBuilderDsl>(p, VariantImagesSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantImagesSetMessagePayloadQueryBuilderDsl> Images(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantImagesSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("images"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                VariantImagesSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantImagesSetMessagePayloadQueryBuilderDsl> Images()
        {
            return new CollectionPredicateBuilder<VariantImagesSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("images")),
                    p => new CombinationQueryPredicate<VariantImagesSetMessagePayloadQueryBuilderDsl>(p, VariantImagesSetMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<VariantImagesSetMessagePayloadQueryBuilderDsl> OldImages(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantImagesSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldImages"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                VariantImagesSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantImagesSetMessagePayloadQueryBuilderDsl> OldImages()
        {
            return new CollectionPredicateBuilder<VariantImagesSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldImages")),
                    p => new CombinationQueryPredicate<VariantImagesSetMessagePayloadQueryBuilderDsl>(p, VariantImagesSetMessagePayloadQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<VariantImagesSetMessagePayloadQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantImagesSetMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantImagesSetMessagePayloadQueryBuilderDsl>(p, VariantImagesSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
