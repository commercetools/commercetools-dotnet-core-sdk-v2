using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductPublishedMessageQueryBuilderDsl
    {
        public ProductPublishedMessageQueryBuilderDsl()
        {
        }

        public static ProductPublishedMessageQueryBuilderDsl Of()
        {
            return new ProductPublishedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl>(p, ProductPublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl>(p, ProductPublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl>(p, ProductPublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl>(p, ProductPublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ProductPublishedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ProductPublishedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl>(p, ProductPublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ProductPublishedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl>(p, ProductPublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl>(p, ProductPublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ProductPublishedMessageQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, string> RemovedImageUrls()
        {
            return new ComparableCollectionPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedImageUrls")),
            p => new CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl>(p, ProductPublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl> ProductProjection(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productProjection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl.Of())),
                ProductPublishedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, string> Scope()
        {
            return new ComparisonPredicateBuilder<ProductPublishedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("scope")),
            p => new CombinationQueryPredicate<ProductPublishedMessageQueryBuilderDsl>(p, ProductPublishedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
