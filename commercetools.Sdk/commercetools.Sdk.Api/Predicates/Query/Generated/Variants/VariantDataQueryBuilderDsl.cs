using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantDataQueryBuilderDsl
    {
        public VariantDataQueryBuilderDsl()
        {
        }

        public static VariantDataQueryBuilderDsl Of()
        {
            return new VariantDataQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantDataQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<VariantDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<VariantDataQueryBuilderDsl>(p, VariantDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantDataQueryBuilderDsl> Images(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("images"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                VariantDataQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantDataQueryBuilderDsl> Images()
        {
            return new CollectionPredicateBuilder<VariantDataQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("images")),
                    p => new CombinationQueryPredicate<VariantDataQueryBuilderDsl>(p, VariantDataQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<VariantDataQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                VariantDataQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantDataQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<VariantDataQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<VariantDataQueryBuilderDsl>(p, VariantDataQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<VariantDataQueryBuilderDsl> Assets(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("assets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl.Of())),
                VariantDataQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantDataQueryBuilderDsl> Assets()
        {
            return new CollectionPredicateBuilder<VariantDataQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assets")),
                    p => new CombinationQueryPredicate<VariantDataQueryBuilderDsl>(p, VariantDataQueryBuilderDsl.Of));
        }

    }
}
