using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class TaxCategoryPagedQueryResponseQueryBuilderDsl
    {
        public TaxCategoryPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static TaxCategoryPagedQueryResponseQueryBuilderDsl Of()
        {
            return new TaxCategoryPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxCategoryPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<TaxCategoryPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<TaxCategoryPagedQueryResponseQueryBuilderDsl>(p, TaxCategoryPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<TaxCategoryPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<TaxCategoryPagedQueryResponseQueryBuilderDsl>(p, TaxCategoryPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<TaxCategoryPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<TaxCategoryPagedQueryResponseQueryBuilderDsl>(p, TaxCategoryPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<TaxCategoryPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<TaxCategoryPagedQueryResponseQueryBuilderDsl>(p, TaxCategoryPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TaxCategoryPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxCategoryPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryQueryBuilderDsl.Of())),
                TaxCategoryPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<TaxCategoryPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<TaxCategoryPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<TaxCategoryPagedQueryResponseQueryBuilderDsl>(p, TaxCategoryPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
