using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentResponsesErrorResponseQueryBuilderDsl
    {
        public AgentResponsesErrorResponseQueryBuilderDsl()
        {
        }

        public static AgentResponsesErrorResponseQueryBuilderDsl Of()
        {
            return new AgentResponsesErrorResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentResponsesErrorResponseQueryBuilderDsl, long> StatusCode()
        {
            return new ComparisonPredicateBuilder<AgentResponsesErrorResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("statusCode")),
            p => new CombinationQueryPredicate<AgentResponsesErrorResponseQueryBuilderDsl>(p, AgentResponsesErrorResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentResponsesErrorResponseQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentResponsesErrorResponseQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentResponsesErrorResponseQueryBuilderDsl>(p, AgentResponsesErrorResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AgentResponsesErrorResponseQueryBuilderDsl> Errors(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesErrorResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("errors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl.Of())),
                AgentResponsesErrorResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AgentResponsesErrorResponseQueryBuilderDsl> Errors()
        {
            return new CollectionPredicateBuilder<AgentResponsesErrorResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("errors")),
                    p => new CombinationQueryPredicate<AgentResponsesErrorResponseQueryBuilderDsl>(p, AgentResponsesErrorResponseQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<AgentResponsesErrorResponseQueryBuilderDsl, string> ThreadId()
        {
            return new ComparisonPredicateBuilder<AgentResponsesErrorResponseQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("threadId")),
            p => new CombinationQueryPredicate<AgentResponsesErrorResponseQueryBuilderDsl>(p, AgentResponsesErrorResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
