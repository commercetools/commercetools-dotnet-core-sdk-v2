using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StorePrivacyPolicyUrlSetMessageQueryBuilderDsl
    {
        public StorePrivacyPolicyUrlSetMessageQueryBuilderDsl()
        {
        }

        public static StorePrivacyPolicyUrlSetMessageQueryBuilderDsl Of()
        {
            return new StorePrivacyPolicyUrlSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl>(p, StorePrivacyPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl>(p, StorePrivacyPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl>(p, StorePrivacyPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl>(p, StorePrivacyPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StorePrivacyPolicyUrlSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StorePrivacyPolicyUrlSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl>(p, StorePrivacyPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StorePrivacyPolicyUrlSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl>(p, StorePrivacyPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl>(p, StorePrivacyPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StorePrivacyPolicyUrlSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, string> PrivacyPolicyUrl()
        {
            return new ComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("privacyPolicyUrl")),
            p => new CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessageQueryBuilderDsl>(p, StorePrivacyPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
