using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionQueryBuilderDsl
    {
        public ExtensionQueryBuilderDsl()
        {
        }

        public static ExtensionQueryBuilderDsl Of()
        {
            return new ExtensionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ExtensionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ExtensionQueryBuilderDsl>(p, ExtensionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ExtensionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ExtensionQueryBuilderDsl>(p, ExtensionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ExtensionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ExtensionQueryBuilderDsl>(p, ExtensionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ExtensionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ExtensionQueryBuilderDsl>(p, ExtensionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ExtensionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ExtensionQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ExtensionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ExtensionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ExtensionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ExtensionQueryBuilderDsl>(p, ExtensionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionQueryBuilderDsl> Destination(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionDestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionDestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("destination"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionDestinationQueryBuilderDsl.Of())),
                ExtensionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ExtensionQueryBuilderDsl> Triggers(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionTriggerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionTriggerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("triggers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionTriggerQueryBuilderDsl.Of())),
                ExtensionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ExtensionQueryBuilderDsl> Triggers()
        {
            return new CollectionPredicateBuilder<ExtensionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("triggers")),
                    p => new CombinationQueryPredicate<ExtensionQueryBuilderDsl>(p, ExtensionQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ExtensionQueryBuilderDsl, long> TimeoutInMs()
        {
            return new ComparisonPredicateBuilder<ExtensionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("timeoutInMs")),
            p => new CombinationQueryPredicate<ExtensionQueryBuilderDsl>(p, ExtensionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
