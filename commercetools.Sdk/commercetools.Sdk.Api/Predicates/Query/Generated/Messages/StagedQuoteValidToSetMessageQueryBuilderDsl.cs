using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StagedQuoteValidToSetMessageQueryBuilderDsl
    {
        public StagedQuoteValidToSetMessageQueryBuilderDsl()
        {
        }

        public static StagedQuoteValidToSetMessageQueryBuilderDsl Of()
        {
            return new StagedQuoteValidToSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl>(p, StagedQuoteValidToSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl>(p, StagedQuoteValidToSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl>(p, StagedQuoteValidToSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl>(p, StagedQuoteValidToSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StagedQuoteValidToSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StagedQuoteValidToSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl>(p, StagedQuoteValidToSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StagedQuoteValidToSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl>(p, StagedQuoteValidToSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl>(p, StagedQuoteValidToSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StagedQuoteValidToSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, DateTime> ValidTo()
        {
            return new ComparisonPredicateBuilder<StagedQuoteValidToSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validTo")),
            p => new CombinationQueryPredicate<StagedQuoteValidToSetMessageQueryBuilderDsl>(p, StagedQuoteValidToSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
