using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class VariantCreatedMessagePayloadQueryBuilderDsl
    {
        public VariantCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static VariantCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new VariantCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl>(p, VariantCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl>(p, VariantCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl, string> ProductId()
        {
            return new ComparisonPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productId")),
            p => new CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl>(p, VariantCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl>(p, VariantCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl>(p, VariantCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl>(p, VariantCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                VariantCreatedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl>(p, VariantCreatedMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl> Assets(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("assets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl.Of())),
                VariantCreatedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl> Assets()
        {
            return new CollectionPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assets")),
                    p => new CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl>(p, VariantCreatedMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl> Images(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("images"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                VariantCreatedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl> Images()
        {
            return new CollectionPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("images")),
                    p => new CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl>(p, VariantCreatedMessagePayloadQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl, bool> Publish()
        {
            return new ComparisonPredicateBuilder<VariantCreatedMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("publish")),
            p => new CombinationQueryPredicate<VariantCreatedMessagePayloadQueryBuilderDsl>(p, VariantCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
