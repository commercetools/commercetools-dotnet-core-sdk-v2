using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchDateTimeRangeValueQueryBuilderDsl
    {
        public ProductSearchDateTimeRangeValueQueryBuilderDsl()
        {
        }

        public static ProductSearchDateTimeRangeValueQueryBuilderDsl Of()
        {
            return new ProductSearchDateTimeRangeValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchDateTimeRangeValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<ProductSearchDateTimeRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<ProductSearchDateTimeRangeValueQueryBuilderDsl>(p, ProductSearchDateTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchDateTimeRangeValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<ProductSearchDateTimeRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<ProductSearchDateTimeRangeValueQueryBuilderDsl>(p, ProductSearchDateTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchDateTimeRangeValueQueryBuilderDsl, string> AttributeType()
        {
            return new ComparisonPredicateBuilder<ProductSearchDateTimeRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeType")),
            p => new CombinationQueryPredicate<ProductSearchDateTimeRangeValueQueryBuilderDsl>(p, ProductSearchDateTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchDateTimeRangeValueQueryBuilderDsl, DateTime> Gte()
        {
            return new ComparisonPredicateBuilder<ProductSearchDateTimeRangeValueQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gte")),
            p => new CombinationQueryPredicate<ProductSearchDateTimeRangeValueQueryBuilderDsl>(p, ProductSearchDateTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchDateTimeRangeValueQueryBuilderDsl, DateTime> Gt()
        {
            return new ComparisonPredicateBuilder<ProductSearchDateTimeRangeValueQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gt")),
            p => new CombinationQueryPredicate<ProductSearchDateTimeRangeValueQueryBuilderDsl>(p, ProductSearchDateTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchDateTimeRangeValueQueryBuilderDsl, DateTime> Lte()
        {
            return new ComparisonPredicateBuilder<ProductSearchDateTimeRangeValueQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lte")),
            p => new CombinationQueryPredicate<ProductSearchDateTimeRangeValueQueryBuilderDsl>(p, ProductSearchDateTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchDateTimeRangeValueQueryBuilderDsl, DateTime> Lt()
        {
            return new ComparisonPredicateBuilder<ProductSearchDateTimeRangeValueQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lt")),
            p => new CombinationQueryPredicate<ProductSearchDateTimeRangeValueQueryBuilderDsl>(p, ProductSearchDateTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
