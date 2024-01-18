using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchTimeRangeValueQueryBuilderDsl
    {
        public ProductSearchTimeRangeValueQueryBuilderDsl()
        {
        }

        public static ProductSearchTimeRangeValueQueryBuilderDsl Of()
        {
            return new ProductSearchTimeRangeValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchTimeRangeValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<ProductSearchTimeRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<ProductSearchTimeRangeValueQueryBuilderDsl>(p, ProductSearchTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchTimeRangeValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<ProductSearchTimeRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<ProductSearchTimeRangeValueQueryBuilderDsl>(p, ProductSearchTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchTimeRangeValueQueryBuilderDsl, string> AttributeType()
        {
            return new ComparisonPredicateBuilder<ProductSearchTimeRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeType")),
            p => new CombinationQueryPredicate<ProductSearchTimeRangeValueQueryBuilderDsl>(p, ProductSearchTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchTimeRangeValueQueryBuilderDsl, TimeSpan> Gte()
        {
            return new ComparisonPredicateBuilder<ProductSearchTimeRangeValueQueryBuilderDsl, TimeSpan>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gte")),
            p => new CombinationQueryPredicate<ProductSearchTimeRangeValueQueryBuilderDsl>(p, ProductSearchTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchTimeRangeValueQueryBuilderDsl, TimeSpan> Gt()
        {
            return new ComparisonPredicateBuilder<ProductSearchTimeRangeValueQueryBuilderDsl, TimeSpan>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gt")),
            p => new CombinationQueryPredicate<ProductSearchTimeRangeValueQueryBuilderDsl>(p, ProductSearchTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchTimeRangeValueQueryBuilderDsl, TimeSpan> Lte()
        {
            return new ComparisonPredicateBuilder<ProductSearchTimeRangeValueQueryBuilderDsl, TimeSpan>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lte")),
            p => new CombinationQueryPredicate<ProductSearchTimeRangeValueQueryBuilderDsl>(p, ProductSearchTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchTimeRangeValueQueryBuilderDsl, TimeSpan> Lt()
        {
            return new ComparisonPredicateBuilder<ProductSearchTimeRangeValueQueryBuilderDsl, TimeSpan>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lt")),
            p => new CombinationQueryPredicate<ProductSearchTimeRangeValueQueryBuilderDsl>(p, ProductSearchTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
