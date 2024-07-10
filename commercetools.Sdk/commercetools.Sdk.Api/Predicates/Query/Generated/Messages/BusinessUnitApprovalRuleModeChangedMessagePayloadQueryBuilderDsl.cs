using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl, string> ApprovalRuleMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("approvalRuleMode")),
            p => new CombinationQueryPredicate<BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl, string> OldApprovalRuleMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldApprovalRuleMode")),
            p => new CombinationQueryPredicate<BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitApprovalRuleModeChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
