// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductRemoveVariantActionQueryBuilderDsl
    {
        public ProductRemoveVariantActionQueryBuilderDsl()
        {
        }

        public static ProductRemoveVariantActionQueryBuilderDsl Of()
        {
            return new ProductRemoveVariantActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductRemoveVariantActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductRemoveVariantActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductRemoveVariantActionQueryBuilderDsl>(p, ProductRemoveVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemoveVariantActionQueryBuilderDsl, long> Id()
        {
            return new ComparisonPredicateBuilder<ProductRemoveVariantActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductRemoveVariantActionQueryBuilderDsl>(p, ProductRemoveVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemoveVariantActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductRemoveVariantActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductRemoveVariantActionQueryBuilderDsl>(p, ProductRemoveVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemoveVariantActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductRemoveVariantActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductRemoveVariantActionQueryBuilderDsl>(p, ProductRemoveVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
