using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListSetSlugActionQueryBuilderDsl
    {
        public ShoppingListSetSlugActionQueryBuilderDsl()
        {
        }

        public static ShoppingListSetSlugActionQueryBuilderDsl Of()
        {
            return new ShoppingListSetSlugActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListSetSlugActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetSlugActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListSetSlugActionQueryBuilderDsl>(p, ShoppingListSetSlugActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListSetSlugActionQueryBuilderDsl> Slug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListSetSlugActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("slug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShoppingListSetSlugActionQueryBuilderDsl.Of);
        }


    }
}
