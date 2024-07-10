using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ReturnInfoSetMessageQueryBuilderDsl
    {
        public ReturnInfoSetMessageQueryBuilderDsl()
        {
        }

        public static ReturnInfoSetMessageQueryBuilderDsl Of()
        {
            return new ReturnInfoSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl>(p, ReturnInfoSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl>(p, ReturnInfoSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl>(p, ReturnInfoSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl>(p, ReturnInfoSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ReturnInfoSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ReturnInfoSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl>(p, ReturnInfoSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ReturnInfoSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl>(p, ReturnInfoSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl>(p, ReturnInfoSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ReturnInfoSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl> ReturnInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("returnInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoQueryBuilderDsl.Of())),
                ReturnInfoSetMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl> ReturnInfo()
        {
            return new CollectionPredicateBuilder<ReturnInfoSetMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnInfo")),
                    p => new CombinationQueryPredicate<ReturnInfoSetMessageQueryBuilderDsl>(p, ReturnInfoSetMessageQueryBuilderDsl.Of));
        }

    }
}
