using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentResponsesSuccessQueryBuilderDsl
    {
        public AgentResponsesSuccessQueryBuilderDsl()
        {
        }

        public static AgentResponsesSuccessQueryBuilderDsl Of()
        {
            return new AgentResponsesSuccessQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentResponsesSuccessQueryBuilderDsl, string> EntityType()
        {
            return new ComparisonPredicateBuilder<AgentResponsesSuccessQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("entityType")),
            p => new CombinationQueryPredicate<AgentResponsesSuccessQueryBuilderDsl>(p, AgentResponsesSuccessQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AgentResponsesSuccessQueryBuilderDsl> Warnings(
            Func<commercetools.Sdk.Api.Predicates.Query.Warnings.WarningObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Warnings.WarningObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesSuccessQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("warnings"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Warnings.WarningObjectQueryBuilderDsl.Of())),
                AgentResponsesSuccessQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AgentResponsesSuccessQueryBuilderDsl> Warnings()
        {
            return new CollectionPredicateBuilder<AgentResponsesSuccessQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("warnings")),
                    p => new CombinationQueryPredicate<AgentResponsesSuccessQueryBuilderDsl>(p, AgentResponsesSuccessQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<AgentResponsesSuccessQueryBuilderDsl, string> ThreadId()
        {
            return new ComparisonPredicateBuilder<AgentResponsesSuccessQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("threadId")),
            p => new CombinationQueryPredicate<AgentResponsesSuccessQueryBuilderDsl>(p, AgentResponsesSuccessQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<AgentResponsesSuccessQueryBuilderDsl> AsCart(
            Func<commercetools.Sdk.Api.Predicates.Query.Agents.AgentResponsesCartSuccessQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Agents.AgentResponsesCartSuccessQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesSuccessQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Agents.AgentResponsesCartSuccessQueryBuilderDsl.Of()),
                AgentResponsesSuccessQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AgentResponsesSuccessQueryBuilderDsl> AsQuoteRequest(
            Func<commercetools.Sdk.Api.Predicates.Query.Agents.AgentResponsesQuoteRequestSuccessQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Agents.AgentResponsesQuoteRequestSuccessQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesSuccessQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Agents.AgentResponsesQuoteRequestSuccessQueryBuilderDsl.Of()),
                AgentResponsesSuccessQueryBuilderDsl.Of);
        }
    }
}
