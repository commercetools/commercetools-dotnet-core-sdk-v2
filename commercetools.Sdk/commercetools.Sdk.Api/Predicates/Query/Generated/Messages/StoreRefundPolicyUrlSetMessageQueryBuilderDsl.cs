using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreRefundPolicyUrlSetMessageQueryBuilderDsl
    {
        public StoreRefundPolicyUrlSetMessageQueryBuilderDsl()
        {
        }

        public static StoreRefundPolicyUrlSetMessageQueryBuilderDsl Of()
        {
            return new StoreRefundPolicyUrlSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl>(p, StoreRefundPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl>(p, StoreRefundPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl>(p, StoreRefundPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl>(p, StoreRefundPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StoreRefundPolicyUrlSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StoreRefundPolicyUrlSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl>(p, StoreRefundPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StoreRefundPolicyUrlSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl>(p, StoreRefundPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl>(p, StoreRefundPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StoreRefundPolicyUrlSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, string> RefundPolicyUrl()
        {
            return new ComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("refundPolicyUrl")),
            p => new CombinationQueryPredicate<StoreRefundPolicyUrlSetMessageQueryBuilderDsl>(p, StoreRefundPolicyUrlSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
