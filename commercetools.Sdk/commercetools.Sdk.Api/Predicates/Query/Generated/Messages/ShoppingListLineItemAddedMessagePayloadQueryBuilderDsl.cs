using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ShoppingListLineItemAddedMessagePayloadQueryBuilderDsl
    {
        public ShoppingListLineItemAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ShoppingListLineItemAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new ShoppingListLineItemAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListLineItemAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ShoppingListLineItemAddedMessagePayloadQueryBuilderDsl>(p, ShoppingListLineItemAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListLineItemAddedMessagePayloadQueryBuilderDsl> LineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListLineItemAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lineItem"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemQueryBuilderDsl.Of())),
                ShoppingListLineItemAddedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
