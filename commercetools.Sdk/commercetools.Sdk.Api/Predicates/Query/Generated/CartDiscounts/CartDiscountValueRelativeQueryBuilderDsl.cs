// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountValueRelativeQueryBuilderDsl
    {
        public CartDiscountValueRelativeQueryBuilderDsl()
        {
        }

        public static CartDiscountValueRelativeQueryBuilderDsl Of()
        {
            return new CartDiscountValueRelativeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountValueRelativeQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueRelativeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartDiscountValueRelativeQueryBuilderDsl>(p, CartDiscountValueRelativeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountValueRelativeQueryBuilderDsl, long> Permyriad()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueRelativeQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permyriad")),
            p => new CombinationQueryPredicate<CartDiscountValueRelativeQueryBuilderDsl>(p, CartDiscountValueRelativeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartDiscountValueRelativeQueryBuilderDsl, string> ApplicationMode()
        {
            return new ComparisonPredicateBuilder<CartDiscountValueRelativeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("applicationMode")),
            p => new CombinationQueryPredicate<CartDiscountValueRelativeQueryBuilderDsl>(p, CartDiscountValueRelativeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
