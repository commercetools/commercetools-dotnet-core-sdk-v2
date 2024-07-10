using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalFlows
{

    public partial class ApprovalFlowSetCustomFieldActionQueryBuilderDsl
    {
        public ApprovalFlowSetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static ApprovalFlowSetCustomFieldActionQueryBuilderDsl Of()
        {
            return new ApprovalFlowSetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalFlowSetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ApprovalFlowSetCustomFieldActionQueryBuilderDsl>(p, ApprovalFlowSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalFlowSetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ApprovalFlowSetCustomFieldActionQueryBuilderDsl>(p, ApprovalFlowSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalFlowSetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ApprovalFlowSetCustomFieldActionQueryBuilderDsl>(p, ApprovalFlowSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
