using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class QuoteRenegotiationRequestedMessageQueryBuilderDsl
    {
        public QuoteRenegotiationRequestedMessageQueryBuilderDsl()
        {
        }

        public static QuoteRenegotiationRequestedMessageQueryBuilderDsl Of()
        {
            return new QuoteRenegotiationRequestedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl>(p, QuoteRenegotiationRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl>(p, QuoteRenegotiationRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl>(p, QuoteRenegotiationRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl>(p, QuoteRenegotiationRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                QuoteRenegotiationRequestedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                QuoteRenegotiationRequestedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl>(p, QuoteRenegotiationRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                QuoteRenegotiationRequestedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl>(p, QuoteRenegotiationRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl>(p, QuoteRenegotiationRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                QuoteRenegotiationRequestedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, string> BuyerComment()
        {
            return new ComparisonPredicateBuilder<QuoteRenegotiationRequestedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("buyerComment")),
            p => new CombinationQueryPredicate<QuoteRenegotiationRequestedMessageQueryBuilderDsl>(p, QuoteRenegotiationRequestedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
