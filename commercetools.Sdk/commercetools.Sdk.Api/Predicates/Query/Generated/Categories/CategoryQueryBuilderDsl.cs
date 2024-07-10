using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryQueryBuilderDsl
    {
        public CategoryQueryBuilderDsl()
        {
        }

        public static CategoryQueryBuilderDsl Of()
        {
            return new CategoryQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CategoryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CategoryQueryBuilderDsl>(p, CategoryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategoryQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CategoryQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CategoryQueryBuilderDsl>(p, CategoryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategoryQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CategoryQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CategoryQueryBuilderDsl>(p, CategoryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategoryQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CategoryQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CategoryQueryBuilderDsl>(p, CategoryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategoryQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CategoryQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CategoryQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CategoryQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CategoryQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CategoryQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CategoryQueryBuilderDsl> Slug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("slug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CategoryQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CategoryQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CategoryQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CategoryQueryBuilderDsl> Ancestors(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("ancestors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl.Of())),
                CategoryQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CategoryQueryBuilderDsl> Ancestors()
        {
            return new CollectionPredicateBuilder<CategoryQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("ancestors")),
                    p => new CombinationQueryPredicate<CategoryQueryBuilderDsl>(p, CategoryQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CategoryQueryBuilderDsl> Parent(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parent"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl.Of())),
                CategoryQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CategoryQueryBuilderDsl, string> OrderHint()
        {
            return new ComparisonPredicateBuilder<CategoryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderHint")),
            p => new CombinationQueryPredicate<CategoryQueryBuilderDsl>(p, CategoryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategoryQueryBuilderDsl, string> ExternalId()
        {
            return new ComparisonPredicateBuilder<CategoryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalId")),
            p => new CombinationQueryPredicate<CategoryQueryBuilderDsl>(p, CategoryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategoryQueryBuilderDsl> MetaTitle(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaTitle"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CategoryQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CategoryQueryBuilderDsl> MetaDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaDescription"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CategoryQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CategoryQueryBuilderDsl> MetaKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaKeywords"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                CategoryQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CategoryQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                CategoryQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CategoryQueryBuilderDsl> Assets(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("assets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl.Of())),
                CategoryQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CategoryQueryBuilderDsl> Assets()
        {
            return new CollectionPredicateBuilder<CategoryQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assets")),
                    p => new CombinationQueryPredicate<CategoryQueryBuilderDsl>(p, CategoryQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CategoryQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CategoryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CategoryQueryBuilderDsl>(p, CategoryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
