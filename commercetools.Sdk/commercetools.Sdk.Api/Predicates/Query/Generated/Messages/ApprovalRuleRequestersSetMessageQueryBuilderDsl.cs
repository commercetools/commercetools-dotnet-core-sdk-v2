using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalRuleRequestersSetMessageQueryBuilderDsl
    {
        public ApprovalRuleRequestersSetMessageQueryBuilderDsl()
        {
        }

        public static ApprovalRuleRequestersSetMessageQueryBuilderDsl Of()
        {
            return new ApprovalRuleRequestersSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(p, ApprovalRuleRequestersSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(p, ApprovalRuleRequestersSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(p, ApprovalRuleRequestersSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(p, ApprovalRuleRequestersSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ApprovalRuleRequestersSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ApprovalRuleRequestersSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(p, ApprovalRuleRequestersSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ApprovalRuleRequestersSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(p, ApprovalRuleRequestersSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(p, ApprovalRuleRequestersSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ApprovalRuleRequestersSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl> Requesters(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("requesters"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterQueryBuilderDsl.Of())),
                ApprovalRuleRequestersSetMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl> Requesters()
        {
            return new CollectionPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("requesters")),
                    p => new CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(p, ApprovalRuleRequestersSetMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl> OldRequesters(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldRequesters"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterQueryBuilderDsl.Of())),
                ApprovalRuleRequestersSetMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl> OldRequesters()
        {
            return new CollectionPredicateBuilder<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldRequesters")),
                    p => new CombinationQueryPredicate<ApprovalRuleRequestersSetMessageQueryBuilderDsl>(p, ApprovalRuleRequestersSetMessageQueryBuilderDsl.Of));
        }

    }
}
