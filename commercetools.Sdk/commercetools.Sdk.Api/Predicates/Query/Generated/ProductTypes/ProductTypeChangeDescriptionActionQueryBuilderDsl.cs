// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeChangeDescriptionActionQueryBuilderDsl
    {
        public ProductTypeChangeDescriptionActionQueryBuilderDsl()
        {
        }

        public static ProductTypeChangeDescriptionActionQueryBuilderDsl Of()
        {
            return new ProductTypeChangeDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeChangeDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeChangeDescriptionActionQueryBuilderDsl>(p, ProductTypeChangeDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeDescriptionActionQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<ProductTypeChangeDescriptionActionQueryBuilderDsl>(p, ProductTypeChangeDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
