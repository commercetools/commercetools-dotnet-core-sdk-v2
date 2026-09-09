using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentResponsesCartSuccessQueryBuilderDsl
    {
        public AgentResponsesCartSuccessQueryBuilderDsl()
        {
        }

        public static AgentResponsesCartSuccessQueryBuilderDsl Of()
        {
            return new AgentResponsesCartSuccessQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentResponsesCartSuccessQueryBuilderDsl, string> EntityType()
        {
            return new ComparisonPredicateBuilder<AgentResponsesCartSuccessQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("entityType")),
            p => new CombinationQueryPredicate<AgentResponsesCartSuccessQueryBuilderDsl>(p, AgentResponsesCartSuccessQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AgentResponsesCartSuccessQueryBuilderDsl> Warnings(
            Func<commercetools.Sdk.Api.Predicates.Query.Warnings.WarningObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Warnings.WarningObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesCartSuccessQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("warnings"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Warnings.WarningObjectQueryBuilderDsl.Of())),
                AgentResponsesCartSuccessQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AgentResponsesCartSuccessQueryBuilderDsl> Warnings()
        {
            return new CollectionPredicateBuilder<AgentResponsesCartSuccessQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("warnings")),
                    p => new CombinationQueryPredicate<AgentResponsesCartSuccessQueryBuilderDsl>(p, AgentResponsesCartSuccessQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<AgentResponsesCartSuccessQueryBuilderDsl, string> ThreadId()
        {
            return new ComparisonPredicateBuilder<AgentResponsesCartSuccessQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("threadId")),
            p => new CombinationQueryPredicate<AgentResponsesCartSuccessQueryBuilderDsl>(p, AgentResponsesCartSuccessQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AgentResponsesCartSuccessQueryBuilderDsl> Entity(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesCartSuccessQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("entity"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartQueryBuilderDsl.Of())),
                AgentResponsesCartSuccessQueryBuilderDsl.Of);
        }


    }
}
