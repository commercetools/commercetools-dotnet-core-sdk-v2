// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountValueRelativeDraftQueryBuilderDsl
    {
        public CartDiscountValueRelativeDraftQueryBuilderDsl()
        {
        }

        public static CartDiscountValueRelativeDraftQueryBuilderDsl Of()
        {
            return new CartDiscountValueRelativeDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountValueRelativeDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueRelativeDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountValueRelativeDraftQueryBuilderDsl>(p, CartDiscountValueRelativeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountValueRelativeDraftQueryBuilderDsl, long> Permyriad()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueRelativeDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permyriad")),
            p => new CombinationQueryPredicate<CartDiscountValueRelativeDraftQueryBuilderDsl>(p, CartDiscountValueRelativeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountValueRelativeDraftQueryBuilderDsl, string> ApplicationMode()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueRelativeDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("applicationMode")),
            p => new CombinationQueryPredicate<CartDiscountValueRelativeDraftQueryBuilderDsl>(p, CartDiscountValueRelativeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
