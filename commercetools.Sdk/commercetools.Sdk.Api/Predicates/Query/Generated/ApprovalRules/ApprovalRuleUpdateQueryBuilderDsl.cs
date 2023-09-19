using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApprovalRuleUpdateQueryBuilderDsl
    {
        public ApprovalRuleUpdateQueryBuilderDsl()
        {
        }

        public static ApprovalRuleUpdateQueryBuilderDsl Of()
        {
            return new ApprovalRuleUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ApprovalRuleUpdateQueryBuilderDsl>(p, ApprovalRuleUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRuleUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleUpdateActionQueryBuilderDsl.Of())),
                ApprovalRuleUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalRuleUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<ApprovalRuleUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<ApprovalRuleUpdateQueryBuilderDsl>(p, ApprovalRuleUpdateQueryBuilderDsl.Of));
        }

    }
}
