// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchLongRangeValueQueryBuilderDsl
    {
        public ProductSearchLongRangeValueQueryBuilderDsl()
        {
        }

        public static ProductSearchLongRangeValueQueryBuilderDsl Of()
        {
            return new ProductSearchLongRangeValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchLongRangeValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<ProductSearchLongRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<ProductSearchLongRangeValueQueryBuilderDsl>(p, ProductSearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchLongRangeValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<ProductSearchLongRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<ProductSearchLongRangeValueQueryBuilderDsl>(p, ProductSearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchLongRangeValueQueryBuilderDsl, string> AttributeType()
        {
            return new ComparisonPredicateBuilder<ProductSearchLongRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeType")),
            p => new CombinationQueryPredicate<ProductSearchLongRangeValueQueryBuilderDsl>(p, ProductSearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchLongRangeValueQueryBuilderDsl, long> Gte()
        {
            return new ComparisonPredicateBuilder<ProductSearchLongRangeValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gte")),
            p => new CombinationQueryPredicate<ProductSearchLongRangeValueQueryBuilderDsl>(p, ProductSearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchLongRangeValueQueryBuilderDsl, long> Gt()
        {
            return new ComparisonPredicateBuilder<ProductSearchLongRangeValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gt")),
            p => new CombinationQueryPredicate<ProductSearchLongRangeValueQueryBuilderDsl>(p, ProductSearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchLongRangeValueQueryBuilderDsl, long> Lte()
        {
            return new ComparisonPredicateBuilder<ProductSearchLongRangeValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lte")),
            p => new CombinationQueryPredicate<ProductSearchLongRangeValueQueryBuilderDsl>(p, ProductSearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchLongRangeValueQueryBuilderDsl, long> Lt()
        {
            return new ComparisonPredicateBuilder<ProductSearchLongRangeValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lt")),
            p => new CombinationQueryPredicate<ProductSearchLongRangeValueQueryBuilderDsl>(p, ProductSearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
