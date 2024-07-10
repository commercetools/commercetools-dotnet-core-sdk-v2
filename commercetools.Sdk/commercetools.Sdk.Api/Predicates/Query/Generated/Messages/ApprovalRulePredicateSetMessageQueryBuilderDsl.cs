using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalRulePredicateSetMessageQueryBuilderDsl
    {
        public ApprovalRulePredicateSetMessageQueryBuilderDsl()
        {
        }

        public static ApprovalRulePredicateSetMessageQueryBuilderDsl Of()
        {
            return new ApprovalRulePredicateSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl>(p, ApprovalRulePredicateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl>(p, ApprovalRulePredicateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl>(p, ApprovalRulePredicateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl>(p, ApprovalRulePredicateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ApprovalRulePredicateSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ApprovalRulePredicateSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl>(p, ApprovalRulePredicateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ApprovalRulePredicateSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl>(p, ApprovalRulePredicateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl>(p, ApprovalRulePredicateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ApprovalRulePredicateSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl>(p, ApprovalRulePredicateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, string> OldPredicate()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePredicateSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldPredicate")),
            p => new CombinationQueryPredicate<ApprovalRulePredicateSetMessageQueryBuilderDsl>(p, ApprovalRulePredicateSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
