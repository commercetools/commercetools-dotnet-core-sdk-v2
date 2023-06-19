using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductRemovedFromCategoryMessageQueryBuilderDsl
    {
        public ProductRemovedFromCategoryMessageQueryBuilderDsl()
        {
        }

        public static ProductRemovedFromCategoryMessageQueryBuilderDsl Of()
        {
            return new ProductRemovedFromCategoryMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl>(p, ProductRemovedFromCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl>(p, ProductRemovedFromCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl>(p, ProductRemovedFromCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl>(p, ProductRemovedFromCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ProductRemovedFromCategoryMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ProductRemovedFromCategoryMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl>(p, ProductRemovedFromCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ProductRemovedFromCategoryMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl>(p, ProductRemovedFromCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl>(p, ProductRemovedFromCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ProductRemovedFromCategoryMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl> Category(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("category"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl.Of())),
                ProductRemovedFromCategoryMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductRemovedFromCategoryMessageQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductRemovedFromCategoryMessageQueryBuilderDsl>(p, ProductRemovedFromCategoryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
