using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionUpdateActionQueryBuilderDsl
    {
        public ExtensionUpdateActionQueryBuilderDsl()
        {
        }

        public static ExtensionUpdateActionQueryBuilderDsl Of()
        {
            return new ExtensionUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ExtensionUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ExtensionUpdateActionQueryBuilderDsl>(p, ExtensionUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ExtensionUpdateActionQueryBuilderDsl> AsChangeDestination(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionChangeDestinationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionChangeDestinationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionChangeDestinationActionQueryBuilderDsl.Of()),
                ExtensionUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ExtensionUpdateActionQueryBuilderDsl> AsChangeTriggers(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionChangeTriggersActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionChangeTriggersActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionChangeTriggersActionQueryBuilderDsl.Of()),
                ExtensionUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ExtensionUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionSetKeyActionQueryBuilderDsl.Of()),
                ExtensionUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ExtensionUpdateActionQueryBuilderDsl> AsSetTimeoutInMs(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionSetTimeoutInMsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionSetTimeoutInMsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionSetTimeoutInMsActionQueryBuilderDsl.Of()),
                ExtensionUpdateActionQueryBuilderDsl.Of);
        }
    }
}
