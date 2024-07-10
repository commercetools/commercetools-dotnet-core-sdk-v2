// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl
    {
        public ShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl()
        {
        }

        public static ShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl Of()
        {
            return new ShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl>(p, ShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, long> DeleteDaysAfterLastModification()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deleteDaysAfterLastModification")),
            p => new CombinationQueryPredicate<ShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl>(p, ShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
