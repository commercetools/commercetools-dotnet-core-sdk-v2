using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductVariantTailoringAddedMessageQueryBuilderDsl
    {
        public ProductVariantTailoringAddedMessageQueryBuilderDsl()
        {
        }

        public static ProductVariantTailoringAddedMessageQueryBuilderDsl Of()
        {
            return new ProductVariantTailoringAddedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(p, ProductVariantTailoringAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(p, ProductVariantTailoringAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(p, ProductVariantTailoringAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(p, ProductVariantTailoringAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ProductVariantTailoringAddedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ProductVariantTailoringAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(p, ProductVariantTailoringAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ProductVariantTailoringAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(p, ProductVariantTailoringAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(p, ProductVariantTailoringAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ProductVariantTailoringAddedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                ProductVariantTailoringAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, string> ProductKey()
        {
            return new ComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productKey")),
            p => new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(p, ProductVariantTailoringAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                ProductVariantTailoringAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductVariantTailoringAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(p, ProductVariantTailoringAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl> Variant(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductVariantTailoringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductVariantTailoringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variant"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductVariantTailoringQueryBuilderDsl.Of())),
                ProductVariantTailoringAddedMessageQueryBuilderDsl.Of);
        }


    }
}
