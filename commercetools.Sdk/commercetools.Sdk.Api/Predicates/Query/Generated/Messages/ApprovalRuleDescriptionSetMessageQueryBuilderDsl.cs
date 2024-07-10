using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalRuleDescriptionSetMessageQueryBuilderDsl
    {
        public ApprovalRuleDescriptionSetMessageQueryBuilderDsl()
        {
        }

        public static ApprovalRuleDescriptionSetMessageQueryBuilderDsl Of()
        {
            return new ApprovalRuleDescriptionSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl>(p, ApprovalRuleDescriptionSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl>(p, ApprovalRuleDescriptionSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl>(p, ApprovalRuleDescriptionSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl>(p, ApprovalRuleDescriptionSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ApprovalRuleDescriptionSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ApprovalRuleDescriptionSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl>(p, ApprovalRuleDescriptionSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ApprovalRuleDescriptionSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl>(p, ApprovalRuleDescriptionSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl>(p, ApprovalRuleDescriptionSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ApprovalRuleDescriptionSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl>(p, ApprovalRuleDescriptionSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, string> OldDescription()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldDescription")),
            p => new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessageQueryBuilderDsl>(p, ApprovalRuleDescriptionSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
