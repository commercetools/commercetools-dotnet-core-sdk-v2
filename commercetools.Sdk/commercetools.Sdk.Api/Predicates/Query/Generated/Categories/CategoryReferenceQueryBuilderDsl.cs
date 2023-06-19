using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryReferenceQueryBuilderDsl
    {
        public CategoryReferenceQueryBuilderDsl()
        {
        }

        public static CategoryReferenceQueryBuilderDsl Of()
        {
            return new CategoryReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<CategoryReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<CategoryReferenceQueryBuilderDsl>(p, CategoryReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategoryReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CategoryReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CategoryReferenceQueryBuilderDsl>(p, CategoryReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategoryReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryQueryBuilderDsl.Of())),
                CategoryReferenceQueryBuilderDsl.Of);
        }


    }
}
