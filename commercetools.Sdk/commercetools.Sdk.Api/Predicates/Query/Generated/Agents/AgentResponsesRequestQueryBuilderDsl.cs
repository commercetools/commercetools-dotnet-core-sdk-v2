using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentResponsesRequestQueryBuilderDsl
    {
        public AgentResponsesRequestQueryBuilderDsl()
        {
        }

        public static AgentResponsesRequestQueryBuilderDsl Of()
        {
            return new AgentResponsesRequestQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentResponsesRequestQueryBuilderDsl, string> OutputType()
        {
            return new ComparisonPredicateBuilder<AgentResponsesRequestQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("outputType")),
            p => new CombinationQueryPredicate<AgentResponsesRequestQueryBuilderDsl>(p, AgentResponsesRequestQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentResponsesRequestQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<AgentResponsesRequestQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<AgentResponsesRequestQueryBuilderDsl>(p, AgentResponsesRequestQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentResponsesRequestQueryBuilderDsl, string> Prompt()
        {
            return new ComparisonPredicateBuilder<AgentResponsesRequestQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("prompt")),
            p => new CombinationQueryPredicate<AgentResponsesRequestQueryBuilderDsl>(p, AgentResponsesRequestQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AgentResponsesRequestQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesRequestQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl.Of())),
                AgentResponsesRequestQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AgentResponsesRequestQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesRequestQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                AgentResponsesRequestQueryBuilderDsl.Of);
        }


    }
}
