using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentResponsesQuoteRequestSuccessQueryBuilderDsl
    {
        public AgentResponsesQuoteRequestSuccessQueryBuilderDsl()
        {
        }

        public static AgentResponsesQuoteRequestSuccessQueryBuilderDsl Of()
        {
            return new AgentResponsesQuoteRequestSuccessQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentResponsesQuoteRequestSuccessQueryBuilderDsl, string> EntityType()
        {
            return new ComparisonPredicateBuilder<AgentResponsesQuoteRequestSuccessQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("entityType")),
            p => new CombinationQueryPredicate<AgentResponsesQuoteRequestSuccessQueryBuilderDsl>(p, AgentResponsesQuoteRequestSuccessQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AgentResponsesQuoteRequestSuccessQueryBuilderDsl> Warnings(
            Func<commercetools.Sdk.Api.Predicates.Query.Warnings.WarningObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Warnings.WarningObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesQuoteRequestSuccessQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("warnings"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Warnings.WarningObjectQueryBuilderDsl.Of())),
                AgentResponsesQuoteRequestSuccessQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AgentResponsesQuoteRequestSuccessQueryBuilderDsl> Warnings()
        {
            return new CollectionPredicateBuilder<AgentResponsesQuoteRequestSuccessQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("warnings")),
                    p => new CombinationQueryPredicate<AgentResponsesQuoteRequestSuccessQueryBuilderDsl>(p, AgentResponsesQuoteRequestSuccessQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<AgentResponsesQuoteRequestSuccessQueryBuilderDsl, string> ThreadId()
        {
            return new ComparisonPredicateBuilder<AgentResponsesQuoteRequestSuccessQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("threadId")),
            p => new CombinationQueryPredicate<AgentResponsesQuoteRequestSuccessQueryBuilderDsl>(p, AgentResponsesQuoteRequestSuccessQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AgentResponsesQuoteRequestSuccessQueryBuilderDsl> Entity(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesQuoteRequestSuccessQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("entity"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestQueryBuilderDsl.Of())),
                AgentResponsesQuoteRequestSuccessQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AgentResponsesQuoteRequestSuccessQueryBuilderDsl, string> CartId()
        {
            return new ComparisonPredicateBuilder<AgentResponsesQuoteRequestSuccessQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartId")),
            p => new CombinationQueryPredicate<AgentResponsesQuoteRequestSuccessQueryBuilderDsl>(p, AgentResponsesQuoteRequestSuccessQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
