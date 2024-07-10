// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountSetKeyActionQueryBuilderDsl
    {
        public ProductDiscountSetKeyActionQueryBuilderDsl()
        {
        }

        public static ProductDiscountSetKeyActionQueryBuilderDsl Of()
        {
            return new ProductDiscountSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductDiscountSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductDiscountSetKeyActionQueryBuilderDsl>(p, ProductDiscountSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductDiscountSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductDiscountSetKeyActionQueryBuilderDsl>(p, ProductDiscountSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
