using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ShoppingListMessagePayloadQueryBuilderDsl
    {
        public ShoppingListMessagePayloadQueryBuilderDsl()
        {
        }

        public static ShoppingListMessagePayloadQueryBuilderDsl Of()
        {
            return new ShoppingListMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ShoppingListMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ShoppingListMessagePayloadQueryBuilderDsl>(p, ShoppingListMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ShoppingListMessagePayloadQueryBuilderDsl> AsShoppingListLineItemAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListLineItemAddedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListLineItemAddedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListLineItemAddedMessagePayloadQueryBuilderDsl.Of()),
                ShoppingListMessagePayloadQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListMessagePayloadQueryBuilderDsl> AsShoppingListLineItemRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListLineItemRemovedMessagePayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListLineItemRemovedMessagePayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListMessagePayloadQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListLineItemRemovedMessagePayloadQueryBuilderDsl.Of()),
                ShoppingListMessagePayloadQueryBuilderDsl.Of);
        }
    }
}
