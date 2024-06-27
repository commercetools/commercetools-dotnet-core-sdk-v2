// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringRemoveVariantActionQueryBuilderDsl
    {
        public ProductTailoringRemoveVariantActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringRemoveVariantActionQueryBuilderDsl Of()
        {
            return new ProductTailoringRemoveVariantActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringRemoveVariantActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringRemoveVariantActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringRemoveVariantActionQueryBuilderDsl>(p, ProductTailoringRemoveVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringRemoveVariantActionQueryBuilderDsl, long> Id()
        {
            return new ComparisonPredicateBuilder<ProductTailoringRemoveVariantActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductTailoringRemoveVariantActionQueryBuilderDsl>(p, ProductTailoringRemoveVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringRemoveVariantActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductTailoringRemoveVariantActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductTailoringRemoveVariantActionQueryBuilderDsl>(p, ProductTailoringRemoveVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringRemoveVariantActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringRemoveVariantActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringRemoveVariantActionQueryBuilderDsl>(p, ProductTailoringRemoveVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
