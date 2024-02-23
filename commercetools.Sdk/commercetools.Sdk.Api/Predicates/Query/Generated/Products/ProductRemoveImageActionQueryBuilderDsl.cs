// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductRemoveImageActionQueryBuilderDsl
    {
        public ProductRemoveImageActionQueryBuilderDsl()
        {
        }

        public static ProductRemoveImageActionQueryBuilderDsl Of()
        {
            return new ProductRemoveImageActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductRemoveImageActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductRemoveImageActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductRemoveImageActionQueryBuilderDsl>(p, ProductRemoveImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemoveImageActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductRemoveImageActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductRemoveImageActionQueryBuilderDsl>(p, ProductRemoveImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemoveImageActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductRemoveImageActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductRemoveImageActionQueryBuilderDsl>(p, ProductRemoveImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemoveImageActionQueryBuilderDsl, string> ImageUrl()
        {
            return new ComparisonPredicateBuilder<ProductRemoveImageActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("imageUrl")),
            p => new CombinationQueryPredicate<ProductRemoveImageActionQueryBuilderDsl>(p, ProductRemoveImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemoveImageActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductRemoveImageActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductRemoveImageActionQueryBuilderDsl>(p, ProductRemoveImageActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
