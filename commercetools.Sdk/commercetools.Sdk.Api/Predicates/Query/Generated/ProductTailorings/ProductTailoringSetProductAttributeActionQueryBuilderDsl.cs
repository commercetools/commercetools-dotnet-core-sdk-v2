// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringSetProductAttributeActionQueryBuilderDsl
    {
        public ProductTailoringSetProductAttributeActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringSetProductAttributeActionQueryBuilderDsl Of()
        {
            return new ProductTailoringSetProductAttributeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringSetProductAttributeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetProductAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringSetProductAttributeActionQueryBuilderDsl>(p, ProductTailoringSetProductAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetProductAttributeActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetProductAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductTailoringSetProductAttributeActionQueryBuilderDsl>(p, ProductTailoringSetProductAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetProductAttributeActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetProductAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ProductTailoringSetProductAttributeActionQueryBuilderDsl>(p, ProductTailoringSetProductAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetProductAttributeActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetProductAttributeActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringSetProductAttributeActionQueryBuilderDsl>(p, ProductTailoringSetProductAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
