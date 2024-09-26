// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringSetAttributeActionQueryBuilderDsl
    {
        public ProductTailoringSetAttributeActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringSetAttributeActionQueryBuilderDsl Of()
        {
            return new ProductTailoringSetAttributeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringSetAttributeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringSetAttributeActionQueryBuilderDsl>(p, ProductTailoringSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAttributeActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAttributeActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductTailoringSetAttributeActionQueryBuilderDsl>(p, ProductTailoringSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAttributeActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductTailoringSetAttributeActionQueryBuilderDsl>(p, ProductTailoringSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAttributeActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductTailoringSetAttributeActionQueryBuilderDsl>(p, ProductTailoringSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAttributeActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ProductTailoringSetAttributeActionQueryBuilderDsl>(p, ProductTailoringSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAttributeActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAttributeActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringSetAttributeActionQueryBuilderDsl>(p, ProductTailoringSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
