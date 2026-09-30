using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentResponsesShoppingListSuccessQueryBuilderDsl
    {
        public AgentResponsesShoppingListSuccessQueryBuilderDsl()
        {
        }

        public static AgentResponsesShoppingListSuccessQueryBuilderDsl Of()
        {
            return new AgentResponsesShoppingListSuccessQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentResponsesShoppingListSuccessQueryBuilderDsl, string> EntityType()
        {
            return new ComparisonPredicateBuilder<AgentResponsesShoppingListSuccessQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("entityType")),
            p => new CombinationQueryPredicate<AgentResponsesShoppingListSuccessQueryBuilderDsl>(p, AgentResponsesShoppingListSuccessQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AgentResponsesShoppingListSuccessQueryBuilderDsl> Warnings(
            Func<commercetools.Sdk.Api.Predicates.Query.Warnings.WarningObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Warnings.WarningObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesShoppingListSuccessQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("warnings"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Warnings.WarningObjectQueryBuilderDsl.Of())),
                AgentResponsesShoppingListSuccessQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AgentResponsesShoppingListSuccessQueryBuilderDsl> Warnings()
        {
            return new CollectionPredicateBuilder<AgentResponsesShoppingListSuccessQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("warnings")),
                    p => new CombinationQueryPredicate<AgentResponsesShoppingListSuccessQueryBuilderDsl>(p, AgentResponsesShoppingListSuccessQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<AgentResponsesShoppingListSuccessQueryBuilderDsl, string> ThreadId()
        {
            return new ComparisonPredicateBuilder<AgentResponsesShoppingListSuccessQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("threadId")),
            p => new CombinationQueryPredicate<AgentResponsesShoppingListSuccessQueryBuilderDsl>(p, AgentResponsesShoppingListSuccessQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AgentResponsesShoppingListSuccessQueryBuilderDsl> Entity(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesShoppingListSuccessQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("entity"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListQueryBuilderDsl.Of())),
                AgentResponsesShoppingListSuccessQueryBuilderDsl.Of);
        }


    }
}
