// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchExistsValueQueryBuilderDsl
    {
        public ProductSearchExistsValueQueryBuilderDsl()
        {
        }

        public static ProductSearchExistsValueQueryBuilderDsl Of()
        {
            return new ProductSearchExistsValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchExistsValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<ProductSearchExistsValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<ProductSearchExistsValueQueryBuilderDsl>(p, ProductSearchExistsValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchExistsValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<ProductSearchExistsValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<ProductSearchExistsValueQueryBuilderDsl>(p, ProductSearchExistsValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchExistsValueQueryBuilderDsl, string> AttributeType()
        {
            return new ComparisonPredicateBuilder<ProductSearchExistsValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeType")),
            p => new CombinationQueryPredicate<ProductSearchExistsValueQueryBuilderDsl>(p, ProductSearchExistsValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchExistsValueQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<ProductSearchExistsValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<ProductSearchExistsValueQueryBuilderDsl>(p, ProductSearchExistsValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
