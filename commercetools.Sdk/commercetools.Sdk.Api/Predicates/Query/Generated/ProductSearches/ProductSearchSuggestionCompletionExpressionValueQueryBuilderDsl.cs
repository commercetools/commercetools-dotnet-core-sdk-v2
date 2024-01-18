// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl
    {
        public ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl()
        {
        }

        public static ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl Of()
        {
            return new ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl>(p, ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl>(p, ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl, string> Prefix()
        {
            return new ComparisonPredicateBuilder<ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("prefix")),
            p => new CombinationQueryPredicate<ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl>(p, ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
