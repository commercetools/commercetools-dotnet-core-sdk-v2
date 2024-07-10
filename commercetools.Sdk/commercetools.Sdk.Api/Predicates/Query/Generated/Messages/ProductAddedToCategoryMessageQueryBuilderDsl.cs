using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductAddedToCategoryMessageQueryBuilderDsl
    {
        public ProductAddedToCategoryMessageQueryBuilderDsl()
        {
        }

        public static ProductAddedToCategoryMessageQueryBuilderDsl Of()
        {
            return new ProductAddedToCategoryMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl>(p, ProductAddedToCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl>(p, ProductAddedToCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl>(p, ProductAddedToCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl>(p, ProductAddedToCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ProductAddedToCategoryMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ProductAddedToCategoryMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl>(p, ProductAddedToCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ProductAddedToCategoryMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl>(p, ProductAddedToCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl>(p, ProductAddedToCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ProductAddedToCategoryMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl> Category(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("category"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl.Of())),
                ProductAddedToCategoryMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductAddedToCategoryMessageQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductAddedToCategoryMessageQueryBuilderDsl>(p, ProductAddedToCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
