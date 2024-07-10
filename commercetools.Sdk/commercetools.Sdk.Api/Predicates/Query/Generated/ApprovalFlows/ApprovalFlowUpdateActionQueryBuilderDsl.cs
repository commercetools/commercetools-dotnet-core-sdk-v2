using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalFlows
{

    public partial class ApprovalFlowUpdateActionQueryBuilderDsl
    {
        public ApprovalFlowUpdateActionQueryBuilderDsl()
        {
        }

        public static ApprovalFlowUpdateActionQueryBuilderDsl Of()
        {
            return new ApprovalFlowUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalFlowUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ApprovalFlowUpdateActionQueryBuilderDsl>(p, ApprovalFlowUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ApprovalFlowUpdateActionQueryBuilderDsl> AsApprove(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowApproveActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowApproveActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowApproveActionQueryBuilderDsl.Of()),
                ApprovalFlowUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ApprovalFlowUpdateActionQueryBuilderDsl> AsReject(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowRejectActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowRejectActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowRejectActionQueryBuilderDsl.Of()),
                ApprovalFlowUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ApprovalFlowUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowSetCustomFieldActionQueryBuilderDsl.Of()),
                ApprovalFlowUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ApprovalFlowUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowSetCustomTypeActionQueryBuilderDsl.Of()),
                ApprovalFlowUpdateActionQueryBuilderDsl.Of);
        }
    }
}
