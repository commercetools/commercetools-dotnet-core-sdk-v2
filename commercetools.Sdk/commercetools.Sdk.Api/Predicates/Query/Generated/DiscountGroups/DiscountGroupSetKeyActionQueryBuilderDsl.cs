// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountGroups
{

    public partial class DiscountGroupSetKeyActionQueryBuilderDsl
    {
        public DiscountGroupSetKeyActionQueryBuilderDsl()
        {
        }

        public static DiscountGroupSetKeyActionQueryBuilderDsl Of()
        {
            return new DiscountGroupSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountGroupSetKeyActionQueryBuilderDsl>(p, DiscountGroupSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<DiscountGroupSetKeyActionQueryBuilderDsl>(p, DiscountGroupSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
