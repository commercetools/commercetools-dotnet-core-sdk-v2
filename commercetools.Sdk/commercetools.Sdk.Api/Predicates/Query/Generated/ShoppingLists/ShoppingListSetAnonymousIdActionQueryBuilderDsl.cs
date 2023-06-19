// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListSetAnonymousIdActionQueryBuilderDsl
    {
        public ShoppingListSetAnonymousIdActionQueryBuilderDsl()
        {
        }

        public static ShoppingListSetAnonymousIdActionQueryBuilderDsl Of()
        {
            return new ShoppingListSetAnonymousIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListSetAnonymousIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetAnonymousIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListSetAnonymousIdActionQueryBuilderDsl>(p, ShoppingListSetAnonymousIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListSetAnonymousIdActionQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetAnonymousIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<ShoppingListSetAnonymousIdActionQueryBuilderDsl>(p, ShoppingListSetAnonymousIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
