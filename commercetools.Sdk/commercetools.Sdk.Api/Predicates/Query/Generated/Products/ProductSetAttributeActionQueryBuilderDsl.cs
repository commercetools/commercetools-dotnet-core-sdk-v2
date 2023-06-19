// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetAttributeActionQueryBuilderDsl
    {
        public ProductSetAttributeActionQueryBuilderDsl()
        {
        }

        public static ProductSetAttributeActionQueryBuilderDsl Of()
        {
            return new ProductSetAttributeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetAttributeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetAttributeActionQueryBuilderDsl>(p, ProductSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAttributeActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductSetAttributeActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductSetAttributeActionQueryBuilderDsl>(p, ProductSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAttributeActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductSetAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductSetAttributeActionQueryBuilderDsl>(p, ProductSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAttributeActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductSetAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductSetAttributeActionQueryBuilderDsl>(p, ProductSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAttributeActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ProductSetAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ProductSetAttributeActionQueryBuilderDsl>(p, ProductSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAttributeActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetAttributeActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetAttributeActionQueryBuilderDsl>(p, ProductSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
