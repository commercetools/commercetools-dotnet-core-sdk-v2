using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl
    {
        public ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl Of()
        {
            return new ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl> Approvers(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverHierarchyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverHierarchyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("approvers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverHierarchyQueryBuilderDsl.Of())),
                ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl> OldApprovers(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverHierarchyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverHierarchyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldApprovers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApproverHierarchyQueryBuilderDsl.Of())),
                ApprovalRuleApproversSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
