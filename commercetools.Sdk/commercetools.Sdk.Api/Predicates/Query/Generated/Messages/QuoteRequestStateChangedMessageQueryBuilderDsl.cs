using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class QuoteRequestStateChangedMessageQueryBuilderDsl
    {
        public QuoteRequestStateChangedMessageQueryBuilderDsl()
        {
        }

        public static QuoteRequestStateChangedMessageQueryBuilderDsl Of()
        {
            return new QuoteRequestStateChangedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl>(p, QuoteRequestStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl>(p, QuoteRequestStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl>(p, QuoteRequestStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl>(p, QuoteRequestStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                QuoteRequestStateChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                QuoteRequestStateChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl>(p, QuoteRequestStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                QuoteRequestStateChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl>(p, QuoteRequestStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl>(p, QuoteRequestStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                QuoteRequestStateChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, string> QuoteRequestState()
        {
            return new ComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quoteRequestState")),
            p => new CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl>(p, QuoteRequestStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, string> OldQuoteRequestState()
        {
            return new ComparisonPredicateBuilder<QuoteRequestStateChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldQuoteRequestState")),
            p => new CombinationQueryPredicate<QuoteRequestStateChangedMessageQueryBuilderDsl>(p, QuoteRequestStateChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
