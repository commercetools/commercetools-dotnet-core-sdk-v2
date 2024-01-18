// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchAnyValueQueryBuilderDsl
    {
        public ProductSearchAnyValueQueryBuilderDsl()
        {
        }

        public static ProductSearchAnyValueQueryBuilderDsl Of()
        {
            return new ProductSearchAnyValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchAnyValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<ProductSearchAnyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<ProductSearchAnyValueQueryBuilderDsl>(p, ProductSearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchAnyValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<ProductSearchAnyValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<ProductSearchAnyValueQueryBuilderDsl>(p, ProductSearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchAnyValueQueryBuilderDsl, string> AttributeType()
        {
            return new ComparisonPredicateBuilder<ProductSearchAnyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeType")),
            p => new CombinationQueryPredicate<ProductSearchAnyValueQueryBuilderDsl>(p, ProductSearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchAnyValueQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ProductSearchAnyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ProductSearchAnyValueQueryBuilderDsl>(p, ProductSearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchAnyValueQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<ProductSearchAnyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<ProductSearchAnyValueQueryBuilderDsl>(p, ProductSearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchAnyValueQueryBuilderDsl, bool> CaseInsensitive()
        {
            return new ComparisonPredicateBuilder<ProductSearchAnyValueQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("caseInsensitive")),
            p => new CombinationQueryPredicate<ProductSearchAnyValueQueryBuilderDsl>(p, ProductSearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
