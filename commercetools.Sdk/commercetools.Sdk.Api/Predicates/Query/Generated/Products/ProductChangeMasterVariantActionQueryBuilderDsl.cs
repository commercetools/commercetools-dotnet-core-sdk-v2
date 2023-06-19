// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductChangeMasterVariantActionQueryBuilderDsl
    {
        public ProductChangeMasterVariantActionQueryBuilderDsl()
        {
        }

        public static ProductChangeMasterVariantActionQueryBuilderDsl Of()
        {
            return new ProductChangeMasterVariantActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductChangeMasterVariantActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductChangeMasterVariantActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductChangeMasterVariantActionQueryBuilderDsl>(p, ProductChangeMasterVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductChangeMasterVariantActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductChangeMasterVariantActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductChangeMasterVariantActionQueryBuilderDsl>(p, ProductChangeMasterVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductChangeMasterVariantActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductChangeMasterVariantActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductChangeMasterVariantActionQueryBuilderDsl>(p, ProductChangeMasterVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductChangeMasterVariantActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductChangeMasterVariantActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductChangeMasterVariantActionQueryBuilderDsl>(p, ProductChangeMasterVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
