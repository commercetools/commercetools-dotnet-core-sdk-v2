using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalFlowCreatedMessagePayloadQueryBuilderDsl
    {
        public ApprovalFlowCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ApprovalFlowCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new ApprovalFlowCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalFlowCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalFlowCreatedMessagePayloadQueryBuilderDsl>(p, ApprovalFlowCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalFlowCreatedMessagePayloadQueryBuilderDsl> ApprovalFlow(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("approvalFlow"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowQueryBuilderDsl.Of())),
                ApprovalFlowCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
