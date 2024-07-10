using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class QuoteCreatedMessageQueryBuilderDsl
    {
        public QuoteCreatedMessageQueryBuilderDsl()
        {
        }

        public static QuoteCreatedMessageQueryBuilderDsl Of()
        {
            return new QuoteCreatedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteCreatedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<QuoteCreatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl>(p, QuoteCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteCreatedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<QuoteCreatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl>(p, QuoteCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteCreatedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<QuoteCreatedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl>(p, QuoteCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteCreatedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<QuoteCreatedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl>(p, QuoteCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                QuoteCreatedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                QuoteCreatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteCreatedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<QuoteCreatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl>(p, QuoteCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                QuoteCreatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteCreatedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<QuoteCreatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl>(p, QuoteCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteCreatedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<QuoteCreatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl>(p, QuoteCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                QuoteCreatedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl> Quote(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("quote"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteQueryBuilderDsl.Of())),
                QuoteCreatedMessageQueryBuilderDsl.Of);
        }


    }
}
