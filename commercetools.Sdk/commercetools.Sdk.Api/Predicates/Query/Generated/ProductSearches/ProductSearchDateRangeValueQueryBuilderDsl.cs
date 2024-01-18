using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchDateRangeValueQueryBuilderDsl
    {
        public ProductSearchDateRangeValueQueryBuilderDsl()
        {
        }

        public static ProductSearchDateRangeValueQueryBuilderDsl Of()
        {
            return new ProductSearchDateRangeValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchDateRangeValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<ProductSearchDateRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<ProductSearchDateRangeValueQueryBuilderDsl>(p, ProductSearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchDateRangeValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<ProductSearchDateRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<ProductSearchDateRangeValueQueryBuilderDsl>(p, ProductSearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchDateRangeValueQueryBuilderDsl, string> AttributeType()
        {
            return new ComparisonPredicateBuilder<ProductSearchDateRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeType")),
            p => new CombinationQueryPredicate<ProductSearchDateRangeValueQueryBuilderDsl>(p, ProductSearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchDateRangeValueQueryBuilderDsl, Date> Gte()
        {
            return new ComparisonPredicateBuilder<ProductSearchDateRangeValueQueryBuilderDsl, Date>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gte")),
            p => new CombinationQueryPredicate<ProductSearchDateRangeValueQueryBuilderDsl>(p, ProductSearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchDateRangeValueQueryBuilderDsl, Date> Gt()
        {
            return new ComparisonPredicateBuilder<ProductSearchDateRangeValueQueryBuilderDsl, Date>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gt")),
            p => new CombinationQueryPredicate<ProductSearchDateRangeValueQueryBuilderDsl>(p, ProductSearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchDateRangeValueQueryBuilderDsl, Date> Lte()
        {
            return new ComparisonPredicateBuilder<ProductSearchDateRangeValueQueryBuilderDsl, Date>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lte")),
            p => new CombinationQueryPredicate<ProductSearchDateRangeValueQueryBuilderDsl>(p, ProductSearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchDateRangeValueQueryBuilderDsl, Date> Lt()
        {
            return new ComparisonPredicateBuilder<ProductSearchDateRangeValueQueryBuilderDsl, Date>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lt")),
            p => new CombinationQueryPredicate<ProductSearchDateRangeValueQueryBuilderDsl>(p, ProductSearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
