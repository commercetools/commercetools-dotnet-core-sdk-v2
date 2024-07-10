using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class SearchIndexingConfigurationValuesQueryBuilderDsl
    {
        public SearchIndexingConfigurationValuesQueryBuilderDsl()
        {
        }

        public static SearchIndexingConfigurationValuesQueryBuilderDsl Of()
        {
            return new SearchIndexingConfigurationValuesQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchIndexingConfigurationValuesQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<SearchIndexingConfigurationValuesQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<SearchIndexingConfigurationValuesQueryBuilderDsl>(p, SearchIndexingConfigurationValuesQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchIndexingConfigurationValuesQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<SearchIndexingConfigurationValuesQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<SearchIndexingConfigurationValuesQueryBuilderDsl>(p, SearchIndexingConfigurationValuesQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<SearchIndexingConfigurationValuesQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchIndexingConfigurationValuesQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                SearchIndexingConfigurationValuesQueryBuilderDsl.Of);
        }


    }
}
