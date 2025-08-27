// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountGroups
{

    public partial class DiscountGroupSetIsActiveActionQueryBuilderDsl
    {
        public DiscountGroupSetIsActiveActionQueryBuilderDsl()
        {
        }

        public static DiscountGroupSetIsActiveActionQueryBuilderDsl Of()
        {
            return new DiscountGroupSetIsActiveActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupSetIsActiveActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSetIsActiveActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountGroupSetIsActiveActionQueryBuilderDsl>(p, DiscountGroupSetIsActiveActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupSetIsActiveActionQueryBuilderDsl, bool> IsActive()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSetIsActiveActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isActive")),
            p => new CombinationQueryPredicate<DiscountGroupSetIsActiveActionQueryBuilderDsl>(p, DiscountGroupSetIsActiveActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
