using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchQueryExpressionValueQueryBuilderDsl
    {
        public ProductSearchQueryExpressionValueQueryBuilderDsl()
        {
        }

        public static ProductSearchQueryExpressionValueQueryBuilderDsl Of()
        {
            return new ProductSearchQueryExpressionValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchQueryExpressionValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<ProductSearchQueryExpressionValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl>(p, ProductSearchQueryExpressionValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchQueryExpressionValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<ProductSearchQueryExpressionValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl>(p, ProductSearchQueryExpressionValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchQueryExpressionValueQueryBuilderDsl, string> AttributeType()
        {
            return new ComparisonPredicateBuilder<ProductSearchQueryExpressionValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeType")),
            p => new CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl>(p, ProductSearchQueryExpressionValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl> AsProductSearchAnyValue(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchAnyValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchAnyValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchAnyValueQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl> AsProductSearchDateRangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateRangeValueQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl> AsProductSearchDateTimeRangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateTimeRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateTimeRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateTimeRangeValueQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl> AsProductSearchExistsValue(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchExistsValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchExistsValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchExistsValueQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl> AsProductSearchFullTextValue(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFullTextValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFullTextValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFullTextValueQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl> AsProductSearchLongRangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchLongRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchLongRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchLongRangeValueQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl> AsProductSearchNumberRangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchNumberRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchNumberRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchNumberRangeValueQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl> AsProductSearchTimeRangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchTimeRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchTimeRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchTimeRangeValueQueryBuilderDsl.Of()),
                ProductSearchQueryExpressionValueQueryBuilderDsl.Of);
        }
    }
}
