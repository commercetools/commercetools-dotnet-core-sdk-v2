using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApprovalRuleSetApproversActionQueryBuilderDsl
    {
        public ApprovalRuleSetApproversActionQueryBuilderDsl()
        {
        }

        public static ApprovalRuleSetApproversActionQueryBuilderDsl Of()
        {
            return new ApprovalRuleSetApproversActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleSetApproversActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleSetApproversActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ApprovalRuleSetApproversActionQueryBuilderDsl>(p, ApprovalRuleSetApproversActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRuleSetApproversActionQueryBuilderDsl> Approvers(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverHierarchyDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverHierarchyDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleSetApproversActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("approvers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverHierarchyDraftQueryBuilderDsl.Of())),
                ApprovalRuleSetApproversActionQueryBuilderDsl.Of);
        }


    }
}
