using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantDraftQueryBuilderDsl
    {
        public VariantDraftQueryBuilderDsl()
        {
        }

        public static VariantDraftQueryBuilderDsl Of()
        {
            return new VariantDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<VariantDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<VariantDraftQueryBuilderDsl>(p, VariantDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantDraftQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<VariantDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<VariantDraftQueryBuilderDsl>(p, VariantDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantDraftQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl.Of())),
                VariantDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantDraftQueryBuilderDsl, bool> Publish()
        {
            return new ComparisonPredicateBuilder<VariantDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("publish")),
            p => new CombinationQueryPredicate<VariantDraftQueryBuilderDsl>(p, VariantDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantDraftQueryBuilderDsl> Images(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("images"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                VariantDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantDraftQueryBuilderDsl> Images()
        {
            return new CollectionPredicateBuilder<VariantDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("images")),
                    p => new CombinationQueryPredicate<VariantDraftQueryBuilderDsl>(p, VariantDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<VariantDraftQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                VariantDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantDraftQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<VariantDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<VariantDraftQueryBuilderDsl>(p, VariantDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<VariantDraftQueryBuilderDsl> Assets(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("assets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl.Of())),
                VariantDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantDraftQueryBuilderDsl> Assets()
        {
            return new CollectionPredicateBuilder<VariantDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assets")),
                    p => new CombinationQueryPredicate<VariantDraftQueryBuilderDsl>(p, VariantDraftQueryBuilderDsl.Of));
        }

    }
}
