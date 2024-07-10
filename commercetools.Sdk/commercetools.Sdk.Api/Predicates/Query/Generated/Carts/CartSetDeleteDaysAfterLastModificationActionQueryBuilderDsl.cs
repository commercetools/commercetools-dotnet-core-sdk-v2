// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl
    {
        public CartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl()
        {
        }

        public static CartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl Of()
        {
            return new CartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl>(p, CartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, long> DeleteDaysAfterLastModification()
        {
            return new ComparisonPredicateBuilder<CartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deleteDaysAfterLastModification")),
            p => new CombinationQueryPredicate<CartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl>(p, CartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
