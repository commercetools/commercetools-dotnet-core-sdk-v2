using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitChangeApprovalRuleModeActionQueryBuilderDsl
    {
        public BusinessUnitChangeApprovalRuleModeActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitChangeApprovalRuleModeActionQueryBuilderDsl Of()
        {
            return new BusinessUnitChangeApprovalRuleModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitChangeApprovalRuleModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitChangeApprovalRuleModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitChangeApprovalRuleModeActionQueryBuilderDsl>(p, BusinessUnitChangeApprovalRuleModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitChangeApprovalRuleModeActionQueryBuilderDsl, string> ApprovalRuleMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitChangeApprovalRuleModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("approvalRuleMode")),
            p => new CombinationQueryPredicate<BusinessUnitChangeApprovalRuleModeActionQueryBuilderDsl>(p, BusinessUnitChangeApprovalRuleModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
