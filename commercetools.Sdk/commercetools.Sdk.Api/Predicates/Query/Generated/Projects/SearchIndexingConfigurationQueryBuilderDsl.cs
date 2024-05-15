using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class SearchIndexingConfigurationQueryBuilderDsl
    {
        public SearchIndexingConfigurationQueryBuilderDsl()
        {
        }

        public static SearchIndexingConfigurationQueryBuilderDsl Of()
        {
            return new SearchIndexingConfigurationQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SearchIndexingConfigurationQueryBuilderDsl> Products(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.SearchIndexingConfigurationValuesQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.SearchIndexingConfigurationValuesQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchIndexingConfigurationQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("products"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.SearchIndexingConfigurationValuesQueryBuilderDsl.Of())),
                SearchIndexingConfigurationQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<SearchIndexingConfigurationQueryBuilderDsl> ProductsSearch(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.SearchIndexingConfigurationValuesQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.SearchIndexingConfigurationValuesQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchIndexingConfigurationQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productsSearch"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.SearchIndexingConfigurationValuesQueryBuilderDsl.Of())),
                SearchIndexingConfigurationQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<SearchIndexingConfigurationQueryBuilderDsl> Orders(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.SearchIndexingConfigurationValuesQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.SearchIndexingConfigurationValuesQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SearchIndexingConfigurationQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("orders"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.SearchIndexingConfigurationValuesQueryBuilderDsl.Of())),
                SearchIndexingConfigurationQueryBuilderDsl.Of);
        }


    }
}
