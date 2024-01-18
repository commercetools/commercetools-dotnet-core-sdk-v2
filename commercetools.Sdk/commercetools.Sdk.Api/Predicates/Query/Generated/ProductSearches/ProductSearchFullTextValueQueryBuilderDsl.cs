// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFullTextValueQueryBuilderDsl
    {
        public ProductSearchFullTextValueQueryBuilderDsl()
        {
        }

        public static ProductSearchFullTextValueQueryBuilderDsl Of()
        {
            return new ProductSearchFullTextValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchFullTextValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<ProductSearchFullTextValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<ProductSearchFullTextValueQueryBuilderDsl>(p, ProductSearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFullTextValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<ProductSearchFullTextValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<ProductSearchFullTextValueQueryBuilderDsl>(p, ProductSearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFullTextValueQueryBuilderDsl, string> AttributeType()
        {
            return new ComparisonPredicateBuilder<ProductSearchFullTextValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeType")),
            p => new CombinationQueryPredicate<ProductSearchFullTextValueQueryBuilderDsl>(p, ProductSearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFullTextValueQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ProductSearchFullTextValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ProductSearchFullTextValueQueryBuilderDsl>(p, ProductSearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFullTextValueQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<ProductSearchFullTextValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<ProductSearchFullTextValueQueryBuilderDsl>(p, ProductSearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFullTextValueQueryBuilderDsl, string> MustMatch()
        {
            return new ComparisonPredicateBuilder<ProductSearchFullTextValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mustMatch")),
            p => new CombinationQueryPredicate<ProductSearchFullTextValueQueryBuilderDsl>(p, ProductSearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
