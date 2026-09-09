using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentResponsesMultipartRequestQueryBuilderDsl
    {
        public AgentResponsesMultipartRequestQueryBuilderDsl()
        {
        }

        public static AgentResponsesMultipartRequestQueryBuilderDsl Of()
        {
            return new AgentResponsesMultipartRequestQueryBuilderDsl();
        }

        public CombinationQueryPredicate<AgentResponsesMultipartRequestQueryBuilderDsl> Payload(
            Func<commercetools.Sdk.Api.Predicates.Query.Agents.AgentResponsesPayloadQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Agents.AgentResponsesPayloadQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesMultipartRequestQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("payload"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Agents.AgentResponsesPayloadQueryBuilderDsl.Of())),
                AgentResponsesMultipartRequestQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AgentResponsesMultipartRequestQueryBuilderDsl, string> Files()
        {
            return new ComparisonPredicateBuilder<AgentResponsesMultipartRequestQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("files")),
            p => new CombinationQueryPredicate<AgentResponsesMultipartRequestQueryBuilderDsl>(p, AgentResponsesMultipartRequestQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
