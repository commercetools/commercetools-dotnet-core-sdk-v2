// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetProductAttributeActionQueryBuilderDsl
    {
        public ProductSetProductAttributeActionQueryBuilderDsl()
        {
        }

        public static ProductSetProductAttributeActionQueryBuilderDsl Of()
        {
            return new ProductSetProductAttributeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetProductAttributeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetProductAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetProductAttributeActionQueryBuilderDsl>(p, ProductSetProductAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetProductAttributeActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductSetProductAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductSetProductAttributeActionQueryBuilderDsl>(p, ProductSetProductAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetProductAttributeActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ProductSetProductAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ProductSetProductAttributeActionQueryBuilderDsl>(p, ProductSetProductAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetProductAttributeActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetProductAttributeActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetProductAttributeActionQueryBuilderDsl>(p, ProductSetProductAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
