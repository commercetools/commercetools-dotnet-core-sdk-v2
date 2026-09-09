using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentResponsesAuthErrorQueryBuilderDsl
    {
        public AgentResponsesAuthErrorQueryBuilderDsl()
        {
        }

        public static AgentResponsesAuthErrorQueryBuilderDsl Of()
        {
            return new AgentResponsesAuthErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentResponsesAuthErrorQueryBuilderDsl, long> StatusCode()
        {
            return new ComparisonPredicateBuilder<AgentResponsesAuthErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("statusCode")),
            p => new CombinationQueryPredicate<AgentResponsesAuthErrorQueryBuilderDsl>(p, AgentResponsesAuthErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentResponsesAuthErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentResponsesAuthErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentResponsesAuthErrorQueryBuilderDsl>(p, AgentResponsesAuthErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AgentResponsesAuthErrorQueryBuilderDsl> Errors(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AgentResponsesAuthErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("errors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl.Of())),
                AgentResponsesAuthErrorQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AgentResponsesAuthErrorQueryBuilderDsl> Errors()
        {
            return new CollectionPredicateBuilder<AgentResponsesAuthErrorQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("errors")),
                    p => new CombinationQueryPredicate<AgentResponsesAuthErrorQueryBuilderDsl>(p, AgentResponsesAuthErrorQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<AgentResponsesAuthErrorQueryBuilderDsl, string> Error()
        {
            return new ComparisonPredicateBuilder<AgentResponsesAuthErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("error")),
            p => new CombinationQueryPredicate<AgentResponsesAuthErrorQueryBuilderDsl>(p, AgentResponsesAuthErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentResponsesAuthErrorQueryBuilderDsl, string> ErrorDescription()
        {
            return new ComparisonPredicateBuilder<AgentResponsesAuthErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("error_description")),
            p => new CombinationQueryPredicate<AgentResponsesAuthErrorQueryBuilderDsl>(p, AgentResponsesAuthErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
