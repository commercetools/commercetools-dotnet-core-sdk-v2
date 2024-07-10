// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountValueRelativeDraftQueryBuilderDsl
    {
        public ProductDiscountValueRelativeDraftQueryBuilderDsl()
        {
        }

        public static ProductDiscountValueRelativeDraftQueryBuilderDsl Of()
        {
            return new ProductDiscountValueRelativeDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountValueRelativeDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductDiscountValueRelativeDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductDiscountValueRelativeDraftQueryBuilderDsl>(p, ProductDiscountValueRelativeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountValueRelativeDraftQueryBuilderDsl, long> Permyriad()
        {
            return new ComparisonPredicateBuilder<ProductDiscountValueRelativeDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permyriad")),
            p => new CombinationQueryPredicate<ProductDiscountValueRelativeDraftQueryBuilderDsl>(p, ProductDiscountValueRelativeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
