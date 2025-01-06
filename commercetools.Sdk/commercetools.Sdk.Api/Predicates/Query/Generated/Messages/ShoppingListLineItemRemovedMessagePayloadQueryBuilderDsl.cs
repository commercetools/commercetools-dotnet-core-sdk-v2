using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ShoppingListLineItemRemovedMessagePayloadQueryBuilderDsl
    {
        public ShoppingListLineItemRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ShoppingListLineItemRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new ShoppingListLineItemRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListLineItemRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ShoppingListLineItemRemovedMessagePayloadQueryBuilderDsl>(p, ShoppingListLineItemRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListLineItemRemovedMessagePayloadQueryBuilderDsl> LineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListLineItemRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lineItem"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemQueryBuilderDsl.Of())),
                ShoppingListLineItemRemovedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
