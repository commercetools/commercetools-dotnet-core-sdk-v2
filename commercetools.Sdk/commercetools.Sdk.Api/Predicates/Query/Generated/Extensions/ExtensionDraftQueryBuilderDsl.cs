using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionDraftQueryBuilderDsl
    {
        public ExtensionDraftQueryBuilderDsl()
        {
        }

        public static ExtensionDraftQueryBuilderDsl Of()
        {
            return new ExtensionDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ExtensionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ExtensionDraftQueryBuilderDsl>(p, ExtensionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionDraftQueryBuilderDsl> Destination(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionDestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionDestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("destination"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionDestinationQueryBuilderDsl.Of())),
                ExtensionDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ExtensionDraftQueryBuilderDsl> Triggers(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionTriggerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionTriggerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("triggers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionTriggerQueryBuilderDsl.Of())),
                ExtensionDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ExtensionDraftQueryBuilderDsl> Triggers()
        {
            return new CollectionPredicateBuilder<ExtensionDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("triggers")),
                    p => new CombinationQueryPredicate<ExtensionDraftQueryBuilderDsl>(p, ExtensionDraftQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ExtensionDraftQueryBuilderDsl, long> TimeoutInMs()
        {
            return new ComparisonPredicateBuilder<ExtensionDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("timeoutInMs")),
            p => new CombinationQueryPredicate<ExtensionDraftQueryBuilderDsl>(p, ExtensionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
