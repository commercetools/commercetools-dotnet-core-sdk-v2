// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetImageLabelActionQueryBuilderDsl
    {
        public ProductSetImageLabelActionQueryBuilderDsl()
        {
        }

        public static ProductSetImageLabelActionQueryBuilderDsl Of()
        {
            return new ProductSetImageLabelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetImageLabelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetImageLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetImageLabelActionQueryBuilderDsl>(p, ProductSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetImageLabelActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductSetImageLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductSetImageLabelActionQueryBuilderDsl>(p, ProductSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetImageLabelActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductSetImageLabelActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductSetImageLabelActionQueryBuilderDsl>(p, ProductSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetImageLabelActionQueryBuilderDsl, string> ImageUrl()
        {
            return new ComparisonPredicateBuilder<ProductSetImageLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("imageUrl")),
            p => new CombinationQueryPredicate<ProductSetImageLabelActionQueryBuilderDsl>(p, ProductSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetImageLabelActionQueryBuilderDsl, string> Label()
        {
            return new ComparisonPredicateBuilder<ProductSetImageLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("label")),
            p => new CombinationQueryPredicate<ProductSetImageLabelActionQueryBuilderDsl>(p, ProductSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetImageLabelActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetImageLabelActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetImageLabelActionQueryBuilderDsl>(p, ProductSetImageLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
