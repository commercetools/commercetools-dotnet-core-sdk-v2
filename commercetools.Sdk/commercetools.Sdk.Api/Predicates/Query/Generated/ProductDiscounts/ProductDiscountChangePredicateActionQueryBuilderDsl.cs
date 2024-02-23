// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountChangePredicateActionQueryBuilderDsl
    {
        public ProductDiscountChangePredicateActionQueryBuilderDsl()
        {
        }

        public static ProductDiscountChangePredicateActionQueryBuilderDsl Of()
        {
            return new ProductDiscountChangePredicateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountChangePredicateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductDiscountChangePredicateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductDiscountChangePredicateActionQueryBuilderDsl>(p, ProductDiscountChangePredicateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountChangePredicateActionQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<ProductDiscountChangePredicateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<ProductDiscountChangePredicateActionQueryBuilderDsl>(p, ProductDiscountChangePredicateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
