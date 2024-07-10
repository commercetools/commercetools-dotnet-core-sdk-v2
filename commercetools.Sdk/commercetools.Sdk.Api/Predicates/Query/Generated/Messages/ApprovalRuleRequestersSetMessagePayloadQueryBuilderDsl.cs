using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl
    {
        public ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl Of()
        {
            return new ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl> Requesters(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("requesters"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterQueryBuilderDsl.Of())),
                ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl> Requesters()
        {
            return new CollectionPredicateBuilder<ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("requesters")),
                    p => new CombinationQueryPredicate<ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl> OldRequesters(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldRequesters"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterQueryBuilderDsl.Of())),
                ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl> OldRequesters()
        {
            return new CollectionPredicateBuilder<ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldRequesters")),
                    p => new CombinationQueryPredicate<ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleRequestersSetMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
