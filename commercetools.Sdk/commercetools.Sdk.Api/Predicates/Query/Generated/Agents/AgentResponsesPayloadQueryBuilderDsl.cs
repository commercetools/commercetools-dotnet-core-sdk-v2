using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentResponsesPayloadQueryBuilderDsl
    {
        public AgentResponsesPayloadQueryBuilderDsl()
        {
        }

        public static AgentResponsesPayloadQueryBuilderDsl Of()
        {
            return new AgentResponsesPayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentResponsesPayloadQueryBuilderDsl, string> OutputType()
        {
            return new ComparisonPredicateBuilder<AgentResponsesPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("outputType")),
            p => new CombinationQueryPredicate<AgentResponsesPayloadQueryBuilderDsl>(p, AgentResponsesPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentResponsesPayloadQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<AgentResponsesPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<AgentResponsesPayloadQueryBuilderDsl>(p, AgentResponsesPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentResponsesPayloadQueryBuilderDsl, string> Prompt()
        {
            return new ComparisonPredicateBuilder<AgentResponsesPayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("prompt")),
            p => new CombinationQueryPredicate<AgentResponsesPayloadQueryBuilderDsl>(p, AgentResponsesPayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AgentResponsesPayloadQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesPayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl.Of())),
                AgentResponsesPayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AgentResponsesPayloadQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesPayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                AgentResponsesPayloadQueryBuilderDsl.Of);
        }


    }
}
