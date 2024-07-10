using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApprovalRuleUpdateActionQueryBuilderDsl
    {
        public ApprovalRuleUpdateActionQueryBuilderDsl()
        {
        }

        public static ApprovalRuleUpdateActionQueryBuilderDsl Of()
        {
            return new ApprovalRuleUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ApprovalRuleUpdateActionQueryBuilderDsl>(p, ApprovalRuleUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ApprovalRuleUpdateActionQueryBuilderDsl> AsSetApprovers(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetApproversActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetApproversActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetApproversActionQueryBuilderDsl.Of()),
                ApprovalRuleUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ApprovalRuleUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetDescriptionActionQueryBuilderDsl.Of()),
                ApprovalRuleUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ApprovalRuleUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetKeyActionQueryBuilderDsl.Of()),
                ApprovalRuleUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ApprovalRuleUpdateActionQueryBuilderDsl> AsSetName(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetNameActionQueryBuilderDsl.Of()),
                ApprovalRuleUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ApprovalRuleUpdateActionQueryBuilderDsl> AsSetPredicate(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetPredicateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetPredicateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetPredicateActionQueryBuilderDsl.Of()),
                ApprovalRuleUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ApprovalRuleUpdateActionQueryBuilderDsl> AsSetRequesters(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetRequestersActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetRequestersActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetRequestersActionQueryBuilderDsl.Of()),
                ApprovalRuleUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ApprovalRuleUpdateActionQueryBuilderDsl> AsSetStatus(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetStatusActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetStatusActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleSetStatusActionQueryBuilderDsl.Of()),
                ApprovalRuleUpdateActionQueryBuilderDsl.Of);
        }
    }
}
