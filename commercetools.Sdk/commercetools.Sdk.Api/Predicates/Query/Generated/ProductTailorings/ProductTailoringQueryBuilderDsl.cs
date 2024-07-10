using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringQueryBuilderDsl
    {
        public ProductTailoringQueryBuilderDsl()
        {
        }

        public static ProductTailoringQueryBuilderDsl Of()
        {
            return new ProductTailoringQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductTailoringQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductTailoringQueryBuilderDsl>(p, ProductTailoringQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductTailoringQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductTailoringQueryBuilderDsl>(p, ProductTailoringQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ProductTailoringQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ProductTailoringQueryBuilderDsl>(p, ProductTailoringQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ProductTailoringQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ProductTailoringQueryBuilderDsl>(p, ProductTailoringQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ProductTailoringQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ProductTailoringQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductTailoringQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductTailoringQueryBuilderDsl>(p, ProductTailoringQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                ProductTailoringQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                ProductTailoringQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringQueryBuilderDsl, bool> Published()
        {
            return new ComparisonPredicateBuilder<ProductTailoringQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("published")),
            p => new CombinationQueryPredicate<ProductTailoringQueryBuilderDsl>(p, ProductTailoringQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringQueryBuilderDsl> Current(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("current"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringDataQueryBuilderDsl.Of())),
                ProductTailoringQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringQueryBuilderDsl> Staged(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("staged"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringDataQueryBuilderDsl.Of())),
                ProductTailoringQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringQueryBuilderDsl, bool> HasStagedChanges()
        {
            return new ComparisonPredicateBuilder<ProductTailoringQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("hasStagedChanges")),
            p => new CombinationQueryPredicate<ProductTailoringQueryBuilderDsl>(p, ProductTailoringQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
