// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountValueRelativeQueryBuilderDsl
    {
        public ProductDiscountValueRelativeQueryBuilderDsl()
        {
        }

        public static ProductDiscountValueRelativeQueryBuilderDsl Of()
        {
            return new ProductDiscountValueRelativeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountValueRelativeQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductDiscountValueRelativeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductDiscountValueRelativeQueryBuilderDsl>(p, ProductDiscountValueRelativeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountValueRelativeQueryBuilderDsl, long> Permyriad()
        {
            return new ComparisonPredicateBuilder<ProductDiscountValueRelativeQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permyriad")),
            p => new CombinationQueryPredicate<ProductDiscountValueRelativeQueryBuilderDsl>(p, ProductDiscountValueRelativeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
