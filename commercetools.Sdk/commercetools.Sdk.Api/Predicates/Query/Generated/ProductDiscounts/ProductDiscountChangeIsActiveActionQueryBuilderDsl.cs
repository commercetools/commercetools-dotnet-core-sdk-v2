// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountChangeIsActiveActionQueryBuilderDsl
    {
        public ProductDiscountChangeIsActiveActionQueryBuilderDsl()
        {
        }

        public static ProductDiscountChangeIsActiveActionQueryBuilderDsl Of()
        {
            return new ProductDiscountChangeIsActiveActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountChangeIsActiveActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductDiscountChangeIsActiveActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductDiscountChangeIsActiveActionQueryBuilderDsl>(p, ProductDiscountChangeIsActiveActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountChangeIsActiveActionQueryBuilderDsl, bool> IsActive()
        {
            return new ComparisonPredicateBuilder<ProductDiscountChangeIsActiveActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isActive")),
            p => new CombinationQueryPredicate<ProductDiscountChangeIsActiveActionQueryBuilderDsl>(p, ProductDiscountChangeIsActiveActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
