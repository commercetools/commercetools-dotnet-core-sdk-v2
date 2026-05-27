using System;

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
        public CombinationQueryPredicate<ExtensionDraftQueryBuilderDsl> Dependencies(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("dependencies"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionResourceIdentifierQueryBuilderDsl.Of())),
                ExtensionDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ExtensionDraftQueryBuilderDsl> Dependencies()
        {
            return new CollectionPredicateBuilder<ExtensionDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("dependencies")),
                    p => new CombinationQueryPredicate<ExtensionDraftQueryBuilderDsl>(p, ExtensionDraftQueryBuilderDsl.Of));
        }
        public IComparableCollectionPredicateBuilder<ExtensionDraftQueryBuilderDsl, string> ExpansionPaths()
        {
            return new ComparableCollectionPredicateBuilder<ExtensionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("expansionPaths")),
            p => new CombinationQueryPredicate<ExtensionDraftQueryBuilderDsl>(p, ExtensionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionDraftQueryBuilderDsl> AdditionalContext(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionAdditionalContextDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionAdditionalContextDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("additionalContext"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionAdditionalContextDraftQueryBuilderDsl.Of())),
                ExtensionDraftQueryBuilderDsl.Of);
        }


    }
}
