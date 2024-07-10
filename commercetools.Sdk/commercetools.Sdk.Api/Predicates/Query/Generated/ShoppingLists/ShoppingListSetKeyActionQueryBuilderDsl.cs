// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListSetKeyActionQueryBuilderDsl
    {
        public ShoppingListSetKeyActionQueryBuilderDsl()
        {
        }

        public static ShoppingListSetKeyActionQueryBuilderDsl Of()
        {
            return new ShoppingListSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListSetKeyActionQueryBuilderDsl>(p, ShoppingListSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ShoppingListSetKeyActionQueryBuilderDsl>(p, ShoppingListSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
