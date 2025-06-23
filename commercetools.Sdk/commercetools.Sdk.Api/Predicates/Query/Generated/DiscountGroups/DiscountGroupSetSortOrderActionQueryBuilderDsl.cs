// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountGroups
{

    public partial class DiscountGroupSetSortOrderActionQueryBuilderDsl
    {
        public DiscountGroupSetSortOrderActionQueryBuilderDsl()
        {
        }

        public static DiscountGroupSetSortOrderActionQueryBuilderDsl Of()
        {
            return new DiscountGroupSetSortOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupSetSortOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSetSortOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountGroupSetSortOrderActionQueryBuilderDsl>(p, DiscountGroupSetSortOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupSetSortOrderActionQueryBuilderDsl, string> SortOrder()
        {
            return new ComparisonPredicateBuilder<DiscountGroupSetSortOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sortOrder")),
            p => new CombinationQueryPredicate<DiscountGroupSetSortOrderActionQueryBuilderDsl>(p, DiscountGroupSetSortOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
