// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringAttributeQueryBuilderDsl
    {
        public ProductTailoringAttributeQueryBuilderDsl()
        {
        }

        public static ProductTailoringAttributeQueryBuilderDsl Of()
        {
            return new ProductTailoringAttributeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringAttributeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductTailoringAttributeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductTailoringAttributeQueryBuilderDsl>(p, ProductTailoringAttributeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringAttributeQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ProductTailoringAttributeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ProductTailoringAttributeQueryBuilderDsl>(p, ProductTailoringAttributeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
