using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditUpdateActionQueryBuilderDsl
    {
        public OrderEditUpdateActionQueryBuilderDsl()
        {
        }

        public static OrderEditUpdateActionQueryBuilderDsl Of()
        {
            return new OrderEditUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderEditUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderEditUpdateActionQueryBuilderDsl>(p, OrderEditUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<OrderEditUpdateActionQueryBuilderDsl> AsAddStagedAction(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditAddStagedActionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditAddStagedActionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditAddStagedActionActionQueryBuilderDsl.Of()),
                OrderEditUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderEditUpdateActionQueryBuilderDsl> AsSetComment(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditSetCommentActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditSetCommentActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditSetCommentActionQueryBuilderDsl.Of()),
                OrderEditUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderEditUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditSetCustomFieldActionQueryBuilderDsl.Of()),
                OrderEditUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderEditUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditSetCustomTypeActionQueryBuilderDsl.Of()),
                OrderEditUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderEditUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditSetKeyActionQueryBuilderDsl.Of()),
                OrderEditUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderEditUpdateActionQueryBuilderDsl> AsSetStagedActions(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditSetStagedActionsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditSetStagedActionsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditSetStagedActionsActionQueryBuilderDsl.Of()),
                OrderEditUpdateActionQueryBuilderDsl.Of);
        }
    }
}
