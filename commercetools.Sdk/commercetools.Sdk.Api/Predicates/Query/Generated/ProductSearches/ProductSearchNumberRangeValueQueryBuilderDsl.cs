// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchNumberRangeValueQueryBuilderDsl
    {
        public ProductSearchNumberRangeValueQueryBuilderDsl()
        {
        }

        public static ProductSearchNumberRangeValueQueryBuilderDsl Of()
        {
            return new ProductSearchNumberRangeValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchNumberRangeValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<ProductSearchNumberRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<ProductSearchNumberRangeValueQueryBuilderDsl>(p, ProductSearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchNumberRangeValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<ProductSearchNumberRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<ProductSearchNumberRangeValueQueryBuilderDsl>(p, ProductSearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchNumberRangeValueQueryBuilderDsl, string> AttributeType()
        {
            return new ComparisonPredicateBuilder<ProductSearchNumberRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeType")),
            p => new CombinationQueryPredicate<ProductSearchNumberRangeValueQueryBuilderDsl>(p, ProductSearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchNumberRangeValueQueryBuilderDsl, decimal> Gte()
        {
            return new ComparisonPredicateBuilder<ProductSearchNumberRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gte")),
            p => new CombinationQueryPredicate<ProductSearchNumberRangeValueQueryBuilderDsl>(p, ProductSearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchNumberRangeValueQueryBuilderDsl, decimal> Gt()
        {
            return new ComparisonPredicateBuilder<ProductSearchNumberRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gt")),
            p => new CombinationQueryPredicate<ProductSearchNumberRangeValueQueryBuilderDsl>(p, ProductSearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchNumberRangeValueQueryBuilderDsl, decimal> Lte()
        {
            return new ComparisonPredicateBuilder<ProductSearchNumberRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lte")),
            p => new CombinationQueryPredicate<ProductSearchNumberRangeValueQueryBuilderDsl>(p, ProductSearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchNumberRangeValueQueryBuilderDsl, decimal> Lt()
        {
            return new ComparisonPredicateBuilder<ProductSearchNumberRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lt")),
            p => new CombinationQueryPredicate<ProductSearchNumberRangeValueQueryBuilderDsl>(p, ProductSearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
