using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryPagedQueryResponseQueryBuilderDsl
    {
        public CategoryPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static CategoryPagedQueryResponseQueryBuilderDsl Of()
        {
            return new CategoryPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<CategoryPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<CategoryPagedQueryResponseQueryBuilderDsl>(p, CategoryPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategoryPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<CategoryPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<CategoryPagedQueryResponseQueryBuilderDsl>(p, CategoryPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategoryPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<CategoryPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<CategoryPagedQueryResponseQueryBuilderDsl>(p, CategoryPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategoryPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<CategoryPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<CategoryPagedQueryResponseQueryBuilderDsl>(p, CategoryPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategoryPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryQueryBuilderDsl.Of())),
                CategoryPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CategoryPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<CategoryPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<CategoryPagedQueryResponseQueryBuilderDsl>(p, CategoryPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
